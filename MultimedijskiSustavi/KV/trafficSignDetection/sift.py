import cv2
import os
MIN_MATCH_COUNT = 15

sift = cv2.SIFT_create(nfeatures=200)
for selected_image in os.listdir("selected_images"):

    img1 = cv2.imread(os.path.join("selected_images",selected_image))  
    match_check=False
    for main_image in os.listdir("main_images"):
        img2 = cv2.imread(os.path.join("main_images",main_image))  

        kp1, des1 = sift.detectAndCompute(img1, None)
        kp2, des2 = sift.detectAndCompute(img2, None)

        # Brute Force Matching
        bf = cv2.BFMatcher()
        matches = bf.knnMatch(des1, des2,k=2)
        good = []
        for m, n in matches:
            if m.distance < 0.75 * n.distance:
                good.append(m)

        if len(good) > MIN_MATCH_COUNT:
            match_check=True
            cv2.imshow('1',img1)
            cv2.imshow('2',img2)
            print("Match found: "+ str(len(good)) + "common keypoints are found between" + selected_image +" and "+ main_image )
            cv2.waitKey(0)
            break
    if match_check==False :
        print("Match not found")


