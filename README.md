# Steam Library or any game Tracker

## Project Description
This project is a simple Steam library tracker that I made using C#. The purpose of the program is to help keep track of video games that I own, how many hours I have played them, and how much I like them. I chose this idea because I play a lot of games and sometimes forget what I have or how much time I have spent on each game.
  The program runs in the console and uses a menu system so the user can choose what they want to do. The user can add a game by typing in the name, hours played, and a rating from 1 to 10. The program stores this information using lists, so each game is connected with its hours and rating. I used parallel lists to keep everything organized.
  The user can also view all of the games they have added. This shows the name of the game, how many hours have been played, and the rating. There is also a search feature where the user can type in the name of a game and it will display the information for that specific game.
  Another important part of the program is saving and loading data. The user can save their game list to a file so that it is not lost when the program closes. Then they can load the data later and continue where they left off. This is done using file reading and writing in C#.
  Overall, this project helped me practice important programming concepts like lists, loops, methods, and file handling. It also helped me understand how to build a full program that actually does something useful instead of just small assignments.

## Aspiration
For this project I wanted to make something I would actually use. I picked a Steam library tracker because I play video games and use Steam a lot. My goal was to make a simple program that keeps track of my games, how long I’ve played them, and how much I like them.

## Why this is interesting
This project is interesting to me because I already play games like Elden Ring, Call of Duty Black Ops 3, Rainbow Six Siege, Terraria, and Arc Raiders. Sometimes I forget what games I have or how much I’ve played them, so this program helps me keep everything in one place.

## What I completed
For this project I made a console program that lets me add games, see all my games, search for a game, and save/load my data. I also added hours played and ratings for each game. Everything is stored in lists and can be saved to a file so I don’t lose it.

## What I learned
I learned how to use lists to store data and how to use multiple lists together. I also learned how to save and load data from a file. I got better at using loops, methods, and user input. This project helped me understand how to build a full program instead of just small pieces.

## How the program works
The program shows a menu and lets the user pick what to do. You can add a game, view all games, search for one, or save/load your data. It keeps running until you choose to exit.

## Concepts used
- Lists (to store game data)
- Parallel lists (names, hours, ratings)
- if/else (menu and search logic)
- switch (menu options)
- while loop (runs the program)
- for loop (go through lists)
- foreach (extra way to loop through data)
- methods (AddGame, ViewGames, Save, Load, Search)
- reading from a file (loading saved data)
- writing to a file (saving data)
- user input (Console.ReadLine)
- string formatting (displaying output nicely)
- const (file name)

## **THE DIFFERENT TYPES OF DIAGRAMS I USED**

## Pseudocode
start program

loop forever
  show menu
  get user choice

  if 1 add game
  if 2 view games
  if 3 save
  if 4 load
  if 5 search
  if 6 exit

end loop

## Flowchart
Start
↓
Show Menu
↓
User picks option
↓
Do action (add/view/save/load/search)
↓
Repeat until exit

## Use Case
User:
- Add game
- View games
- Search game
- Save data
- Load data

## Tests
I used Debug.Assert to test simple conditions in my program and make sure it works correctly.

## Comments
I added comments in my code to explain what each method does and to make it easier to understand.
