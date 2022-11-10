using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Incrementer
{
    internal class IncresmentString
    {
        public static string zadanie(string userInput)
        {
            List<int> list = new List<int>();

            foreach (var character in userInput)
            {
                if(int.TryParse(character.ToString(), out int result))
                {
                    list.Add(result);
                }
                else if(list.Count > 0)
                    list.Clear();
            }

            string shortString="";
            int number=0;


            if (list.Count!=0)
            {
                shortString = new string(userInput.ToArray(), 0, userInput.Length - list.Count);
                string numbers = string.Join("", list);
                number= int.Parse(numbers);
                number++;
            }


            if (list.Count == 0)
                return userInput + "1";
            else
                return shortString + number.ToString();
        }
    }
}
