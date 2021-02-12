using System;

namespace Inverse_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] world = new string [6] {"!", "d", "l", "r", "o", "W"};

       for (int i = 0; i < world.Length; i++)
       {
           Console.WriteLine (world[i]);
       }    
       
       string[] hello = new string [5] {"o", "l", "l", "e", "H"};

       for (int i = 0; i < hello.Length; i++)
       {
           Console.WriteLine (hello[i]);
       }
        }
    }
}
