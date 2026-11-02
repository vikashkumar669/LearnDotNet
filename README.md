# LearnDotNet

Practice C# programs for the book **C# Programming for Indian Students** by Vikash Kumar, written for BCA and B.Tech students.

Each chapter has its own folder with the chapter PDF, every program from the chapter as a ready-to-run project, the mini project, and the solutions to the practice questions.

## Chapters

| Chapter | Topic | Folder |
| --- | --- | --- |
| 1 | Welcome to C# | [Chapter-01-Welcome-to-CSharp](Chapter-01-Welcome-to-CSharp) |
| 2 | Setting Up C# | [Chapter-02-Setting-Up-CSharp](Chapter-02-Setting-Up-CSharp) |
| 3 | C# Fundamentals (variables, data types) | [Chapter-03-CSharp-Fundamentals](Chapter-03-CSharp-Fundamentals) |
| 4 | Operators and User Input | [Chapter-04-Operators-and-User-Input](Chapter-04-Operators-and-User-Input) |
| 5 | Decision Making | [Chapter-05-Decision-Making](Chapter-05-Decision-Making) |
| 6 | Loops | [Chapter-06-Loops](Chapter-06-Loops) |

## How each chapter folder is organised

```text
Chapter-NN-Title/
  Chapter-NN-Title.pdf   <- the chapter to read
  README.md              <- list of programs in this chapter
  Examples/              <- programs explained inside the chapter
  MiniProject/           <- the chapter's mini project
  Solutions/             <- answers to the practice questions that need code
```

Every program sits in its own small console project (one folder, one `.csproj`, one `Program.cs`), so you can open and run any program on its own.

## What you need

- The **.NET 10 SDK** (Long Term Support). Check it with `dotnet --version`.
- **Visual Studio 2026** with the *.NET desktop development* workload, or Visual Studio Code with the C# Dev Kit. Visual Studio 2022 cannot build .NET 10 projects.

Chapter 2 of the book shows how to install both, step by step.

## How to run a program

**In Visual Studio**

1. Open `LearnDotNet.slnx` (File > Open > Project/Solution).
2. In Solution Explorer, right-click the program you want, for example `Program1_1_HelloIndia`, and choose **Set as Startup Project**.
3. Press **Ctrl + F5**.

**From the command line**

```bash
dotnet run --project Chapter-01-Welcome-to-CSharp/Examples/Program1_1_HelloIndia
```

Every program in this repository has been built and run with the .NET 10 SDK, and its output matches the output printed in the book.
