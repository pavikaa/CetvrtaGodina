import os
from functions import *
refImagesPath="ref_images"
selImagesPath="selected_images"

#Odabir algoritma, 1 za ORB, 2 za SIFT
selectedAlgorithm=2
counter=0

selectedImages=[]
selectedImagesNames=[]
refImages=[]
classNames = []
confusionMatrix = []

#Image loading
for selectedImage in os.listdir(selImagesPath):
    selectedImages.append(cv2.imread(os.path.join(selImagesPath,selectedImage)))
    selectedImagesNames.append(str(selectedImage)[:-8])

for refImage in os.listdir(refImagesPath):
    refImages.append(cv2.imread(os.path.join(refImagesPath,refImage)))
    classNames.append(os.path.splitext(refImage)[0])

rows, cols = (len(refImages)+1, len(refImages)+1)
arr=[]
for i in range(rows):
    col = []
    for j in range(cols):
        col.append(0)
    arr.append(col)
    
print('Broj referentnih znakova', len(refImages))
print(classNames)

desList = findDes(refImages,selectedAlgorithm)

for selectedImage in selectedImages:
    imgBlur = cv2.GaussianBlur(selectedImage, (5, 5), 0)
    hsvImg = cv2.cvtColor(imgBlur, cv2.COLOR_BGR2HSV)
    
    #Crvena boja
    rMask = redMask(hsvImg)
    
    imgRoiRed = getRedContours(rMask,selectedImage.copy())
    
    id = findID(imgRoiRed, desList, selectedAlgorithm)
    
    if id != -1:
        print("Prepoznat je znak: " + classNames[id])
        
    else:
    #Plava boja
       bMask = blueMask(hsvImg)
       imgRoiBlue = getBlueContours(bMask,selectedImage.copy())
       id = findID(imgRoiBlue, desList, selectedAlgorithm)
       if id != -1:
           print("Prepoznat je znak: " + classNames[id])
       else:
            print("Znak nije prepoznat ili ne postoji u bazi podataka!")
            
    if id != -1:
        arr[classNames.index(selectedImagesNames[counter])][id]+=1
    else:
        arr[classNames.index(selectedImagesNames[counter])][len(refImages)]+=1
        
    print(selectedImagesNames[counter])
    counter+=1
        
    #cv2.imshow("Prepoznavanje znaka pomocu", selectedImage)
    #cv2.waitKey(200)
    #cv2.destroyAllWindows()
numberOfCorrectlyDetectedSigns=0
classNames.append('random')
for i in range(len(arr)):
    numberOfCorrectlyDetectedSigns+=arr[i][i]
    print(classNames[i] +" "+str(arr[i]))
print("Number of correctly detected signs is: " + str(numberOfCorrectlyDetectedSigns) + " out of : " + str(len(selectedImages)) +" signs.")