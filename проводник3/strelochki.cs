using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проводник3
{
    internal class strelochki
    {
            public static int position = 3;
            public static int MAX, MIN;

            public strelochki(int min, int max)
            {

                MAX = max;
                MIN = min;
            }
            public int Strelka()
            {
                ConsoleKeyInfo key = Console.ReadKey();
                do
                {

                    
                    if (key.Key == ConsoleKey.UpArrow)
                    {

                        position--;

                        if (position < MIN)
                        {
                            position = MAX;
                        }
                        else if (position > MAX + 1)
                        {
                            position = MIN + 1;
                        }


                        for (int v = 99; v >= position; v--)
                        {
                            Console.SetCursorPosition(0, v);
                            Console.WriteLine("  ");
                        }

                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("->");
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {

                        position++;

                        if (position <= MIN + 1)
                        {
                            position = MAX;
                        }
                        else if (position > MAX + 1)
                        {
                            position = MIN;
                        }

                        for (int  z = 0; z <= position; z++)
                        {
                            Console.SetCursorPosition(0, z);
                            Console.WriteLine("->");

                        }

                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("->");

                    }

                    else if (key.Key == ConsoleKey.Escape)
                    {
                        return -1;
                    }
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                } while (key.Key == ConsoleKey.Enter);
                Console.Clear();
                return position;

            }
        }
    }


