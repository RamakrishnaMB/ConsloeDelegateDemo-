using System;

namespace ConsloeDelegateDemo
{
    class Program
    {
        //step1 : delcare a delegate
        private delegate void delPrintHello(string Msg);
        static void Main(string[] args)
        {
            // PrintMessage("Hello World!");

            //step2 : set delegate
            //delPrintHello delPrintHello = PrintMessage;
            //Lamda expression setting 
            //delPrintHello delPrint = (string Msg) =>
            //{
            //    Console.WriteLine(Msg);
            //};

            // Anonymous method 
            delPrintHello printHello = delegate (string Msg)
            {
                Console.WriteLine(Msg);
            };

            //step3 : Inovke the delegate
            printHello("Hello world called from Anonymous method!");
            Console.ReadLine();
        }

        public static void PrintMessage(string Msg)
        {
            Console.WriteLine(Msg);
        }
    }
}
