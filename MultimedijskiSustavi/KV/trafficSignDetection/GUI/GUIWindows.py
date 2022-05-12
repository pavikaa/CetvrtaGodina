import os
import cv2
from tkinter import *
from functions import *
from PIL import ImageTk, Image
from tkinter import filedialog

def algorithm(path, selectedAlgorithm):
    for refImage in os.listdir(refImagesPath):
        refImages.append(cv2.imread(os.path.join(refImagesPath,refImage)))
        classNames.append(os.path.splitext(refImage)[0])
        
    selectedImage=cv2.imread(path)
    desList = findDes(refImages,selectedAlgorithm)
    imgBlur = cv2.GaussianBlur(selectedImage, (5, 5), 0)
    hsvImg = cv2.cvtColor(imgBlur, cv2.COLOR_BGR2HSV)
    
    #Pretraživanje crvene boje, ukoliko je nema ili je zanemarive površine na slici prelazi se na plavu
    
    #Crvena boja
    rMask = redMask(hsvImg)
    
    imgRoiRed = getContours(rMask,selectedImage.copy())
    
    id = findID(imgRoiRed, desList, selectedAlgorithm)
    
    if id != -1:
        for widget in frame2.winfo_children():
            widget.destroy()
        Label(frame2, text="Prepoznat je znak: " + classNames[id]).pack(side="top")
        frame2.pack(side="left")
        blue,green,red = cv2.split(imgRoiRed)
        img = cv2.merge((red,green,blue))
        im = Image.fromarray(img).resize((400,400),Image.ANTIALIAS)
        my_image = ImageTk.PhotoImage(image=im)
        panel = Label(frame2, image=my_image)
        panel.image=my_image
        panel.pack(side="left",fill="none",expand="no")
        
    else:
    #Plava boja
       bMask = blueMask(hsvImg)
       imgRoiBlue = getContours(bMask,selectedImage.copy())
       id = findID(imgRoiBlue, desList, selectedAlgorithm)
       if id != -1:
           Label(frame, text="Prepoznat je znak: " + classNames[id]).pack(side="left")
       else:
            Label(frame, text="Znak nije prepoznat ili ne postoji u bazi podataka!").pack(side="left")
            
def open():
    window.winfo_children()[2].destroy()
    path = filedialog.askopenfilename(initialdir=os.getcwd()+"/selected_images", title="Odaberite fotografiju na kojoj želite prepoznati znak",filetypes=(("jpg files", "*.jpg"), ("all files", "*.*")))
    
    if not (path.endswith(".jpg") or path.endswith(".png")): 
        window.destroy()
        return
    
    frame.pack(side="left")
    my_image = ImageTk.PhotoImage(Image.open(path).resize((400,400),Image.ANTIALIAS))
    panel = Label(frame, image=my_image)
    panel.image=my_image
    panel.pack(side="left",fill="none",expand="no")
    
    Label(frame, text="Odaberite željeni algoritam").pack(side="top")
    v = IntVar()
    options=[
        "ORB",
        "SIFT"
    ]
    for i, option in enumerate(options):
        Radiobutton(frame, text=option, variable=v, value=i).pack(side="top")
        
    Button(frame,text="Odabir", command=lambda: algorithm(path, v.get())).pack(side="top")
    
    
refImagesPath="ref_images"
refImages=[]
classNames = []

window = Tk()
frame = Frame(window)
frame2 = Frame(window)
window.title('Detekcija i prepoznavanje prometnih znakova zasnovani na izdvajanju značajki')
window.geometry("1280x720")
window.configure(background='grey')
window.resizable(False,False)

button_open_image = Button(window, text="Odabir fotografije", command=open)
button_open_image.place(width=100,height=100)


window.mainloop()