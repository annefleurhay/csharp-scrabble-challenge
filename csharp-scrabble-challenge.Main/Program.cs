// See https://aka.ms/new-console-template for more information
using csharp_scrabble_challenge.Main;

//Console.WriteLine("Hello, World!");

//Scrabble test = new Scrabble("street");
//int result = test.score();
string word = "street";
char[] chars = word.ToCharArray();

Dictionary<char, int> dictionary = new Dictionary<char, int>();
dictionary.Add('s', 5);
dictionary.Add('w', 7);



//initiate new scrabble
Scrabble lotus = new Scrabble("lotus"); 


foreach (char c in chars)
{
    Console.WriteLine(c);
}


