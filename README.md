
# Rock Paper Scissors Game

Welcome to the **Rock Paper Scissors Game**, a console-based implementation of the classic game where you can play against the CPU!

## Table of Contents

- [Description](#description)
- [Installation](#installation)
- [Usage](#usage)
- [How to Play](#how-to-play)
- [Contributing](#contributing)
- [License](#license)

## Description

This project is a simple console game where players can choose between the three iconic moves: rock, paper, or scissors. The game is played against a CPU that makes random choices. Each round, the player's and CPU's choices are compared to determine the winner, and the score is displayed.

This project is built in C# using the .NET framework and is part of the `RockPaperScissorsProject` repository.

## Installation

To run this project locally, follow the steps below:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/fhazraty/RockPaperScissors.git
   ```

2. **Navigate to the project directory**:
   ```bash
   cd RockPaperScissors/RockPaperScissorsProject
   ```

3. **Open the project in Visual Studio** or your preferred IDE for .NET development.

4. **Build the project**:
   Use the build tools in your IDE or use the .NET CLI:
   ```bash
   dotnet build
   ```

5. **Run the project**:
   ```bash
   dotnet run
   ```

## Usage

After running the project, the console will display a main menu where you can start the game or exit the program.

- **Enter The Game**: Select this option to start the game.
- **Exit**: Select this option to exit the application.

Once inside the game, you'll be asked to choose one of the available weapons: Paper, Rock, or Scissors. The game will then randomly generate a choice for the CPU and display the result, showing who won the round.

### Game Controls:

1. **Paper (1)**: Beats Rock, but loses to Scissors.
2. **Rock (2)**: Beats Scissors, but loses to Paper.
3. **Scissors (3)**: Beats Paper, but loses to Rock.
4. **Exit (4)**: Return to the main menu and reset the scores.

### Scoring:

- For each win, your score increases by 1.
- If the CPU wins, its score increases by 1.
- If it's a draw, no points are awarded.
- You can reset the game anytime by choosing the "Exit to Main Menu" option.

## How to Play

1. After entering the game, select your move by typing the corresponding number (1 for Paper, 2 for Rock, 3 for Scissors).
2. The CPU will randomly select its move.
3. The winner of the round will be announced.
4. You can play as many rounds as you'd like.
5. At any time, you can return to the main menu by selecting the "Exit to Main Menu" option.

## Contributing

Contributions are welcome! If you'd like to improve the game, fix bugs, or add new features, please follow these steps:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Make your changes.
4. Commit your changes:
   ```bash
   git commit -m 'Add some feature'
   ```
5. Push to the branch:
   ```bash
   git push origin feature/your-feature-name
   ```
6. Open a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

---

Enjoy the game and feel free to provide feedback or request features!
