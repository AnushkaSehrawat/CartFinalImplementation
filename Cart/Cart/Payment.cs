using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class Payment
    {
        public Ipayment DeterminePaymentMode(string paymentType)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == paymentType);
            return (Ipayment)Activator.CreateInstance(productType);
        }
    }
}
