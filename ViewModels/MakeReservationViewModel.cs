using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservoom2.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
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

        private DateTime _startDate;
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                OnpropertyChanged(nameof(StartDate));
            }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                OnpropertyChanged(nameof(EndDate));
            }
        }

        public ICommand SubmitCommand
        {
            get;
        }    
        public ICommand CancelCommand
        {
            get;
        }

        public MakeReservationViewModel()
        {


        }

    }
}
