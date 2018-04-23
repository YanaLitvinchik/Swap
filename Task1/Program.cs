using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    
    class Program
    {
        
        static void Main(string[] args)
        {            
            int current = arr[0, 0];
            int position_y = 0;
            int position_x = 0;
            ConsoleKey key;
            key = Console.ReadKey().Key;
            do
            {

                Console.SetCursorPosition(position_x, position_y);
                switch (key)
                {
                    case ConsoleKey.RightArrow:

                        if (arr[position_x, position_y] > arr[position_x + 1, position_y])
                            arr[position_x, position_y]--;
                        else if (arr[position_x, position_y] < arr[position_x + 1, position_y])
                            arr[position_x, position_y]++;

                        var tmp = arr[position_x, position_y];
                        arr[position_x, position_y] = arr[position_x + 1, position_y];
                        arr[position_x + 1, position_y] = tmp;
                        position_x++;
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(arr.Length, 0);
                        position_x--;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(0, arr.Length);
                        Console.CursorTop = position_y--;


                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(0, arr.Length);
                        Console.CursorTop = position_y++;

                        break;

                }

            } while (key != ConsoleKey.Enter);
        }
    }
}

