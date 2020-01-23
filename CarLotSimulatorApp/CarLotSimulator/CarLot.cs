using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {
        public List<Car> Cars { get; set; } = new List<Car>();

        public CarLot()
        {
            
        }
        public CarLot(List<Car> input)
        {
            Cars = input;
        }
    }
}
