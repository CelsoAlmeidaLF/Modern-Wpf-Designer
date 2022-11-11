using System.Windows;
using System.Windows.Input;
using WPFExDesigner.ViewModels;

namespace Wpf_Designer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region 'default methods'
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModelHome();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            if (this.AsideMenu.Width.Equals(42))
            {
                this.lbInicio.Visibility = Visibility.Visible;
                this.lbFinanceiro.Visibility = Visibility.Visible;
                this.lbConfig.Visibility = Visibility.Visible;
                this.lbUser.Visibility = Visibility.Visible;
                this.AsideMenu.Width = 164;
            }
            else
            {
                this.lbInicio.Visibility = Visibility.Collapsed;
                this.lbFinanceiro.Visibility = Visibility.Collapsed;
                this.lbConfig.Visibility = Visibility.Collapsed;
                this.lbUser.Visibility = Visibility.Collapsed;
                this.AsideMenu.Width = 42;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Grid_MouseDown_Click(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();
        }
        #endregion

        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewModelHome();
        }

        private void btnFinanceiro_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewModelFinanceiro();
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewModelUser();
        }

        private void btnConfig_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewModelConfig();
        }
    }
}
