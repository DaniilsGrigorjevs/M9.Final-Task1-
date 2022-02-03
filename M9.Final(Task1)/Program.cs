using System;

namespace M9.Final_Task1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("My exception.");
            exception.HelpLink = "www.google.com";

            Exception[] exceptions = new Exception[5];
            exceptions[0] = exception;
            exceptions[1] = new DivideByZeroException();
            exceptions[2] = new IndexOutOfRangeException();
            exceptions[3] = new OverflowException("Overflow");
            exceptions[4] = new ArgumentException("Impossible to pass non-empty document to the method");

            foreach (Exception ex in exceptions)
            {
                try
                {
                    throw ex;

                }
                catch (Exception x) when (x.Equals(exception))
                {
                    Console.WriteLine(x.Message);

                }
                catch (DivideByZeroException x)
                {
                    Console.WriteLine("Impossible to devide by zero {0}", x.Message);

                }
                catch (Exception x)
                {
                    Console.WriteLine("Excemption {0}", x.Message);

                }

            }
            Console.ReadKey();
        }
    }
}
