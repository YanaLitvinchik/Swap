using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyArray
    {
        int[,] arr = new int[5, 5];
        private int PositionX { get; set; }
        private int PositionY { get; set; }
        public int Current { get; set; }


        public void CreateArray()
        {
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(0, 10);
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }

        }
        public void Change(int posX, int posY, int newX, int newY)
        {
            if (arr[posX, posY] > arr[newX, newY])
                arr[posX, posY]--;
            else if (arr[posX, posY] < arr[newX, newY])
                arr[newX, newY]++;
            var tmp = arr[posX, posY];
            arr[posX, posY] = arr[newX, newY];
            arr[newX, newY] = tmp;
        }
        public void Swap(ConsoleKey key)
        {
            int oldX, oldY;
            int newX, newY;
            
            oldX = PositionX;
            oldY = PositionY;
            newX = PositionX;
            newY = PositionY;
            Console.SetCursorPosition(PositionX, PositionY);
            switch (key)
            {               
                case ConsoleKey.RightArrow:
                    if(PositionX != arr.GetLength(0)-1)
                        PositionX++;
                    else
                        PositionX--;
                    newX = PositionX;
                    break;
                case ConsoleKey.LeftArrow:
                    if (PositionX != 0 )
                        PositionX--;
                    else
                        PositionX++;
                    newX = PositionX;
                    break;
                case ConsoleKey.UpArrow:
                    if (PositionY <= 0)
                        PositionY++;
                    else
                        PositionY--;
                    newY = PositionY;
                    break;
                case ConsoleKey.DownArrow:
                    if (PositionY != arr.GetLength(1) - 1)
                        PositionY++;
                    else
                        PositionY--;
                    newY = PositionY;
                    break;
            }
            Change(oldX, oldY, newX, newY);
           
        }
        public void Engine()
        {

            CreateArray();
            ConsoleKey key;
            Print();
            do
            {
                key = Console.ReadKey().Key;
                Swap(key);
              
            } while (key != ConsoleKey.Enter);
            Print();
        }

    }
}
