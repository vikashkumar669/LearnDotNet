string word = "RADAR";
bool isPalindrome = true;
int left = 0;
int right = word.Length - 1;

while (left < right)
{
    if (word[left] != word[right])
    {
        isPalindrome = false;
        break;
    }
    left++;
    right--;
}

Console.WriteLine($"{word} palindrome? {isPalindrome}");
