using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Katas
{
    class Challenges
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"The ball bounced {bouncingBall(3,0.66,1.5)} times");
            Console.WriteLine($"The ball bounced {bouncingBall(30, 0.66, 1.5)} times");
            //Console.WriteLine($"The ball bounced {bouncingBall(3, 1, 1.5)} times");
            Console.ReadLine();
        }

        #region SpinWords Kata
        /*Write a function that takes in a string of one or more words, and returns the same string, 
         * but with all words that have five or more letters reversed (Just like the name of this Kata). 
         * Strings passed in will consist of only letters and spaces. Spaces will be included only when 
         * more than one word is present.*/

        public static string SpinWords(string sentence)
        {
            var arrayResult = sentence.Split(' ');
            var resultingString = "";

            for (int i = 0; i < arrayResult.Length; i++)
            {

                if (arrayResult[i].Length >= 5)
                {
                    var tempword = arrayResult[i];
                    arrayResult[i] = ReverseString(tempword);
                }

            }

            foreach (var item in arrayResult)
            {
                resultingString += item + " ";
            }

            return resultingString.Trim();
        }

        public static string ReverseString(string str)
        {

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }
        #endregion

        #region Who Likes it Kata
        /*You probably know the "like" system from Facebook and other pages. People can "like" blog posts, 
         * pictures or other items. We want to create the text that should be displayed next to such an item.

        Implement the function which takes an array containing the names of people that like an item. It must 
        return the display text as shown in the examples:
         */

        public static string Likes(string[] name)
        {
            
            return !name.Any() ? "No one likes this" : 
                    name.Length == 1 ? $"{name[0]} like this" :
                    name.Length == 2 ? $"{name[0]} and {name[1]} like this" :
                    name.Length == 3 ? $"{name[0]}, {name[1]} and {name[2]} like this" :
                    $"{name[0]}, {name[1]} and 2 others like this";
        }
        #endregion

        #region Bouncing ball kata

        /*A child is playing with a ball on the nth floor of a tall building. The height of this floor above ground level, h, is known.

He drops the ball out of the window. The ball bounces (for example), to two-thirds of its height (a bounce of 0.66).

His mother looks out of a window 1.5 meters from the ground.

How many times will the mother see the ball pass in front of her window (including when it's falling and bouncing)?

Three conditions must be met for a valid experiment:
Float parameter "h" in meters must be greater than 0
Float parameter "bounce" must be greater than 0 and less than 1
Float parameter "window" must be less than h.
If all three conditions above are fulfilled, return a positive integer, otherwise return -1.

Note:
The ball can only be seen if the height of the rebounding ball is strictly greater than the window parameter.*/
        public static int bouncingBall(double h, double b, double w)
        {
            // your code
            if (h > 0 && (b > 0 && b < 1) && (w < h))
            {

                int result = 1;

                do
                {

                    h -= h * 0.66;
                    result++;

                } while (h > w);

                return result;
            }
            else
            {

                return -1;

            }
        }
        #endregion
    }
}