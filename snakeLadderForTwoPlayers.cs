/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    internal class snakeLadderForTwoPayers
    {
        public static void Main(string[] args)
        {
            int A_previous_pos = 0;
            int B_previous_pos = 0;
            int end_pos = 100;
            int A_current_pos = 0;
            int B_current_pos = 0;

            int[] snake_pos = new int[5] { 5, 10, 51, 30, 72 };
            int[] ladder_pos = new int[3] { 3, 21 ,34};
            for(int i = 1;i<=1000;i++)
            {
                if(i%2==0)
                {
                    //Console.WriteLine("It is A player turn:");
                    if (A_current_pos == end_pos)
                    {
                        Console.WriteLine("A player won the game");
                        break;
                    }
                    else if (A_current_pos < end_pos)
                    {
                        Random ran = new Random();
                        int num = ran.Next(1, 7);
                        Console.WriteLine("A rolled dice number: " + num);
                        A_current_pos += num;

                        if (snake_pos.Contains(A_current_pos))
                        {

                            A_current_pos = (A_current_pos - (num + 5));  //num+5 is the snake size
                            if (A_current_pos < 0)
                            {
                                A_current_pos = 0;
                            }

                            Console.WriteLine("After getting snake Current position: " + A_current_pos);
                        }
                        else if (ladder_pos.Contains(A_current_pos))
                        {

                            A_current_pos = (A_current_pos + (num + 15));  //num+15 is the ladder size
                            Console.WriteLine("After getting ladder current position: " + A_current_pos);
                        }

                        else
                        {

                            A_current_pos = A_current_pos;
                            Console.WriteLine("current position: " + A_current_pos);
                        }
                        A_previous_pos = A_current_pos;

                    }
                    else if (A_current_pos > 100)
                    {

                        Random ran = new Random();
                        int num = ran.Next(1, 7);
                        Console.WriteLine("rolled dice number: " + num);
                        A_current_pos = A_previous_pos;
                    }

                }

                else if(i%2==1)
                {
                    //Console.WriteLine("It is B player turn:");
                    if (B_current_pos == end_pos)
                    {
                        Console.WriteLine("B player won the game");
                        break;
                    }
                    else if (B_current_pos < end_pos)
                    {
                        Random ran = new Random();
                        int num = ran.Next(1, 7);
                        Console.WriteLine(" B rolled dice number: " + num);
                        B_current_pos += num;

                        if (snake_pos.Contains(B_current_pos))
                        {

                            B_current_pos = (B_current_pos - (num + 5));  //num+5 is the snake size
                            if (B_current_pos < 0)
                            {
                                B_current_pos = 0;
                            }

                            Console.WriteLine("after getting snake Current position: " + B_current_pos);
                        }
                        else if (ladder_pos.Contains(B_current_pos))
                        {

                            B_current_pos = (B_current_pos + (num + 15));  //num+15 is the ladder size
                            Console.WriteLine("current position after getting ladder: " + B_current_pos);
                        }

                        else
                        {

                            B_current_pos = B_current_pos;
                            Console.WriteLine("current position: " + B_current_pos);
                        }
                        B_previous_pos = B_current_pos;

                    }
                    else if (B_current_pos > 100)
                    {

                        Random ran = new Random();
                        int num = ran.Next(1, 7);
                        Console.WriteLine("rolled dice number: " + num);
                        B_current_pos = B_previous_pos;
                    }

                }
                else if(i>500)
                {
                    Console.WriteLine("chances are closed no one win the game");
                    break;

                }
            }

            
        }
        
    }
}
*/