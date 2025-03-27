using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RetailCorrector.Parser.UserControls
{
    public partial class TitleBar : UserControl, INotifyPropertyChanged
    {
        public string PageTitle => currPage.TitlePage;
        public bool IsMenuEnabled => currPage.UsageMenu;
        public bool IsNotFirst => main.CurrentNumberPage > 0;
        public bool IsNotLast => main.CurrentNumberPage < Enums.Page.Finish;

        public event PropertyChangedEventHandler? PropertyChanged;
        private readonly MainWindow main;
        private IPage currPage => App.Pages[(int)main.CurrentNumberPage];

        public TitleBar()
        {
            main = (MainWindow)Application.Current.MainWindow;
            InitializeComponent();
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
        public void ToPrepPage(object sender, RoutedEventArgs e) => ToPage(main.CurrentNumberPage - 1);
        public void ToNextPage(object sender, RoutedEventArgs e) => ToPage(main.CurrentNumberPage + 1);

        public void ToPage(Enums.Page numb)
        {
            main.CurrentNumberPage = numb;
            OnPropertyChanged(nameof(IsNotFirst));
            OnPropertyChanged(nameof(IsNotLast));
            OnPropertyChanged(nameof(IsMenuEnabled));
            OnPropertyChanged(nameof(PageTitle));

        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.ChangedButton == MouseButton.Left)
                Window.GetWindow(this)!.DragMove();
        }
    }
}
