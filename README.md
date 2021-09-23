## Face Enroll
PresentID Face Enroll API allows you to register your users for future authentication. This API stores two image files along with the user's personal information. Before saving, it is checked whether these two images belong to the one person or not so allows you to authenticate your user face image and personID.


![Enroll 1](https://user-images.githubusercontent.com/63470748/119660874-f9077080-be44-11eb-8e16-fd757dcc435c.jpg)

**Input:**
- Email address
- Group
- Image file
- PresonID (for Login by face)

**Output:**
- Result index
- Result message

**Features:**
- Accuracy is %99.76 on the LFW face verification dataset, a very popular benchmark.
- Less than 1500 milliseconds processing time.
- Support IOS, Android, Windows and Mac devices.
- Easy integration with your app.

**Use Cases:**
- Access Control
- Onboarding
- Fintech
- Car sharing & Taxi
- Online Brokers
- Health Care
- Dating Apps
- Customer Support

**Rules & Restrictions:**
- Send data via Base64 or an image URL or an image file.
- Image size should not exceed 8 MB.
- Also, the images should not be larger than 5000 pixels and smaller than 50 pixels.

## Free try in RapidAPI
https://rapidapi.com/PresentID/api/face-enroll1
