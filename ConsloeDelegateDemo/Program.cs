using System;

namespace ConsloeDelegateDemo
{
    class Program
    {
        //step1 : delcare a delegate
        private delegate void delPrintHello(string Msg);

        private delegate void delMulticastdemo(string Msg);

        static void Main(string[] args)
        {
            #region Delegate Basics
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
            // printHello("Hello world called from Anonymous method!"); 
            #endregion

            #region Multicast Delegates
            delMulticastdemo multicastdemo1 = ClassA.MethodA;
            delMulticastdemo multicastdemo2 = ClassB.MethodB;

            delMulticastdemo multicastdemoResult = multicastdemo1 + multicastdemo2;

            //  multicastdemoResult("msg from multicast delegate");

            delMulticastdemo delMulticastdemoLamda = (string Msg) => {
                Console.WriteLine(Msg);
            };
            multicastdemoResult += delMulticastdemoLamda;

            multicastdemoResult -= multicastdemo2;
            multicastdemoResult("removed method B");
            #endregion


            Console.ReadLine();
        }

        class ClassA
        {
            internal static void MethodA(string message)
            {
                Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
            }
        }

        class ClassB
        {
            internal static void MethodB(string message)
            {
                Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
            }
        }


        public static void PrintMessage(string Msg)
        {
            Console.WriteLine(Msg);
        }
    }
}
