using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonGeneratorApp
{
    public class Address
    {
        public string Street { get; set; } //auto-property

        //full-property
        /*private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        */
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

    }
}
