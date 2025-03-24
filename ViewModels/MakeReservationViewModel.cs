using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom2.ViewModels
{
    public class MakeReservationViewModel:ViewModelBase
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnpropertyChanged(nameof(Username));
            }
        } 
        
        private string _floorNumber;
        public string FloorNumber
        {
            get
            {
                return _floorNumber;
            }
            set
            {
                _floorNumber = value;
                OnpropertyChanged(nameof(FloorNumber));
            }
        } 
        
        private string _roomNumber;
        public string RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value;
                OnpropertyChanged(nameof(RoomNumber));
            }
        }
    }
}
