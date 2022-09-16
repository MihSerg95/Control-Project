string[] text1 = new string[4] {"hello", "2", "world", ":-)"};
string[] text2 = new string[text1.Length];

void SecondText(string[] text1, string[] text2)
{
    int count = 0;
    for (int i = 0; i < text1.Length; i++)
    {
        if(text1[i].Length <= 3)
        {
            text2[count] = text1[i];
            count++;
        }
    }
}