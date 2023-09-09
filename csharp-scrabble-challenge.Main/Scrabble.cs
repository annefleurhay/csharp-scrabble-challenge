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
        private Dictionary<char, int> _alphabet;
        public Scrabble(string word)
        {
            _word = word;
            _alphabet = new Dictionary<char, int>
            { 
                {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1},
                {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1},
                {'D', 2}, {'G', 2}, {'B', 3}, {'C', 3}, {'M', 3},
                {'P', 3}, {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4},
                {'Y', 4}, {'K', 5}, {'J', 8}, {'X', 8}, {'Q', 10}, {'Z', 10}
            };
            //Hier wordt een woord in gedaan , hier komt dus informatie in 
            //TODO: do something with the word variable
            //some kind of dictionary that stores the letters
            //some kind of loop that runs through the word and look for the points given to that letter
            //uppercase or lowercase everything to make sure it works
            //this field needs to contain a private
            //move up the dicionary als private so it is being called in the constructor rather than the getletterscore method

        }
        public int getLetterScore(char key)
        { 
                if (_alphabet.TryGetValue(Char.ToUpper(key), out int score))
                {

                return score;

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
            int finalScore = 0;

            char[] chars = _word.ToCharArray();
            foreach (char c in chars)
            {
                //finalScore+=getLetterScore(alphabet, Char.ToUpper(c));
                //Console.WriteLine(c);
                finalScore += getLetterScore(c);
            }

            //alfabet private member maken 

            return finalScore;
            
            
             //TODO: Remove this line when the code has been written
        }
    }
}
