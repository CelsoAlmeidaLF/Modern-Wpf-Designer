
using MVVM.Models;
using Wpf_Designer;

namespace WPFExDesigner.ViewModels
{
    public class ViewModelUser : ViewModelBase
    {
        public ViewModelUser()
        {
            _modelUser = new ModelUser();
        }

        private ModelUser _modelUser;

        public ModelUser ModelUser
        {
            get { return _modelUser; }
            set { _modelUser = value; OnPropertyChanged("ModelUser"); }
        }
    }
}
