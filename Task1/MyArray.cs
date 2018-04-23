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
            // Console.SetCursorPosition(PositionX, PositionY);
            oldX = PositionX;
            oldY = PositionY;
            newX = PositionX;
            newY = PositionY;
            switch (key)
            {
                //выход за пределы
                case ConsoleKey.RightArrow:
                    if(PositionX !=  arr.Length)
                        PositionX++;
                    newX = PositionX;
                    break;
                case ConsoleKey.LeftArrow:
                    if (PositionX != arr.Length)
                        PositionX--;
                    newX = PositionX;
                    break;
                case ConsoleKey.UpArrow:
                    PositionY--;
                    newY = PositionY;
                    break;
                case ConsoleKey.DownArrow:
                    PositionY++;
                    newY = PositionY;
                    break;
            }
            Change(oldX, oldY, newX, newY);
        }

    }
}
