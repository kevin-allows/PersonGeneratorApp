using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonGeneratorApp
{
    public class Car
    {
        private string model;
        private int horsePower, maximumSpeed;

        public Car(string model, int horsePower, int maximumSpeed)
        {
            this.model = model;
            this.horsePower = horsePower;
            this.maximumSpeed = maximumSpeed;
        }

        public string getModel()
        {
            return model;
        }

        public int getHorsePower()
        {
            return horsePower;
        }

        public int getMaximumSpeed()
        {
            return maximumSpeed;
        }
    }
}
