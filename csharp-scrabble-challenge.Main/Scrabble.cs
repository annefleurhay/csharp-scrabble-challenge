using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class Scrabble
    {
        private string _word;
        public Scrabble(string word)
        {
            _word = word;
            
            //Hier wordt een woord in gedaan , hier komt dus informatie in 
            //TODO: do something with the word variable
            //some kind of dictionary that stores the letters
            //some kind of loop that runs through the word and look for the points given to that letter
            //uppercase or lowercase everything to make sure it works
            //this field needs to contain a private
            //move up the dicionary als private so it is being called in the constructor rather than the getletterscore method

        }
        public int getLetterScore(Dictionary<char, int> dictionary, char key)
        { 

            foreach (var item in dictionary)
            {
                if (item.Key == key)
                {
                    return item.Value;
                }
            }

            return 0;
            //zoek naar efficiente manieren om door de dictornary heen te gaan 
            //dictionary.trygetvalue();

        }

        public int score()
        {
            //TODO: score calculation code goes
            //denk na over char en char arrays
            //Dictrionary die de letters en hun waarde daarvan opslaat.
            Dictionary<char, int> alphabet = new Dictionary<char, int>();
            alphabet.Add('A', 1);
            alphabet.Add('E', 1);
            alphabet.Add('I', 1);
            alphabet.Add('O', 1);
            alphabet.Add('U', 1);
            alphabet.Add('L', 1);
            alphabet.Add('N', 1);
            alphabet.Add('R', 1);
            alphabet.Add('S', 1);
            alphabet.Add('T', 1);
            alphabet.Add('D', 2);
            alphabet.Add('G', 2);
            alphabet.Add('B', 3);
            alphabet.Add('C', 3);
            alphabet.Add('M', 3);
            alphabet.Add('P', 3);
            alphabet.Add('F', 4);
            alphabet.Add('H', 4);
            alphabet.Add('V', 4);
            alphabet.Add('W', 4);
            alphabet.Add('Y', 4);
            alphabet.Add('K', 5);
            alphabet.Add('J', 8);
            alphabet.Add('X', 8);
            alphabet.Add('Q', 10);
            alphabet.Add('Z', 10);

            int finalScore = 0;

            char[] chars = _word.ToCharArray();
            foreach (char c in chars)
            {   
                //finalScore+=getLetterScore(alphabet, Char.ToUpper(c));
                //Console.WriteLine(c);
                finalScore = finalScore + getLetterScore(alphabet, Char.ToUpper(c));
            }

            //alfabet private member maken 

            return finalScore;
            
            
             //TODO: Remove this line when the code has been written
        }
    }
}
