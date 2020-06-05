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
            //delMulticastdemo multicastdemo1 = ClassA.MethodA;
            //delMulticastdemo multicastdemo2 = ClassB.MethodB;

            //delMulticastdemo multicastdemoResult = multicastdemo1 + multicastdemo2;

            ////  multicastdemoResult("msg from multicast delegate");

            //delMulticastdemo delMulticastdemoLamda = (string Msg) => {
            //    Console.WriteLine(Msg);
            //};
            //multicastdemoResult += delMulticastdemoLamda;

            //multicastdemoResult -= multicastdemo2;
            //multicastdemoResult("removed method B");
            #endregion


            #region Action Delegates
            //Action<string> actionPrintDelegate = PrintMessage;

            //actionPrintDelegate("Message print from action delegate");

            #endregion

            #region Func Delegates 
            //Func<int, int, int> funcAddDelegate = AddTwoNumbers;

            //int result = funcAddDelegate(10, 20);
            //Console.WriteLine($"Sum of Func delegate result is {result}");
            #endregion

            #region Predicate Delgates
            Predicate<string> predicateCheckIsupeer = IsUpperCase;

            bool result = predicateCheckIsupeer("lowercase string");
            Console.WriteLine($"returned type is boolen and value is {result}");

            #endregion

            Console.ReadLine();
        }

        private static bool IsUpperCase(string value)
        {
            return value.Equals(value.ToUpper());
        }

        private static int AddTwoNumbers(int x, int y)
        {
            return x + y;
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
