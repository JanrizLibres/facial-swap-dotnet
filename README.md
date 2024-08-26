# Facial Swap Prototype
A prototype implementation of a face swapping algorithm that seamlessly transfers facial features from a designated source image onto a target image.

## Technologies Used
- C#: The primary programming language used for development.
- OpenCV: A popular open-source computer vision library for image processing tasks.
- Dlib: A C++ toolkit for machine learning, including face detection and landmark detection.
- Accord.NET: A framework for machine learning, signal processing, and computer vision applications.

## Usage
1. Download the application ZIP file and extract its contents to a desired location.
2. Prepare images:
   - selfie.jpg: Place a selfie image in the same directory as the extracted application files.
   - input.jpg: Place the target image you want to swap the face with in the same directory.
3. Run the application:
   - Double-click the executable file (named FaceSwapWinForm.exe) to start the application.

## Features
- Automatic face detection: The application automatically detects faces in the selfie and target images.
- Facial landmark detection: Key points are extracted from the faces to enable accurate swapping.
- Face swapping: The face from the selfie is seamlessly swapped onto the target image.
