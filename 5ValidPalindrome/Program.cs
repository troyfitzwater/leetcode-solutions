const string s1 = "A man, a plan, a canal: Panama";
const string s2 = "race a car";
const string s3 = " ";

Console.WriteLine(IsPalindrome(s1));
Console.WriteLine(IsPalindrome(s2));
Console.WriteLine(IsPalindrome(s3));

bool IsPalindrome(string s) {
    // we will need to remove non-alphanumeric characters, trim whitespace, and make lowercase
    s = s.ToLower().Trim();
    var charArray = s.ToCharArray();
    charArray = charArray.Where(char.IsLetterOrDigit).ToArray();
        
    // now, we need to check if it is a valid palindrome
    // two pointers, start and end, compare their values and move closer to the center
    var endIndex = charArray.Length - 1;

    for (var i = 0; i < charArray.Length; i++)
    {
        if (charArray[i] != charArray[endIndex])
        {
            return false;
        }

        endIndex--;
    }

    return true;
}
