using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RetailCorrector.Parser.UserControls
{
    public partial class TitleBar : UserControl, INotifyPropertyChanged
    {
        public string PageTitle
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged(nameof(PageTitle));
            }
        }
        public Brush PrepPageColor { get; private set; } = Brushes.White;
        public Brush NextPageColor { get; private set; } = Brushes.White;
        public Brush MenuColor { get; private set; } = Brushes.White;

        private string title = "";

        public event PropertyChangedEventHandler? PropertyChanged;

        public TitleBar()
        {
            InitializeComponent();
        }

        public void EnableMenu(bool enable)
        {
            MenuColor = enable ? Brushes.White : new SolidColorBrush(Color.FromRgb(0xCC, 0xCC, 0xCC));
            OnPropertyChanged(nameof(MenuColor));
        }

        protected internal void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler is not null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        public void CloseApp(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
        public void MinApp(object sender, RoutedEventArgs e) => 
            Window.GetWindow(this)!.WindowState = WindowState.Minimized;
        public void OpenMenu(object sender, RoutedEventArgs e)
        {

        }
        public void ToPrepPage(object sender, RoutedEventArgs e)
        {
            OnPropertyChanged(nameof(PrepPageColor));
        }
        public void ToNextPage(object sender, RoutedEventArgs e)
        {
            OnPropertyChanged(nameof(NextPageColor));
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.ChangedButton == MouseButton.Left)
                Window.GetWindow(this)!.DragMove();
        }
    }
}
