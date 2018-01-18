using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Multi_View_2.ViewModel
{
    public class ListVM:ViewModelBase
    {
        public ObservableCollection<string> MessengerList { get; set; }

        Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();
        public ListVM()
        {
            MessengerList = new ObservableCollection<string>();

            messenger.Register<PropertyChangedMessage<string>>(this, AddToList);
        }

        private void AddToList(PropertyChangedMessage<string> message)
        {
            MessengerList.Add(message.NewValue);
        }
    }
}
