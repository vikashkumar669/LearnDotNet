# Chapter 9: Strings

Read the chapter: [Chapter-09-Strings.pdf](Chapter-09-Strings.pdf)

String literals, escape sequences and verbatim strings, `Length` and characters, changing case and trimming, searching (`Contains`, `StartsWith`, `EndsWith`, `IndexOf`), extracting and changing (`Substring`, `Replace`, `Insert`, `Remove`, padding), `Split` and `string.Join`, comparing strings, formatting numbers, rupees and dates, validating names, mobile numbers and PIN codes, and `StringBuilder`.

Programs that read input wait for you to type. The sample input used in the book is listed below.

## Examples

| Folder | Program in the book | Sample input |
| --- | --- | --- |
| [Examples/Program9_1_FirstString](Examples/Program9_1_FirstString) | Program 9.1: First strings | |
| [Examples/Program9_2_Characters](Examples/Program9_2_Characters) | Program 9.2: Counting the characters in a sentence | |
| [Examples/Program9_3_CaseAndTrim](Examples/Program9_3_CaseAndTrim) | Program 9.3: Cleaning a name and an answer | `   rahul sharma  `, then `  YES ` |
| [Examples/Program9_4_Searching](Examples/Program9_4_Searching) | Program 9.4: Checking an email, vehicle numbers and a notice | |
| [Examples/Program9_5_ExtractAndChange](Examples/Program9_5_ExtractAndChange) | Program 9.5: Roll numbers, email parts, masking and padding | |
| [Examples/Program9_6_SplitAndJoin](Examples/Program9_6_SplitAndJoin) | Program 9.6: Reading a student record and reversing words | |
| [Examples/Program9_7_Comparing](Examples/Program9_7_Comparing) | Program 9.7: Equal, ignore case, compare and sort | jaipur |
| [Examples/Program9_8_Formatting](Examples/Program9_8_Formatting) | Program 9.8: A shop bill in rupees | |
| [Examples/Program9_9_Validation](Examples/Program9_9_Validation) | Program 9.9: Checking names, mobile numbers and PIN codes | |
| [Examples/Program9_10_StringBuilder](Examples/Program9_10_StringBuilder) | Program 9.10: += versus StringBuilder | |
| [Examples/Program9_11_DryRun](Examples/Program9_11_DryRun) | Program 9.11: Palindrome check (dry run) | |

## Mini project

| Folder | Program in the book | Sample input |
| --- | --- | --- |
| [MiniProject/Program9_12_Registration](MiniProject/Program9_12_Registration) | Program 9.12: College Registration Desk | aMAN   kumar singh; 98765-43210, then 9876543210; 056001, then 560034; aman.singh@gmail, then Aman.Singh@Gmail.com; mca, then btech; 7 |

## Solutions

Try each question yourself before opening its solution.

| Folder | Practice question | Sample input |
| --- | --- | --- |
| [Solutions/Q06_PredictOutput](Solutions/Q06_PredictOutput) | Q6: Predict the output (index, Substring, IndexOf) | |
| [Solutions/Q07_PredictOutput](Solutions/Q07_PredictOutput) | Q7: Predict the output (immutability and +) | |
| [Solutions/Q08_PredictOutput](Solutions/Q08_PredictOutput) | Q8: Predict the output (Split, Join, CompareTo) | |
| [Solutions/Q09_SentencePalindrome](Solutions/Q09_SentencePalindrome) | Q9: Sentence palindrome | Never odd or even |
| [Solutions/Q10_WordCount](Solutions/Q10_WordCount) | Q10: Word count and longest word | `  Bharat   is a land of  festivals ` |
| [Solutions/Q11_ReverseEachWord](Solutions/Q11_ReverseEachWord) | Q11: Reverse each word | Hello India 2026 |
| [Solutions/Q12_LetterFrequency](Solutions/Q12_LetterFrequency) | Q12: Letter frequency with 26 counters | Bengaluru |
| [Solutions/Q13_NormaliseMobile](Solutions/Q13_NormaliseMobile) | Q13: Normalise a mobile number (+91 / 0 prefix) | |
| [Solutions/Q14_Anagram](Solutions/Q14_Anagram) | Q14: Anagram check | Listen, then Silent |

Questions 1 to 5 (short answer) are answered in the PDF.

**Running input programs in Visual Studio:** press Ctrl + F5 and type in the console window. From the command line, `dotnet run --project Chapter-09-Strings/MiniProject/Program9_12_Registration` and type when prompted.

**Rupee sign:** Program 9.8 sets `Console.OutputEncoding` to UTF-8 so the console can print ₹. If you still see a box or `?`, change the console font to Cascadia Mono or Consolas.
