using System;
using System.IO;

namespace abrirarchivo
{
    class program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Marvi\OneDrive\Escritorio\abrirarchivo\bin\Debug\net6.0\archivo.txt");
            Console.WriteLine("\t{0}", text);
            Console.ReadLine();
            Console.ReadKey();
             
        }
       
        
    }
}