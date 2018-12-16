GameEngine - Utilized JavaScript and HTML to create a game engine with user interaction and deterministic game loop

Optimized.html

A canvas initially set with a bear on top of the panda bear (so you only see the brown bear).
	
User can use arrow keys to move the brown bear. Brown bear will move accordingly. Bear cannot exit the boundary of the canvas.
	
Panda bear trails brown bear's path by initially moving slower than the brown bear then accelreating up to maintain a fixed distance.
	
If user gives no more input, brown bear will stop moving, and panda will soon follow until it reaches resting state.
	
User can change the first slider to change the desired FPS. The code constantly updates current FPS, displays it on top left.
	
If FPS changes (change in desired value or hardware), then the brown bear takes larger step accordingly, and thus user observes same speed.
	
Similarly, the buffer that keeps track of panda's next position also changes in size so that user observes same maximum fixed distance between the bear and the panda.
	
The slider on right changes the maximum distance that panda can trail the bear. Higher the value, larger the maximum trailing distance.
	
For example, set the value, keep moving the bear in one direction and observe the fixed distance that panda is trailing at. Then do same with different value
	
Only with large trailing distance user can observe the face of the panda (or else user only sees part of the white circle)
		
FPS for this application on GTX1070 does not exceed 31, so I made my slider bar from 1 to 30)
	
Series of test runs were made to make sure that this application is deterministic. I tested using the desired FPS of 5, 10, 15, 20, 25, and 30.
For example, I measured that it takes 9.0 seconds for bear to travel horizontally and 6.6 seconds to travel vertically accross the canvas.
I did observe error of 0.06 seconds due to the fluctuation in actual FPS at the high desired FPS. This is due to FPS fluctuation at high desired value.
