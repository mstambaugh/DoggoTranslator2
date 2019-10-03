using System;
using System.Collections.Generic;

namespace Doggo.Models
{
    public class Translator 
    {
        
    private static Dictionary <string, string> DoggoWords = new Dictionary <string, string>() { {"dog", "doggo"}, {"dogs", "doggos"}, {"puppy", "pupper"}, {"puppies", "puppers"}, {"cat", "cade"},{"cats", "cades"}, {"human", "hooman"}, {"humans", "hoomans"}, {"person", "hooman"}, {"people", "hoomans"} };
    

        public static bool IsValidString(string inputString)
        {
            bool result = true;

            if (inputString.Length < 3)
            {
                result = false;
            }
            return result;
        }
        public static string DoggoTranslation(string inputString)
        {
            string DoggoWordsReturn = ""; 
            string[] words = inputString.Split(' ');

            foreach (string word in words)
            {
                string oneWord = UseDictionary(word);
                DoggoWordsReturn += $"{oneWord} ";
            }

            return DoggoWordsReturn;
                            
            // input string to array split at spaces
            // forEach strings in array with UseDictionary 
            // return DoggoWordsReturn strings in array separated by " " 

        }
        public static string UseDictionary(string inputString)
        {
            string result = inputString;
            if (DoggoWords.ContainsKey(inputString))
            {
                result = DoggoWords[inputString]; 
                //get value from dictionary based on key
                //store value in result string
            }
            
            return result;
        }
        public static string RemoveEAfterV(string inputString)
        {
            string NoEWord = inputString;
            if (inputString[inputString.Length - 1] == 'e' && (inputString[inputString.Length - 2] == 'v'))
            {
                NoEWord = inputString.Substring(0, inputString.Length - 1); 
            }
            return NoEWord; 
        }
        public static string AddLastWord(string inputString)
        {
            string[] lastWord = {". Karen pls.", ". blep", ". doin me a real significant bamboozle.", ". mlem", ". boop", ". chimken nuggers immediate.", ". heck Sharon", ". bork" }; 
            Random random = new Random();
            int index = random.Next(0, lastWord.Length);
            return inputString + lastWord[index];
        }

    }
}