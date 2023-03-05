using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Systemresource res = new Systemresource())
            {
                Console.WriteLine("A");
            }
            Console.WriteLine("B");
            Console.ReadLine();
        }
    }
}
class Systemresource : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("C");
    }
}


