using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class IdCard : AbstractProduct
    {
        public string Owner { get; private set; }

        public IdCard(string owner)
        {
            this.Owner = owner;
        }

        public override void Use()
        {
            System.Console.WriteLine(this.Owner + "を使います。");
        }
    }
}
