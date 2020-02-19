# Unity Hacking Demo
How to hack and secure a Unity game.

**Instructions**

The demo consists of using Cheat Engine to attempt to modify a value that's loaded into memory. To replicate the demo, follow these steps:
1. Download the executables from the release.
2. Download Cheat Engine from the official website. https://www.cheatengine.org/
3. Run Hackable Game.exe.
4. Run Cheat Engine.
5. Select Hackable Game from Cheat Engine's list.
6. Type the variable's value (100 initially) into the value box.
7. If you haven't narrowed it to a single value, decrease the value of the variable in Hackable Game.exe.
8. Continue until you find the memory address corresponding to your value.
9. Modify the value.
10. Look at your game. The value should be changed.
11. Repeat steps 3-8 with Non-Hackable.exe.
12. You shouldn't be able to find the value ((*easily*))

There is a test case included in the code.
The executables, source code, and powerpoint are in the releases.

**Credits**

By Kristian Kurktchiev

With the help of Google, Wikipedia, and Cheat Engine's tutorials.
