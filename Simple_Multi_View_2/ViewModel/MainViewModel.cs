using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;

namespace Simple_Multi_View_2.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentVM;

        public ViewModelBase CurrentVM
        {
            get { return currentVM; }
            set { currentVM = value; RaisePropertyChanged(); }
        }

        public RelayCommand AddBtn{ get; set; }
        public RelayCommand ListBtn { get; set; }

        public MainViewModel()
        {
            AddBtn = new RelayCommand(()=> 
            {
                CurrentVM = SimpleIoc.Default.GetInstance<AddVM>();
            });

            ListBtn = new RelayCommand(()=> 
            {
                CurrentVM = SimpleIoc.Default.GetInstance<ListVM>();
            });
        }
    }
}