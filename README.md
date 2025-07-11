<!-- PROJECT LOGO -->
<div>
  <h3>
    <img align="left" width="200" height="200" src="MastermindGame/images/QfZOzZ8VwU.png"><br/>
    Mastermind Game
  </h3>
</div>   

<br/>

<br/>

<br/>

<br/>

<br/>

## Project Info
**Role:** Solo Developer
<br/>
**Duration:** 5 hours
<br/>**Tech:** C#

> [!NOTE]
>**Installation GUIDE:**
>  <br/>
> **.NET SDK Required:**
> .NET SDK (version [insert version] or later)

 **How to Run:**
- Clone the repository.
- Open the terminal and navigate to the project directory.
- Run the game using:
```bash
dotnet run
```
- You can specify the game:
  - The hidden code.
```bash
dotnet run -c 1234
```
 - The Attempts.
```bash
dotnet run -t 15
```

## Introduction

Mastermind is a classic code-breaking logic game I recreated as a terminal-based C# project. The game challenges players to decipher a hidden code using logical deduction within a limited number of attempts.

I developed this project as part of my application to the Savvy Kickstarter Program

##  Main Mechanics

- The game randomly generates a **4-digit number** using digits from 0 to 8, with **no repeating digits**.
- Check the player's guess by providing feedback.
  - Well-placed pieces (X) – correct digit in the correct position.
  - Misplaced pieces (Y) – correct digit but in the wrong position.

## Features

