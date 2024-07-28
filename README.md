# AB Game

Welcome to the AB Game repository! This project is an implementation of the classic number-guessing game, inspired by the game Mastermind. In this game, one player sets a secret four-digit number with no repeating digits, and the other player tries to guess the number with the help of clues provided after each guess.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Gameplay Rules](#gameplay-rules)
- [Example](#example)

  
## Introduction

The AB Game is a two-player game where the Codemaker creates a secret number and the Codebreaker attempts to guess it. The Codemaker provides feedback on each guess in the form of "A" and "B". "A" indicates a correct digit in the correct place, while "B" indicates a correct digit in the wrong place.

## Features

- Simple and intuitive graphical user interface using WinForms
- Clear and detailed feedback for each guess
- Robust input validation to handle various edge cases
- Engaging gameplay with visual cues and easy-to-use controls

## Installation

To install and run the AB Game, follow these steps:

1. **Clone the repository:**
    ```sh
    git clone https://github.com/hasanzaidi1/AB_game.git
    cd AB_game
    ```

2. **Open the project in Visual Studio:**
    - Open Visual Studio.
    - Select `File` -> `Open` -> `Project/Solution`.
    - Navigate to the cloned repository folder and select the `.sln` file.

3. **Build and run the project:**
    - Build the solution by selecting `Build` -> `Build Solution`.
    - Run the application by selecting `Debug` -> `Start Debugging`.

## Usage

To start the game, follow these steps:

1. **Set the secret number:**
   - One player (Codemaker) sets a secret four-digit number with no repeated digits using the provided Codemaker interface by clicking on "Generate Number" button.

![Set Secret Number](https://github.com/hasanzaidi1/AB_game/assets/106449458/3ca7ac5a-0d32-4756-a569-b658c18872a1)

2. **Make a guess:**
   - The other player (Codebreaker) tell their guess of a four-digit number with no repeated digits to the Codemaker and Codemaker enters it into the field and submits it.

![Codebreaker](https://github.com/hasanzaidi1/AB_game/assets/106449458/243d4527-43c1-4aae-b983-68416491d821)
![image](https://github.com/hasanzaidi1/AB_game/assets/106449458/8b3e4dff-d018-470b-bd65-b0521143564b)
<img width="160" alt="Screenshot 2024-06-27 at 12 32 41 AM" src="https://github.com/hasanzaidi1/AB_game/assets/106449458/abb84934-b592-49c7-8bf4-876e3043c5f5">


3. **Codemaker recieves the guess:**
   - Codemaker recieves the guessed 4-digit number

![image](https://github.com/hasanzaidi1/AB_game/assets/106449458/544e8879-9964-421c-abac-f73501a1f225)


4. **Receive feedback:**
   - The Codemaker provides feedback in the form of "A" and "B" displayed on the screen:
     - "A" indicates a correct digit in the correct place.
     - "B" indicates a correct digit in the wrong place.
     
![image](https://github.com/hasanzaidi1/AB_game/assets/106449458/87cc4d6b-a365-49aa-ab2f-d89be01082f9)

5. **Repeat until the secret number is guessed:**
   - The game continues until the Codebreaker correctly guesses the secret number means Codemaker shows 4A0B as a Hint.

## Gameplay Rules

1. **Setting the Secret Number:**
   - The Codemaker sets a secret four-digit number with no repeating digits.

2. **Making a Guess:**
   - The Codebreaker makes a guess of a four-digit number with no repeated digits.

3. **Receiving Feedback:**
   - For each guess, the Codemaker provides feedback in the form of "A" and "B".
   - "A" indicates a digit that is correct in both value and position.
   - "B" indicates a digit that is correct in value but not in position.

4. **Winning the Game:**
   - The Codebreaker wins if they correctly guess the secret number.



