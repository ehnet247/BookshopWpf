using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookshopWpf.Login
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        public Action? CancelAction { get; private set; } = null;
        public Action? OkAction { get; private set; } = null;

        public LoginWindow()
        {
            InitializeComponent();
        }

        public void SetCancelAction(Action cancelAction)
        {
            CancelAction = cancelAction;
        }

        public void SetOkAction(Action okAction)
        {
            OkAction = okAction;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            CancelAction?.Invoke();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            OkAction?.Invoke();
        }
    }
}