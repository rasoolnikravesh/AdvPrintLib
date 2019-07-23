﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvPrintLib
{
    public class AdvPrint
    {
        public static void Print(Object obj)
        {

            BackColorCheck(AdvColor.Blue);
            ForceColorCheck(AdvColor.Magenta);
            Console.Write(obj);

        }
        public static void PrintLn(Object Message, AdvColor Backcolor, AdvColor ForceColor)
        {
            BackColorCheck(Backcolor);
            ForceColorCheck(ForceColor);
            Console.WriteLine(Message);
            Console.ResetColor();
        }
        private static void BackColorCheck(AdvColor color)
        {
            switch (color)
            {
                case AdvColor.Blue:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case AdvColor.Black:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case AdvColor.Red:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case AdvColor.Yellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case AdvColor.Green:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case AdvColor.Cyan:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case AdvColor.White:
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case AdvColor.Magenta:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case AdvColor.Gray:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;

            }
        }
        private static void ForceColorCheck(AdvColor color)
        {
            switch (color)
            {
                case AdvColor.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case AdvColor.Black:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case AdvColor.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case AdvColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case AdvColor.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case AdvColor.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case AdvColor.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case AdvColor.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case AdvColor.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

            }
        }
    
    
