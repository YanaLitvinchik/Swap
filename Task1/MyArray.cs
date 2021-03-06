﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyArray
    {
        int[,] arr = new int[2,2];
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
            Console.Clear();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.SetCursorPosition(PositionX, PositionY);

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
            if (arr[posX, posY] > 9)
                arr[posX, posY] = 9;
        }
        public void Swap(ConsoleKey key)
        {
            int oldX, oldY;
            int newX, newY;
            
            oldX = PositionX;
            oldY = PositionY;
            newX = PositionX;
            newY = PositionY;
            switch (key)
            {               
                case ConsoleKey.RightArrow:
                    if(PositionX != arr.GetLength(0)-1)
                        PositionX++;                   
                    newX = PositionX;
                    break;
                case ConsoleKey.LeftArrow:
                    if (PositionX != 0 )
                        PositionX--;                   
                    newX = PositionX;
                    break;
                case ConsoleKey.UpArrow:
                    if (PositionY != 0)
                        PositionY--;
                    newY = PositionY;
                    break;
                case ConsoleKey.DownArrow:
                    if (PositionY != arr.GetLength(1) - 1)
                        PositionY++;
                    newY = PositionY;
                    break;
            }
            Change(oldY, oldX, newY, newX);
           
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
            Print();
              
            } while (key != ConsoleKey.Enter);
        }

    }
}
