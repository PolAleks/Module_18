using Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Автомобильный завод
    /// </summary>
    class CarPlant
    {
        /// <summary>
        /// Запуск процесса постройки
        /// </summary>
        public void Construct(Conveyor conveyor)
        {
            conveyor.BuildFrame();
            conveyor.BuildEngine();
            conveyor.BuildWheels();
            conveyor.BuildDoors();
        }
    }
}
