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

        public static bool operator ==(RoomId roomId1, RoomId roomId2)
        {
            if (roomId1 is null && roomId2 is null)
            {

                return true;
            }

            return !(roomId1 is null) && roomId1.Equals(roomId2);
        }

        public static bool operator != (RoomId roomId1, RoomId roomId2)
        {
            return !(roomId1 == roomId2);
        }
    }
}
