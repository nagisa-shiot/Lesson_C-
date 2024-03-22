string GetLettersFromsString (string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if(char.IsAsciiLetter(e)==true)
        {
            letters= letters + e;
        }
    }
    return letters;
}  
string str = Console.ReadLine();
string result = GetLettersFromsString(str);
System.Console.WriteLine(result);