using System.Windows;

namespace wpf_demo_app
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _message;

        public string Message {
            get
            {
                return _message;
            }

            set {
                _message = value;
                this.txBkMsg.Text = _message;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }


            
    
    }
}
