import cv2
import numpy as np

#SIFT
sift = cv2.SIFT_create(nfeatures=200)

#ORB
orb = cv2.ORB_create()

def redMask(hsvImg):
    #Iznosi boja u HSV obliku
    lowerRed1 = np.array([0, 70, 60])
    upperRed1 = np.array([10, 255, 255])

    lowerRed2 = np.array([170, 70, 60])
    upperRed2 = np.array([180, 255, 255])
    
    redMask1 = cv2.inRange(hsvImg, lowerRed1, upperRed1)
    redMask2 = cv2.inRange(hsvImg, lowerRed2, upperRed2)
    
    mask= cv2.bitwise_or(redMask1, redMask2)
    
    kernel = np.ones((5, 5), np.uint8)
    
    mask = cv2.morphologyEx(mask, cv2.MORPH_OPEN, kernel)
    mask = cv2.morphologyEx(mask, cv2.MORPH_CLOSE, kernel)
    
    return mask

def blueMask(hsvImg):
    lowerBlue = np.array([85, 130, 240])
    upperBlue = np.array([180, 255, 255])
    
    mask = cv2.inRange(hsvImg, lowerBlue, upperBlue)
    
    kernel = np.ones((5, 5), np.uint8)
    
    mask = cv2.morphologyEx(mask, cv2.MORPH_OPEN, kernel)
    mask = cv2.morphologyEx(mask, cv2.MORPH_CLOSE, kernel)
    
    return mask

def getRedContours(mask,img):
    hh, ww = mask.shape[:2]
    shape = -1
    contours,hierarchy = cv2.findContours(mask,cv2.RETR_EXTERNAL,cv2.CHAIN_APPROX_NONE)
    for cnt in contours:
        area = cv2.contourArea(cnt)
        if area>30000:
            cv2.drawContours(img, cnt, -1, (255, 0, 0), 3)
            peri = cv2.arcLength(cnt,True)
            approx = cv2.approxPolyDP(cnt,0.02*peri,True)
            objCor = len(approx)
            if objCor == 3: 
                shape = 3
            elif objCor == 4:
                shape = 4
            elif 4<= objCor <=8: 
                shape = 0
                
    if shape!=-1:
        mask = np.zeros((hh,ww), dtype=np.uint8)
        cv2.drawContours(mask, [cnt], 0, (255,255,255), cv2.FILLED)
        mask_inv = 255 - mask
        bckgnd = np.full_like(img, (255,255,255))
        image_masked = cv2.bitwise_and(img, img, mask=mask)
        bckgnd_masked = cv2.bitwise_and(bckgnd, bckgnd, mask=mask_inv)
        result = cv2.add(image_masked, bckgnd_masked)
        return result
    else:
        return img
    
def getBlueContours(mask,img):
    hh, ww = mask.shape[:2]
    shape = -1
    contours,hierarchy = cv2.findContours(mask,cv2.RETR_EXTERNAL,cv2.CHAIN_APPROX_NONE)
    for cnt in contours:
        area = cv2.contourArea(cnt)
        if area>30000:
            peri = cv2.arcLength(cnt,True)
            approx = cv2.approxPolyDP(cnt,0.02*peri,True)
            objCor = len(approx)
            if objCor == 3:
                shape = 3
            elif objCor == 4:
                shape = 4
            elif objCor == 8:
                shape = 0
 
    if shape!=-1:
        mask = np.zeros((hh,ww), dtype=np.uint8)
        cv2.drawContours(mask, [cnt], 0, (255,255,255), cv2.FILLED)
        mask_inv = 255 - mask
        bckgnd = np.full_like(img, (255,255,255))
        image_masked = cv2.bitwise_and(img, img, mask=mask)
        bckgnd_masked = cv2.bitwise_and(bckgnd, bckgnd, mask=mask_inv)
        result = cv2.add(image_masked, bckgnd_masked)
        return result
    else:
        return img

def findDes(images,alg):
    desList=[]
    match alg:
        #ORB
        case 1:
            for img in images:
                kp,des = orb.detectAndCompute(img,None)
                desList.append(des)
        #SIFT
        case 2:
            for img in images:
                kp,des = sift.detectAndCompute(img,None)
                desList.append(des)
                
    return desList

def findID(img, desList, alg):
    finalValue = -1
    
    if img is None:
        return finalValue
    
    thresh = 15
    matchList=[]
    match alg:
        #ORB
        case 1:
            bf = cv2.BFMatcher(normType=cv2.NORM_HAMMING, crossCheck=False)
            kp2, des2 = orb.detectAndCompute(img, None)
        #SIFT
        case 2:
            bf = cv2.BFMatcher(normType=cv2.NORM_L2, crossCheck=False)
            kp2, des2 = sift.detectAndCompute(img, None)
    
    try:
        for des in desList:
            matches = bf.knnMatch(des, des2, k=2)
            good = []
            for m,n in matches:
                if m.distance < 0.85*n.distance:
                    good.append([m])
            matchList.append(len(good))
    except:
        pass
    
    if len(matchList)!=0:
        if max(matchList) > thresh:
            finalValue = matchList.index(max(matchList))
    
    return finalValue