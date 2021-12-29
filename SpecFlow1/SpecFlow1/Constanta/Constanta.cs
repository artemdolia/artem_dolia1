using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowTask3.TestRun;

namespace SpecFlow1.Constant
{
    public class Constanta:SetUp
    {
        public const string successMessage = "Product successfully added to your shopping cart";
        public const string priceOfDress = "$30.98";
        public const string paramsOfBlouse = "Color : White, Size : L";
        public const string paramsOfDress = "Color : Orange, Size : M";
        public const string nameOfDress = "Printed Summer Dress";
        public const string successSendMessage = "Your e-mail has been sent successfully";

        public object Assert { get; internal set; }
    }
}
