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

### Installation GUIDE:
> **.NET SDK Required:**
> .NET SDK (version [insert version] or later)
> <br/>
> **How to Run:**
> - Clone the repository.
> - Open the terminal and navigate to the project directory.
> - Run the game using:
> ```bash
>   dotnet run

## Introduction

Mastermind is a classic code-breaking logic game I recreated as a terminal-based C# project. The game challenges players to decipher a hidden code using logical deduction within a limited number of attempts.

I developed this project as part of my application to the Savvy Kickstarter Program

##  Main Mechanics

- The game randomly generates a **4-digit number** using digits from 0 to 8, with **no repeating digits**.
- Check the player's guess by providing feedback.
-- Well-placed pieces (X) – correct digit in the correct position.
-- Misplaced pieces (Y) – correct digit but in the wrong position.

The player uses these clues to narrow down the correct number through logic and deduction.

## Features

#### High Score System with PlayFab

<div style="display: flex; gap: 10px;">
  <img src="images/Screenshot 2024-01-27 220106.png" width="300"/>
  <img src="images/Screenshot 2024-01-27 220254.png" width="300"/>
</div>

I integrated the **PlayFab API** to allow player names and high scores to be saved online.  
A custom service manager sends requests from Unity to the PlayFab server, storing player data and displaying a leaderboard.  
Players can also generate random names for a faster experience.

#### Share Results on Social Media

<img src="images/photo_2024-01-27_22-12-28.jpg" width="300"/>

To increase player engagement, I added a feature that allows players to **share their game results** on social media.  
I captured all guesses and progress in a single camera view and generated a combined screenshot. Players can then share this image with a custom message.

#### Enhanced Guessing Aids

<img src="images/Screenshot 2024-01-29 110840.png" width="300"/>

To help players guess more effectively, I added interactive **analytics tools**:
- Players can **click numbers** to highlight or mark them.
- Two types of marks are supported: `"X"` for ruled-out digits and `"O"` for likely candidates.
