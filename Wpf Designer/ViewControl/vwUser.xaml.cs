using System.Windows.Controls;
using MVVM.Models;
using WPFExDesigner.ViewModels;
using System;

namespace WPF_Ex_Designer.ViewControl
{
    /// <summary>
    /// Interação lógica para vwUser.xam
    /// </summary>
    public partial class vwUser : UserControl
    {
        public vwUser()
        {
            InitializeComponent();
            DataContext = new ViewModelUser();
        }
    }
}
