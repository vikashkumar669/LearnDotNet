# Chapter 6: Loops

Read the chapter: [Chapter-06-Loops.pdf](Chapter-06-Loops.pdf)

The `for` loop, `while` and `do`-`while`, the `foreach` loop, `break` and `continue`, asking again until the input is valid, nested loops and star patterns.

Programs that read input wait for you to type. The sample input used in the book is listed below.

## Examples

| Folder | Program in the book | Sample input |
| --- | --- | --- |
| [Examples/Program6_1_ForLoop](Examples/Program6_1_ForLoop) | Program 6.1: The for loop | |
| [Examples/Program6_2_MultiplicationTable](Examples/Program6_2_MultiplicationTable) | Program 6.2: Multiplication table | 7 |
| [Examples/Program6_3_WhileLoop](Examples/Program6_3_WhileLoop) | Program 6.3: The while loop (digits of a number) | 4821 |
| [Examples/Program6_4_DoWhileMenu](Examples/Program6_4_DoWhileMenu) | Program 6.4: do-while (a simple bank menu) | 1, 2, 500, 7, 1, 3 |
| [Examples/Program6_5_ForeachLoop](Examples/Program6_5_ForeachLoop) | Program 6.5: The foreach loop | |
| [Examples/Program6_6_BreakContinue](Examples/Program6_6_BreakContinue) | Program 6.6: break and continue | |
| [Examples/Program6_7_AskAgain](Examples/Program6_7_AskAgain) | Program 6.7: Ask again until the input is valid | abc, 150, 86 |
| [Examples/Program6_8_NestedLoops](Examples/Program6_8_NestedLoops) | Program 6.8: Nested loops (multiplication grid) | |
| [Examples/Program6_9_StarPatterns](Examples/Program6_9_StarPatterns) | Program 6.9: Star patterns | |
| [Examples/Program6_10_DryRun](Examples/Program6_10_DryRun) | Program 6.10: Dry run | |

## Mini project

| Folder | Program in the book | Sample input |
| --- | --- | --- |
| [MiniProject/Program6_11_NumberGuess](MiniProject/Program6_11_NumberGuess) | Program 6.11: Number Guessing Game | 50, abc, 25, 12, 18, 16 |

The game uses `new Random(2026)`, so the secret number is always 16 and your run matches the book. Change it to `new Random()` for a different number every game.

## Solutions

Try each question yourself before opening its solution.

| Folder | Practice question | Sample input |
| --- | --- | --- |
| [Solutions/Q06_PredictOutput](Solutions/Q06_PredictOutput) | Q6: Predict the output (squares) | |
| [Solutions/Q07_PredictOutput](Solutions/Q07_PredictOutput) | Q7: Predict the output (while loop) | |
| [Solutions/Q08_PredictOutput](Solutions/Q08_PredictOutput) | Q8: Predict the output (break and continue) | |
| [Solutions/Q09_Factorial](Solutions/Q09_Factorial) | Q9: Factorial | 5 |
| [Solutions/Q10_ReverseAndPalindrome](Solutions/Q10_ReverseAndPalindrome) | Q10: Reverse of a number and palindrome | 12321, then 4821 |
| [Solutions/Q11_PrimeCheck](Solutions/Q11_PrimeCheck) | Q11: Prime number check | 29, then 91 |
| [Solutions/Q12_Fibonacci](Solutions/Q12_Fibonacci) | Q12: Fibonacci series | 10 |
| [Solutions/Q13_FixedDeposit](Solutions/Q13_FixedDeposit) | Q13: Fixed deposit growth table | |
| [Solutions/Q14_ArmstrongNumbers](Solutions/Q14_ArmstrongNumbers) | Q14: Armstrong numbers from 1 to 999 | |

Questions 1 to 5 (short answer) are answered in the PDF.

**Running input programs in Visual Studio:** press Ctrl + F5 and type in the console window. From the command line, `dotnet run --project Chapter-06-Loops/Examples/Program6_2_MultiplicationTable` and type when prompted. If a program seems stuck in a loop, press Ctrl + C.
