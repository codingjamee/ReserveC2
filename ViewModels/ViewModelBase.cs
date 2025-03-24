using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom2.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        // 특정 속성이 변경될 때 PropertyChanged 이벤트를 발생시켜 UI에 변경 사항을 알림
        public void OnpropertyChanged(string propteryName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propteryName));
        }
    }
}
