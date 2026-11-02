// Program 6.4: do-while (a simple bank menu)

decimal balance = 1000m;
int choice;

do
{
    Console.WriteLine();
    Console.WriteLine("1. Check balance");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");
    int.TryParse(Console.ReadLine(), out choice);

    switch (choice)
    {
        case 1:
            Console.WriteLine($"Balance: Rs {balance}");
            break;
        case 2:
            Console.Write("Amount to deposit: ");
            decimal.TryParse(Console.ReadLine(), out decimal amount);
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited Rs {amount}. New balance: Rs {balance}");
            }
            else
            {
                Console.WriteLine("Amount must be more than zero.");
            }
            break;
        case 3:
            Console.WriteLine("Thank you. Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid choice. Try again.");
            break;
    }
} while (choice != 3);
