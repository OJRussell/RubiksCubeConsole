# RubiksCubeConsole
My Rubik's Cube Challenge solution - Console App Version 

# Instructions 

To Run the App, Complie it in Visual Studio.

The face turn commands are the following:

"F" --> Front face Clockwise
"F'" --> Front face Anti-Clockwise
"B" --> Back face Clockwise
"B'" --> Back face Anti-Clockwise
"L" --> Left face Clockwise
"L'" --> Left face Anti-Clockwise
"R" --> Right face Clockwise
"R'" --> Right face Anti-Clockwise
"U" --> Up face Clockwise
"U'" --> Up face Anti-Clockwise
"D" --> Down face Clockwise
"D'" --> Down face Anti-Clockwise

"Reset" --> Resets the cube to the orignal state

"Quit" --> Stops program from running

# Notes

Currently the program has some issues, after a few combinations are entered the colours get mismatched.
This is due to the way I coded the cube without incuding that opposite facing cubes move in an opposite directions.
Unfortuntly trying to make it work, I've made the code quite messy in the method 'RotateConnectedCubes()' and it's connected methods.
I have relaised I have come at this at the wrong angle.
I should not have stored the connections to each face, rather get the next position based off the current position, current face and rotaion direction.
Going forward I would also go through the code and refactor methods, variable names, etc, to make the code more readable and maintainable.