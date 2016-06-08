using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class IdCardFactory : AbstractFactory
    {
        public List<string> Owners = new List<string>();

        protected override AbstractProduct CreateProduct(string owner)
        {
            return new IdCard(owner);
        }

        protected override void RegisterProduct(AbstractProduct product)
        {
            this.Owners.Add(((IdCard)product).Owner);
        }
    }
}
