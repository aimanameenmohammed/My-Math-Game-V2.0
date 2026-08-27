# 🧠 Math Genius Challenge

<p align="center">

<img src="MathGame.png" alt="Math Genius Challenge" width="850"/>

</p>

<h3 align="center">
A modern desktop math challenge game built with C# and Windows Forms.
</h3>

<p align="center">
Designed to improve mental arithmetic through timed questions, multiple difficulty levels, arithmetic operations, instant feedback, and an interactive user interface.
</p>

<p align="center">

![Language](https://img.shields.io/badge/Language-C%23-512BD4?style=for-the-badge&logo=csharp&logoColor=white)
![Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![UI](https://img.shields.io/badge/UI-WinForms-0078D4?style=for-the-badge&logo=windows&logoColor=white)
![Graphics](https://img.shields.io/badge/Graphics-GDI%2B-555555?style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-28A745?style=for-the-badge)

</p>

---

## 📌 Quick Navigation

- [📖 Overview](#-overview)
- [✨ Key Features](#-key-features)
- [🎮 Game Flow](#-game-flow)
- [🧠 Difficulty Levels](#-difficulty-levels)
- [➕ Operation Types](#-operation-types)
- [⏱️ Question Timer](#-question-timer)
- [📊 Results & Performance](#-results--performance)
- [🎵 Sound & Music](#-sound--music)
- [🎨 UI & User Experience](#-ui--user-experience)
- [🏗️ Architecture & Code Design](#️-architecture--code-design)
- [📁 Project Structure](#-project-structure)
- [📸 Screenshots](#-screenshots)
- [🚀 Getting Started](#-getting-started)
- [🔧 How to Run](#-how-to-run)
- [🆚 Evolution from C++ to C#](#-evolution-from-c-to-c)
- [📚 Learning Objectives](#-learning-objectives)
- [📄 License](#-license)
- [👨‍💻 Author](#-author)

---

## 📖 Overview

**Math Genius Challenge** is an interactive desktop mathematics game developed using **C#** and **Windows Forms**.

The project was developed as a modernized evolution of an earlier **C++ console-based Math Game (V1.0)**.

The goal of the project is not only to generate mathematical questions, but also to create a complete interactive game experience where the player can:

- Choose the number of questions.
- Select the time allowed for each question.
- Choose a difficulty level.
- Select a specific arithmetic operation.
- Use a mixed operation mode.
- Answer dynamically generated questions.
- Receive immediate visual and audio feedback.
- Track correct, incorrect, and unanswered questions.
- Review the final performance.
- Restart the challenge and play again.

The C# version focuses heavily on improving the **User Experience (UX)** while maintaining the core mathematical challenge of the original project.

---

## ✨ Key Features

### 🎯 Custom Game Configuration

Before starting the challenge, the player can configure the game according to their preference.

Available settings include:

- 🔢 Number of questions.
- ⏱️ Time limit for each question.
- 🧠 Difficulty level.
- ➕ Arithmetic operation.
- 🔀 Mixed operation mode.

This gives the player control over the overall difficulty and challenge before gameplay begins.

---

### 🧠 Multiple Difficulty Levels

The game provides four difficulty modes:

| Level | Description |
|---|---|
| 🟢 **Easy** | Uses smaller numbers and simpler calculations. |
| 🟡 **Medium** | Provides a greater level of challenge through larger calculations. |
| 🔴 **Hard** | Designed for players looking for a stronger mental arithmetic challenge. |
| 🔀 **Mix** | Dynamically combines different difficulty levels. |

The difficulty level affects the range of generated numbers and therefore the complexity of the questions.

---

### ➕ Multiple Operation Types

The game supports several arithmetic operations:

- ➕ **Addition**
- ➖ **Subtraction**
- ✖️ **Multiplication**
- ➗ **Division**
- 🔀 **Mixed Operations**

When **Mixed Operations** is selected, the game dynamically chooses an operation during gameplay.

---

### 🎲 Random Question Generation

Questions and answer choices are generated dynamically.

The game uses randomization to:

- Generate the mathematical operands.
- Select operations.
- Generate answer choices.
- Determine the position of the correct answer.
- Prevent duplicate answer choices.
- Create a different challenge each time.

This keeps gameplay unpredictable and prevents the player from memorizing a fixed sequence.

---

### 🎯 Four Answer Choices

Each question provides four possible answers.

The correct result is generated from the mathematical expression while the remaining choices are generated dynamically.

The game also checks answer values to prevent duplicate choices from appearing.

---

### ⏱️ Question Timer

Every question has its own countdown timer.

The player can configure the amount of time allowed for each question.

During gameplay:

- ⏱️ The timer counts upward toward the configured limit.
- 🟢 The timer provides visual feedback.
- ⚠️ The player must answer before the time expires.
- ⏭️ If time runs out, the question is automatically treated as unanswered.
- 📊 The unanswered question is included in the final results.

This adds a competitive element and encourages fast mental calculation.

---

### 📊 Results & Performance

After completing the challenge, the player can review the final performance.

The game keeps track of:

- ✅ Correct answers.
- ❌ Wrong answers.
- ⏭️ Unanswered questions.
- 🔢 Total questions.
- 🧠 Selected difficulty.
- ➗ Selected operation.
- ⏱️ Time per question.

The final result is displayed directly inside the application rather than opening a separate results window.

---

### 🔄 Restart & Replay

After completing a game, the player can restart the challenge.

Restarting resets:

- Question count.
- Timer.
- Score.
- Correct answers.
- Wrong answers.
- Unanswered questions.
- Selected options.
- Progress.
- Final result panel.

The player can therefore start a completely new challenge without restarting the application.

---

## 🎮 Game Flow

The overall gameplay follows a simple and clear flow:

```text
┌──────────────────────────────┐
│        ⚙️ Game Settings      │
│                              │
│  • Number of Questions       │
│  • Time per Question         │
│  • Difficulty Level          │
│  • Operation Type            │
└──────────────┬───────────────┘
               │
               ▼
┌──────────────────────────────┐
│      🚀 Start Challenge      │
└──────────────┬───────────────┘
               │
               ▼
┌──────────────────────────────┐
│       🧮 Generate Question   │
│                              │
│  • Random Numbers            │
│  • Random Operation          │
│  • Answer Choices            │
└──────────────┬───────────────┘
               │
               ▼
┌──────────────────────────────┐
│          ⏱️ Timer            │
│                              │
│     Answer the Question      │
└──────────────┬───────────────┘
               │
        ┌──────┴──────┐
        │             │
        ▼             ▼
   ✅ Answered     ⏰ Timeout
        │             │
        └──────┬──────┘
               ▼
┌──────────────────────────────┐
│       📈 Update Progress     │
└──────────────┬───────────────┘
               │
               ▼
        More Questions?
          │          │
         Yes         No
          │          │
          ▼          ▼
     Next Question  📊 Final Result
                         │
                         ▼
                  🔄 Play Again
```

The flow is intentionally simple so the player can focus on solving the mathematical problem rather than navigating complicated screens.

---

## 🧠 Difficulty Levels

### 🟢 Easy

Designed for basic mathematical practice.

Questions use smaller numbers and simpler calculations.

Example range:

```text
1 → 10
```

---

### 🟡 Medium

Provides a greater level of challenge through larger numbers.

Example range:

```text
1 → 15
```

---

### 🔴 Hard

Designed for players looking for a stronger mental arithmetic challenge.

Example range:

```text
1 → 25
```

---

### 🔀 Mix

The game dynamically selects between the available difficulty levels, creating a less predictable challenge.

---

## ➕ Operation Types

### ➕ Addition

Practice addition using dynamically generated numbers.

```text
Example:

7 + 5 = ?
```

---

### ➖ Subtraction

Practice subtraction with dynamically generated values.

```text
Example:

18 - 7 = ?
```

---

### ✖️ Multiplication

Practice multiplication using generated numbers.

```text
Example:

6 × 4 = ?
```

---

### ➗ Division

Practice division using generated values.

```text
Example:

20 ÷ 5 = ?
```

---

### 🔀 Mixed Operations

The game can dynamically select between the supported arithmetic operations.

This creates a more unpredictable challenge because the player must identify the operation before solving the question.

---

## ⏱️ Question Timer

The timer is configurable from the game settings.

For every question:

```text
Start Question
      │
      ▼
Start Timer
      │
      ├───────────────┐
      │               │
      ▼               ▼
Player Answers    Time Expires
      │               │
      ▼               ▼
Check Answer      Unanswered
      │               │
      └───────┬───────┘
              ▼
        Next Question
```

When the configured time expires, the current question is automatically processed as unanswered and the game continues.

---

## 📊 Results & Performance

The game maintains player statistics throughout the challenge.

### Tracked Statistics

```text
Total Questions
       │
       ├── ✅ Correct Answers
       │
       ├── ❌ Wrong Answers
       │
       └── ⏭️ Unanswered Questions
```

The result panel gives the player a quick overview of their performance after the challenge.

---

## 🎵 Sound & Music

The application includes sound and background music functionality to make the gameplay more interactive.

### 🔊 Music Controls

The player can control the background music:

- 🔊 **ON** — continue playing background music.
- 🔇 **OFF** — stop the background music.

The application also provides sound feedback during certain game interactions, helping make the game loop more engaging.

---

## 🎨 UI & User Experience

One of the main improvements in the C# version is the graphical user interface.

Instead of the original console-oriented experience, the new version provides a dedicated Windows Forms interface.

### UI Improvements

- 🎨 Modern visual design.
- 🔘 Rounded buttons.
- 🧩 Reusable UI helper methods.
- 📦 Styled containers and panels.
- 🎯 Clear selection states.
- 📊 Integrated results panel.
- ⏱️ Visual timer.
- 🔊 Music controls.
- 🖥️ Desktop graphical interface.

The project also uses **GDI+** techniques to customize the appearance of controls and create rounded UI elements.

---

## 🏗️ Architecture & Code Design

Although this is a relatively small desktop application, the code was organized with a strong focus on maintainability and reusable logic.

### 🧩 Main Components

```text
┌────────────────────────────────────┐
│          🖥️ Windows Forms UI       │
│                                    │
│        frmMathGame.cs              │
└──────────────────┬─────────────────┘
                   │
                   ▼
┌────────────────────────────────────┐
│       ⚙️ Game Logic & State        │
│                                    │
│  • Question Generation             │
│  • Difficulty Handling             │
│  • Operation Handling              │
│  • Answer Validation               │
│  • Timer Management                │
│  • Result Tracking                 │
└──────────────────┬─────────────────┘
                   │
                   ▼
┌────────────────────────────────────┐
│       🎨 UI Helper Utilities       │
│                                    │
│           ClsUIcs.cs               │
│                                    │
│  • Rounded Regions                 │
│  • Container Styling               │
│  • Question Area Styling           │
│  • Reusable UI Functions           │
└────────────────────────────────────┘
```

---

## 🧼 Clean Code Practices

The project applies several clean-code concepts during implementation.

### 🔁 Reusable Event Handling

Common controls can share event-handling logic instead of duplicating the same code for every button.

This reduces unnecessary repetition and follows the **DRY — Don't Repeat Yourself** principle.

---

### 🧩 Reusable UI Helper

The `ClsUIcs` class contains reusable UI functions responsible for styling controls.

For example:

- Applying rounded regions.
- Styling containers.
- Styling the question area.
- Applying consistent visual behavior.

This keeps UI styling logic separate from the main game logic.

---

### 🧠 Enumerations

The game uses enumerations to represent:

- Operation types.
- Difficulty levels.

This makes the code easier to read and reduces the use of unexplained numeric values.

Conceptually:

```text
Operation Type

ePlus
eMinus
eMultiplication
eDivision
eMix
```

and:

```text
Difficulty Level

eEasy
eMedium
eHard
eMix
```

---

## 🎲 Question Generation Logic

The game dynamically generates questions based on the selected difficulty.

The number ranges are adjusted according to the selected level.

```text
Easy
  ↓
1 → 10

Medium
  ↓
1 → 15

Hard
  ↓
1 → 25
```

For mixed difficulty, the game dynamically selects a difficulty level before generating the question.

The generated answer choices are also checked to ensure duplicate values are not displayed.

---

## 🧮 Answer Validation

The game stores information about the current challenge, including:

- Correct answer.
- Number of correct answers.
- Number of wrong answers.
- Number of unanswered questions.
- Total questions.
- Selected difficulty.
- Selected operation.
- Time per question.

This information is then used to produce the final performance summary.

---

## 📁 Project Structure

```text
My-Math-Game-V2.0/
│
├── 📁 Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.resx
│   ├── Resources.Designer.cs
│   └── Settings.settings
│
├── 📁 Resources/
│   ├── 🎵 Music & Sound Resources
│   ├── 🖼️ UI Images
│   └── 🎨 Application Assets
│
├── 📄 App.config
├── 📄 ClsUIcs.cs
├── 📄 frmMathGame.cs
├── 📄 frmMathGame.Designer.cs
├── 📄 frmMathGame.resx
├── 📄 Program.cs
│
├── 📄 MyMathGame.csproj
├── 📄 MyMathGame.sln
├── 📄 MathGame.png
├── 📄 LICENSE.txt
└── 📄 README.md
```

---

## 📸 Screenshots

<details>
<summary>🖼️ View Main Game Screenshot</summary>

<br>

<p align="center">

<img src="MathGame.png" alt="Math Genius Challenge - Main Game Interface" width="850"/>

</p>

</details>

> More screenshots can be added to this section as the project documentation grows.

---

## 🚀 Getting Started

### 📋 Prerequisites

Before running the project, make sure you have:

- 🪟 Windows.
- 💻 Visual Studio 2019 or newer.
- 🧩 .NET Framework 4.7.2.
- 🛠️ A compatible C# development environment.

The project targets **.NET Framework 4.7.2**.

---

## 📥 Installation

### 1️⃣ Clone the Repository

Open a terminal or Git Bash and run:

```bash
git clone https://github.com/aimanameenmohammed/My-Math-Game-V2.0.git
```

---

### 2️⃣ Open the Solution

Navigate to the cloned project folder and open:

```text
MyMathGame.sln
```

with Visual Studio.

---

### 3️⃣ Restore / Verify the Project

Allow Visual Studio to restore or resolve the required project dependencies if necessary.

The project is a traditional .NET Framework Windows Forms application.

---

### 4️⃣ Build the Project

From Visual Studio:

```text
Build
   ↓
Build Solution
```

or use:

```text
Ctrl + Shift + B
```

---

### 5️⃣ Run the Game

Press:

```text
F5
```

or select:

```text
Start
```

from Visual Studio.

---

## ▶️ How to Play

### Step 1 — Configure the Challenge

Choose:

```text
Number of Questions
        +
Time per Question
        +
Difficulty Level
        +
Operation Type
```

---

### Step 2 — Start the Challenge

Click:

```text
🚀 Start Challenge
```

---

### Step 3 — Solve the Question

Read the generated mathematical expression and choose one of the four available answers.

---

### Step 4 — Continue

After selecting an answer, continue to the next question.

The game automatically updates the progress and score.

---

### Step 5 — Complete the Challenge

After all questions have been processed, the final results are displayed.

---

### Step 6 — Play Again

Use the restart/replay functionality to start another challenge with a fresh state.

---

## 🆚 Evolution from C++ to C#

This project represents the evolution of an earlier console-based C++ implementation into a graphical C# Windows Forms application.

### 🟦 Previous Version — C++

The original project was implemented as a console application.

It focused primarily on:

- Question generation.
- Difficulty levels.
- Arithmetic operations.
- Randomized answers.
- Correct/wrong answer tracking.
- Basic quiz flow.

### 🟪 Current Version — C#

The C# version expands the concept into a graphical desktop application.

It adds:

- 🖥️ Windows Forms UI.
- 🎨 Modern visual styling.
- 🔘 Rounded controls.
- ⏱️ Configurable question timer.
- 📊 Integrated results panel.
- 🎵 Background music and sound feedback.
- 🔀 Interactive game configuration.
- 🧩 Reusable UI helper methods.
- 🧼 More structured and maintainable code.

### 🔗 Explore the Original C++ Version

The original C++ implementation is available here:

**[Math-Game-V1.0 — C++ Version](https://github.com/aimanameenmohammed/Math-Game-V1.0)**

This makes the project a useful example of how the same core idea can evolve from a console application into a more interactive graphical desktop application.

---

## 📚 Learning Objectives

This project was built as a practical exercise to reinforce several programming concepts.

### 💻 C#

- Classes and objects.
- Enumerations.
- Methods.
- Events.
- Collections.
- Random number generation.
- Windows Forms.
- Resource management.

### 🧠 Problem Solving

- Designing question-generation logic.
- Generating valid answer choices.
- Preventing duplicate answers.
- Handling different difficulty levels.
- Managing game state.
- Tracking player performance.

### 🎨 UI Development

- Windows Forms controls.
- Custom control styling.
- Rounded UI elements.
- Dynamic colors.
- Panels and containers.
- Interactive controls.
- User feedback.

### 🧼 Code Quality

- Reusable helper methods.
- DRY principle.
- Separation of UI styling from game logic.
- Meaningful enumerations.
- Organized event handling.

---

## 💡 What Makes This Project Interesting?

The project combines several different areas into one small but complete application:

```text
             🧠 Mathematics
                   │
                   ▼
            🎲 Randomization
                   │
                   ▼
             🎮 Game Logic
                   │
        ┌──────────┴──────────┐
        ▼                     ▼
    ⏱️ Timing              📊 Results
        │                     │
        └──────────┬──────────┘
                   ▼
             🎨 Windows UI
                   │
                   ▼
              🎵 Feedback
```

The result is more than a simple calculator or quiz.

It is a complete interactive desktop learning game that combines mathematical logic, randomization, timing, UI design, and user feedback.

---

## 🔮 Possible Future Improvements

Possible future extensions could include:

- 🏆 High-score system.
- 👤 Player profiles.
- 📈 Historical performance tracking.
- 🥇 Leaderboards.
- 💾 Saving game results.
- 🌐 Multiple languages.
- 🎚️ More customizable difficulty.
- 🎵 Additional sound themes.
- 📊 More detailed statistics.
- 🏅 Achievement system.

These are potential future ideas and are **not currently part of the implemented version**.

---

## 📄 License

This project is licensed under the **MIT License**.

The full license text is available here:

**[📜 View MIT License](LICENSE.txt)**

---

## 👨‍💻 Author

### [Ayman Ameen Mohammed](https://www.linkedin.com/in/aiman-ameen-2548673a/)

**Software Developer | C# | C++ | .NET | Database Development**

This project is part of my ongoing programming journey, focused on learning through practical projects, building real-world applications, and continuously improving software development skills.

🔗 **Connect with me:**

- 💼 [LinkedIn](https://www.linkedin.com/in/aiman-ameen-2548673a/)
- 🐙 [GitHub](https://github.com/aimanameenmohammed)
- 📦 [This Project – My-Math-Game-V2.0](https://github.com/aimanameenmohammed/My-Math-Game-V2.0)
---

## ⭐ Support

If you find this project useful or interesting:

- ⭐ Star the repository.
- 👀 Explore the source code.
- 💡 Share feedback.
- 🚀 Follow the development journey.

Every interaction is appreciated and helps support continued learning and improvement.

---

<p align="center">

### 🧠 Learn by Building. Build by Learning. 🚀

</p>

<p align="center">

**Math Genius Challenge — V2.0**

</p>
