using System.Windows;
using BookshopWpf;

namespace BookshopWpf.Login
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        public Action? OkAction { get; private set; } = null;
        public Action? CancelAction { get; private set; } = null;

        public LoginWindow(ILoginWindowActions loginWindowActions)
        {
            OkAction = loginWindowActions.OkAction;
            CancelAction = loginWindowActions.CancelAction;
            InitializeComponent();
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