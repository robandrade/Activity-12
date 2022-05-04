using System;

StreamWriter outputFile;
outputFile = File.CreateText("Activity12.txt");

outputFile.WriteLine("Don't be late, teatime will not wait!");

outputFile.Close();

string str = File.ReadAllText("Activity12.txt");

int word = 0;
int last = 0;

while (last < str.Length -1)
{
    if ((str[last] == ',' || str[last] == ' ' || str[last] == '!' || str[last] == '\t' || str[last] == '\n' || str[last] == '.' || str[last] == '?') && (str[last-1] == 't' || str[last-1] == 'e'))
    {
        word++;
    }
    last++;
}

Console.WriteLine("There are {0} words ending in t or e", word);
 