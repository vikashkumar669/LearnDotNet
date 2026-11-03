# Chapter 7: Methods

Read the chapter: [Chapter-07-Methods.pdf](Chapter-07-Methods.pdf)

Your first method, parameters and arguments, return values, splitting a program into methods, pass by value and scope, optional parameters and named arguments, overloading, `ref` and `out`, expression-bodied methods and recursion.

Programs that read input wait for you to type. The sample input used in the book is listed below.

## Examples

| Folder | Program in the book | Sample input |
| --- | --- | --- |
| [Examples/Program7_1_FirstMethod](Examples/Program7_1_FirstMethod) | Program 7.1: Your first method | |
| [Examples/Program7_2_Parameters](Examples/Program7_2_Parameters) | Program 7.2: Parameters and arguments | |
| [Examples/Program7_3_ReturnValues](Examples/Program7_3_ReturnValues) | Program 7.3: Methods that return a value | |
| [Examples/Program7_4_ElectricityBill](Examples/Program7_4_ElectricityBill) | Program 7.4: Electricity bill with methods | abc, 250 |
| [Examples/Program7_5_PassByValue](Examples/Program7_5_PassByValue) | Program 7.5: Parameters are copies | |
| [Examples/Program7_6_OptionalParameters](Examples/Program7_6_OptionalParameters) | Program 7.6: Optional parameters and named arguments | |
| [Examples/Program7_7_Overloading](Examples/Program7_7_Overloading) | Program 7.7: Method overloading | |
| [Examples/Program7_8_RefAndOut](Examples/Program7_8_RefAndOut) | Program 7.8: ref and out | |
| [Examples/Program7_9_ShortMethods](Examples/Program7_9_ShortMethods) | Program 7.9: Short methods and methods that call methods | |
| [Examples/Program7_10_Recursion](Examples/Program7_10_Recursion) | Program 7.10: Recursion | |
| [Examples/Program7_11_DryRun](Examples/Program7_11_DryRun) | Program 7.11: Dry run | |

## Mini project

| Folder | Program in the book | Sample input |
| --- | --- | --- |
| [MiniProject/Program7_12_AtmMenu](MiniProject/Program7_12_AtmMenu) | Program 7.12: Mini ATM | 1, 2, abc, 2500, 3, 20000, 3, 4000, 9, 1, 4 |

## Solutions

Try each question yourself before opening its solution.

| Folder | Practice question | Sample input |
| --- | --- | --- |
| [Solutions/Q06_PredictOutput](Solutions/Q06_PredictOutput) | Q6: Predict the output (a void method with a loop) | |
| [Solutions/Q07_PredictOutput](Solutions/Q07_PredictOutput) | Q7: Predict the output (pass by value) | |
| [Solutions/Q08_PredictOutput](Solutions/Q08_PredictOutput) | Q8: Predict the output (recursion) | |
| [Solutions/Q09_IsPrime](Solutions/Q09_IsPrime) | Q9: IsPrime method, primes up to a limit | 30 |
| [Solutions/Q10_Factorial](Solutions/Q10_Factorial) | Q10: Factorial with a loop and with recursion | 10 |
| [Solutions/Q11_TemperatureOverloads](Solutions/Q11_TemperatureOverloads) | Q11: Overloaded temperature conversion | |
| [Solutions/Q12_SwapWithRef](Solutions/Q12_SwapWithRef) | Q12: Swap two numbers with ref | 15, 40 |
| [Solutions/Q13_MarksAndGrade](Solutions/Q13_MarksAndGrade) | Q13: Marks, percentage and grade with methods | 88, 101, 92, 79 |
| [Solutions/Q14_GcdLcm](Solutions/Q14_GcdLcm) | Q14: GCD (recursive, Euclid) and LCM | 48, 36 |

Questions 1 to 5 (short answer) are answered in the PDF.

**Where the methods are.** In these top-level programs each method is written below the statements that call it, in the same `Program.cs`. The overloaded methods of Program 7.7 and Q11 are in a `static class` at the bottom of `Program.cs`, because top-level methods cannot share a name (section 7.8 of the chapter).

**Running input programs in Visual Studio:** press Ctrl + F5 and type in the console window. From the command line, `dotnet run --project Chapter-07-Methods/MiniProject/Program7_12_AtmMenu` and type when prompted.
