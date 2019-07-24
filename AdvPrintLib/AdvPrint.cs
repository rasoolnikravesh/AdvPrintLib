using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvPrintLib
{
    public class AdvPrint
    {
        public AdvColor BackColor { get; set; }
 
        public AdvColor ForceColor { get; set; }

        public static void Print(Object Message)
        {
            Console.Write(Message);
        }
        public static void Print(Object Message, AdvColor Backcolor, AdvColor ForceColor)
        {
            BackColorCheck(Backcolor);
            ForceColorCheck(ForceColor);
            Console.Write(Message);
            Console.ResetColor();
        }
        public static void PrintLn(Object Message)
        {
            Console.WriteLine(Message);
        }
        public static void PrintLn(Object Message, AdvColor forceColor)
        {
            ForceColorCheck(forceColor);
            Console.WriteLine(Message);
            Console.ResetColor();
        }
        public static void PrintLn(Object Message, AdvColor backcolor, AdvColor forceColor)
        {
            BackColorCheck(backcolor);
            ForceColorCheck(forceColor);
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
                case AdvColor.DarkBlue:
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case AdvColor.DarkCyan:
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    break;
                case AdvColor.DarkGray:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case AdvColor.DarkGreen:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case AdvColor.DarkMagenta:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case AdvColor.DarkRed:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case AdvColor.DarkYellow:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
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
                case AdvColor.DarkBlue:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case AdvColor.DarkCyan:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case AdvColor.DarkGray:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case AdvColor.DarkGreen:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case AdvColor.DarkMagenta:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case AdvColor.DarkRed:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case AdvColor.DarkYellow:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;


            }
        }
    }
}
    
    
