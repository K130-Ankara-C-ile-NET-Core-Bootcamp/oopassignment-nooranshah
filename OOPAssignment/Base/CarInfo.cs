using OOPAssignment.Struct;
using System;

namespace OOPAssignment.Base
{
    public class CarInfo
    {
        public Guid CarId { get; set; }
        public Coordinates Coordinates { get; set; }
        public CarInfo(Guid carId, Coordinates coordinates)
        {
            CarId = carId;
            Coordinates = coordinates;
        }           
    }
}
