Console.WriteLine("Enter word or sentence:");


string hello = Console.ReadLine();

int stringLength = hello.Length;

Console.WriteLine("");

hello = hello.Trim(); //string trimmedstring = hello.Trim();

char firstLetter = hello[0];

Console.WriteLine($"Entered value is: {hello}");
Console.WriteLine($"first letter is: {firstLetter}");

Console.WriteLine();

hello = hello.Replace(hello[0], char.ToUpper(hello[0]));

Console.WriteLine($"Correted sentence Is:{hello}");
Console.WriteLine($"first letter is: {hello[0]}");


int wordCounter = 1;

for (int i = 0; i < hello.Length; i++)
{
    if (char.IsWhiteSpace(hello[i]))
    {
        wordCounter++;
    }
}


Console.WriteLine($"Word count in: {hello}: {wordCounter} words");

