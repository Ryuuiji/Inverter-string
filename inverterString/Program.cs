
Console.WriteLine("Digite uma frase");

string input = Console.ReadLine();
string reverse = "";



foreach (char item in input)
{
    reverse = item + reverse;
    
}

Console.WriteLine(reverse);


