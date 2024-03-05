using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleProject
{
    internal class SnakeLadder
    {

        /*static void Main(string[] args)
            
        {
            int previous_pos = 0;
            int end_pos = 100;
            int current_pos = 0;
            //int new_current_pos = 0;
            int[] snake_pos = new int[5] { 5, 10, 51, 30, 72 };
            int[] ladder_pos = new int[5] { 3, 21, 34, 89, 93 };
            //Random ran = new Random();
            //int num = ran.Next(1, 7);
            //Console.WriteLine(num);
            while (current_pos <= end_pos)
            {

                if (current_pos == end_pos)
                {
                    Console.WriteLine("the player won the game");
                    break;
                }
                else if (current_pos < end_pos)
                {
                    Random ran = new Random();
                    int num = ran.Next(1, 7);
                    Console.WriteLine("rolled dice number: " + num);
                    current_pos += num;

                    if (snake_pos.Contains(current_pos))
                    {

                        current_pos = (current_pos - (num + 5));  //num+5 is the snake size
                        if (current_pos < 0)
                        {
                            current_pos = 0;
                        }

                        Console.WriteLine("Current position: " + current_pos);
                    }
                    else if (ladder_pos.Contains(current_pos))
                    {

                        current_pos = (current_pos + (num + 15));  //num+15 is the ladder size
                        Console.WriteLine("current position: " + current_pos);
                    }

                    else
                    {

                        current_pos = current_pos;
                        Console.WriteLine("current position: " + current_pos);
                    }
                    previous_pos = current_pos;

                }
                else if (current_pos > 100)
                {

                    Random ran = new Random();
                    int num = ran.Next(1, 7);
                    Console.WriteLine("rolled dice number: " + num);
                    current_pos = previous_pos;
                }

            }
        }*/
    }
}
