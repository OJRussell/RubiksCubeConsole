# RubiksCubeConsole
My Rubik's Cube Challenge solution - Console App Version <br />

# Instructions <br />

To Run the App, Complie it in Visual Studio.<br />

The face turn commands are the following:<br />

"F" --> Front face Clockwise<br />
"F'" --> Front face Anti-Clockwise<br />
"B" --> Back face Clockwise<br />
"B'" --> Back face Anti-Clockwise<br />
"L" --> Left face Clockwise<br />
"L'" --> Left face Anti-Clockwise<br />
"R" --> Right face Clockwise<br />
"R'" --> Right face Anti-Clockwise<br />
"U" --> Up face Clockwise<br />
"U'" --> Up face Anti-Clockwise<br />
"D" --> Down face Clockwise<br />
"D'" --> Down face Anti-Clockwise<br />

"Reset" --> Resets the cube to the orignal state

"Quit" --> Stops program from running

# Notes

Currently the program has some issues, after a few combinations are entered the colours get mismatched.
This is due to the way I coded the cube without incuding that opposite facing cubes move in an opposite directions.
Unfortuntly trying to make it work, I've made the code quite messy in the method 'RotateConnectedCubes()' and it's connected methods.
I have relaised I have come at this at the wrong angle, 
I should not have stored the connections to each face, rather get the next position based off the current position, current face and rotaion direction.
Going forward I would also go through the code and refactor methods, variable names, etc, to make the code more readable and maintainable.
