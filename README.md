## Platform:
.Net, Arduino
## Language:
C#, C++
## Software:
Proteous 8, Virtual Serial Port Driver, Visual Studio, Arduino IDE
# How to Run
1. Clone the Github repository.

![image](https://user-images.githubusercontent.com/8882310/230357343-6c0e6b12-b855-49d3-9e58-52b4c2d5fca7.png)

2. Open the Solution in Visual Studio.
3. Right Click on the Solution > Select ‘Set Startup Projects’

![image](https://user-images.githubusercontent.com/8882310/230357405-4e0f0a40-61f7-472f-90a5-fa143aac3667.png)

4. Select Multiple Startup Project. Select Start on Action dropdown for all the projects

![image](https://user-images.githubusercontent.com/8882310/230357443-590b147a-0f08-4d82-a5b1-a487a81d970d.png)

5. Open Virtual Serial Port Driver.
6. Select Merge and add 4 port named COM1, COM2, COM3, COM4

![image](https://user-images.githubusercontent.com/8882310/230357478-3fe386e8-3386-4d90-ba45-9d9957b8598a.png)

7. Arduino is using COM1, Keypad is using COM2, Visual Feed is using COM3 and Wearable device is using COM4
8.  Open the simulation hardware in Proteous 8. File name ‘locker automatic re-lock.pdsprj’
9.  Open the Arduino Code in the Arduio IDE. File name ‘PhysicalPixel.ino’
10. Click Verify in Arduino IDE. You will get a Hex file in output.

![image](https://user-images.githubusercontent.com/8882310/230357519-d10668e8-31d2-42f7-a16e-78674f252c77.png)

11. Copy this Path. And Paste in inside Proteous > Arduino > Edit Component > Program File

![image](https://user-images.githubusercontent.com/8882310/230357558-f9dcbc21-be2e-4eed-92da-e9000d4800bd.png)

12. Finally, Run the simulation and Run the Visual Studio Projects.
13. Follow the 'USER_GUIDE.pdf' file.
