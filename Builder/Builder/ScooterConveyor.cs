using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    internal class ScooterConveyor : Conveyor
    {
        public ScooterConveyor() 
        {
            _product = new Product("Скутер");
        }
        public override void BuildDoors()
        {
            _product["frame"] = "Рама скутера";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "25 л.с.";
        }

        public override void BuildFrame()
        {
            _product["wheels"] = "2";
        }

        public override void BuildWheels()
        {
            _product["doors"] = "0";
        }
    }
}
