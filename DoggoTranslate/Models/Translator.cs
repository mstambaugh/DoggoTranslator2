using System;
using System.Collections.Generic;

namespace Doggo.Models
{
    public class Translator 
    {
        
    private static Dictionary <string, string> DoggoWords = new Dictionary <string, string>() { {"dog", "doggo"}, {"dogs", "doggos"}, {"puppy", "pupper"}, {"puppies", "puppers"}, {"cat", "cade"},{"cats", "cades"}, {"human", "hooman"}, {"human", "hoomans"}, {"person", "hooman"}, {"people", "hoomans"} };
    

        public static bool IsValidString(string inputString)
        {
            bool result = true;

            if (inputString.Length < 3)
            {
                result = false;
            }
            return result;
        }
        public static string UseDictionary(string inputString)
        {
            string result = " ";
            return result;
        }
    }
}