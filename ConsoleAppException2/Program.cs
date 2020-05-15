using ConsoleAppException;
using System;

namespace ConsoleAppException2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Exceptions!");

            Person p = null;

            p = new Person("Per", "12345");

            try
            {
                //den kode som skal testes for exceptions skal være i try
                //p.Navn = "Martin";

                p = new Person("Per","12345");



                int a = 2;

                int b = 2;

                int c = b / a;

                Console.WriteLine("c er " +c);

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("vi er i NullReferenceException");
                Console.WriteLine("Hov du har glemt at instianier dit objekt !!" + ex.Message);
            }
            catch(MartinException ex)
            {
                Console.WriteLine("vi er  martin exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("vi er Exception");
                Console.WriteLine("Exceptions er fanget" + ex.Message);
            }
            finally
                {
                Console.WriteLine("Er i finally blokken");
            }





        }
    }
}
