using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    internal class CarConveyor : Conveyor
    {
        public CarConveyor() 
        {
            _product = new Product("Автомобиль");
        }
        public override void BuildDoors()
        {
            _product["frame"] = "Рама автомобиля";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "150 л.с.";
        }

        public override void BuildFrame()
        {
            _product["wheels"] = "4";
        }

        public override void BuildWheels()
        {
            _product["doors"] = "4";
        }
    }
}
