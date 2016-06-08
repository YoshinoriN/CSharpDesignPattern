using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new IdCardFactory();
            AbstractProduct product = factory.Create("test");
            AbstractProduct product2 = factory.Create("sss");
            product.Use();
            product2.Use();
        }
    }
}
