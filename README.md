
# Battleship - Console Game :boat:

My goal is to make an simplified single player version of this game, with only one game field with four hidden boats. 
The goal is to uncover all hidden boats in as few moves as possible.

The player does not have it's own game field and won't get shot at by the CPU at this applications current state (but it might be developed later).

The player chooses coordinates A-J & 1-10 to aim at a spot. The player gets direct feedback if he hit a ship or not. After all boats are completely hit /uncovered, the game is won and the number of moves is saved to a highscore as CSV.


## Features

- Highscore that creates and saves ten top players/highscores
- A function that randomizes the enemy ship positions
- Use of 3d array for the game field (one layer for game field and one layer for the boat coordinates)




## Screenshots

![Game field](https://github.com/Bubbelbad/BattlefieldConsoleApp/blob/master/Screenshot%202023-10-30%20004901.png?raw=true)

I took inspiration for the graphics from --> [Battleship Game In C# Console](https://www.c-sharpcorner.com/blogs/battleship-game-in-c-sharp-console-part-1) 

