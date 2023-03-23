﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    internal class MotoConveyor : Conveyor
    {
        public MotoConveyor()
        {
            _product = new Product("Мотоцикл");
        }
        public override void BuildDoors()
        {
            _product["frame"] = "Рама мотоцикла";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "70 л.с.";
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
