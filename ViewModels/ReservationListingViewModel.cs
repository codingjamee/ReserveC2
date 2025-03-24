using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservoom2.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        public ICommand MakeReservationCommand
        {
            get;
        }

        public ReservationListingViewModel()
        {

        }
    }
}
