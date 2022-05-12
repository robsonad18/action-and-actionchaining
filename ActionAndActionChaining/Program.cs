using System;

namespace ActionAndActionChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = () => MyFunction("Eu sou um parametro");
            Action actionTwo = MyFunction;

            action();
            actionTwo();

            Action handle;

            handle = FirstName;
            handle += SecondName;
            handle += LastName;

            handle();
        }

        static void MyFunction(string text)
            => Console.WriteLine(text);

        static void MyFunction()
            => Console.WriteLine("Sou uma sobrecarga");


        static void FirstName() 
            => Console.WriteLine("Robson");

        static void SecondName() 
            => Console.WriteLine("Lucas");

        static void LastName()
            => Console.WriteLine("Farias");


    }
}
