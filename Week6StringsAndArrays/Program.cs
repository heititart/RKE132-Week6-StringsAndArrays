Console.WriteLine("Sisesta sõna või lause:");

string hello = Console.ReadLine();

int stringLength = hello.Length;

//string trimmedstring = hello.Trim();

hello = hello.Trim();

int wordCounter = 1;

for (int i = 0; i < hello.Length; i++)
{
	if (hello[i] == ' ')
	{
		wordCounter++;
	}
}


Console.WriteLine($"Word count in: {hello}: {wordCounter} words");

