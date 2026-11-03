decimal balance = 10000m;
bool running = true;

while (running)
{
    ShowMenu();
    int choice = ReadChoice();

    switch (choice)
    {
        case 1:
            ShowBalance(balance);
            break;
        case 2:
            decimal depositAmount = ReadAmount("Amount to deposit: ");
            Deposit(ref balance, depositAmount);
            break;
        case 3:
            decimal withdrawAmount = ReadAmount("Amount to withdraw: ");
            if (!TryWithdraw(ref balance, withdrawAmount))
            {
                Console.WriteLine("Insufficient balance. Withdrawal cancelled.");
            }
            break;
        case 4:
            running = false;
            break;
    }
}
Console.WriteLine("Thank you for banking with us. Jai Hind!");

void ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("===== Mini ATM =====");
    Console.WriteLine("1. Check balance");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Exit");
}

int ReadChoice()
{
    while (true)
    {
        Console.Write("Choose 1-4: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4)
        {
            return choice;
        }
        Console.WriteLine("Invalid choice. Try again.");
    }
}

decimal ReadAmount(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            return amount;
        }
        Console.WriteLine("Please type an amount greater than zero.");
    }
}

void ShowBalance(decimal current)
{
    Console.WriteLine($"Current balance: Rs. {current:F2}");
}

void Deposit(ref decimal current, decimal amount)
{
    current += amount;
    Console.WriteLine($"Deposited Rs. {amount:F2}. New balance: Rs. {current:F2}");
}

bool TryWithdraw(ref decimal current, decimal amount)
{
    if (amount > current)
    {
        return false;
    }
    current -= amount;
    Console.WriteLine($"Withdrew Rs. {amount:F2}. New balance: Rs. {current:F2}");
    return true;
}
