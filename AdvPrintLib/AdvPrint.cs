using System;


namespace AdvPrintLib
{
    public class AdvPrint
    {
        [Obsolete]
        public AdvColor BackColor { get; set; }
        [Obsolete]
        public AdvColor ForceColor { get; set; }

        public static void Print(Object Message)
        {
            Console.Write(Message);
        }
        public static void Print(Object Message, ConsoleColor ForceColor)
        {
            ForceColorCheck(ForceColor);
            Console.Write(Message);
            Console.ResetColor();
        }
        public static void Print(Object Message, ConsoleColor Backcolor, ConsoleColor ForceColor)
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
        public static void PrintLn(Object Message, ConsoleColor forceColor)
        {
            ForceColorCheck(forceColor);
            Console.WriteLine(Message);
            Console.ResetColor();
        }
        public static void PrintLn(Object Message, ConsoleColor backcolor, ConsoleColor forceColor)
        {
            BackColorCheck(backcolor);
            ForceColorCheck(forceColor);
            Console.WriteLine(Message);
            Console.ResetColor();
        }
        private static void BackColorCheck(ConsoleColor color)
        {
            Console.BackgroundColor = color;

        }
        private static void ForceColorCheck(ConsoleColor color)
        {
            Console.ForegroundColor = color;


        }
    }
}

    
    
