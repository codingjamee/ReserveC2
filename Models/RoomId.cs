using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom2.Models
{
    public class RoomId
    {
        public int FloorNumber
        {
            get;
        }
        public int RoomNumber
        {
            get;
        }
        public RoomId(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{FloorNumber} {RoomNumber}";
        }

        public override bool Equals(object obj)
        {
            return obj is RoomId roomId &&
                FloorNumber == roomId.FloorNumber &&
                RoomNumber == roomId.RoomNumber;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17; //소수
                hash = hash * 23 + FloorNumber.GetHashCode(); //소수(17) * 소수(23)
                hash = hash * 23 + RoomNumber.GetHashCode();
                return hash;
            }
        }
    }
}
