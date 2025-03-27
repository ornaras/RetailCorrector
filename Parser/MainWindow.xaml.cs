using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace RetailCorrector.Parser
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public Enums.Page CurrentNumberPage
        {
            get => _numbPage;
            set
            {
                _numbPage = value;
                _page.Child = (UserControl)App.Pages[(int)value];
            }
        }
        private Enums.Page _numbPage;

        public MainWindow()
        {
            InitializeComponent();
            TitleBar.ToPage(0);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected internal void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler is not null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
    }
}