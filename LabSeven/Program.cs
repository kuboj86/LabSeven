using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace LabSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] playerArray = { @"Carson Wentz", "Alshon Jeffrey", "Zach Ertz", "LeGarrette Blount", "Lane Johnson", "Brandon Graham", "Fletcher Cox", "Jake Elliott", "Jordan Hicks", "Ronald Darby", "Nelson Agholar" };
            int index = GetPlayerIndex(playerArray.Length);

            string playerName = playerArray[index];

            string[] positionArray = { "Quarterback", "Wide Receiver", "Tightend", "Runningback", "Offensive Tackle", "Defensive End", "Defensive Tackle", "Kicker", "Linebacker", "Cornerback,", "Wide Receiver" };

            string[] collegeArray = { "North Dakota State", "South Carolina", "Stanford", "Oregon", "Oklahoma", "Michigan", "Mississippi State", "Memphis", "Texas", "FSU", "USC" };

            string responseType = GetResponseType(playerName);
            if (responseType =="college")
            {
                Console.WriteLine($"{playerName} went to {collegeArray[index]}");
            }
            else if (responseType == "position")
            {
                Console.WriteLine($"{playerName} plays {positionArray[index]}");
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
            Console.ReadKey();
        }
        static int GetPlayerIndex(int playerCount)
        {
            int number;
            while (true)
            {
                Console.Write($"Which player would you like to know about?  (Enter a number 1-{playerCount})\t");
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    if (number > 0 && number <= playerCount)
                    {
                       break;
                    }
                    else
                    {
                        Console.WriteLine($"I'm sorry but {input} is out of range.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number!");
                }
            }
            return number - 1;
        }

        static string GetResponseType(string playername)
        {
            Console.WriteLine($"What do you want to know about {playername}?    ('college' or 'position'):");
            string type = Console.ReadLine();
            return type.ToLower();

        }
    }
}
