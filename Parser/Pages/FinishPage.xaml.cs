using System.Windows.Controls;

namespace RetailCorrector.Parser.Pages
{
    public partial class FinishPage : UserControl, IPage
    {
        public string TitlePage => "Завершение";
        public bool UsageMenu => false;

        public FinishPage()
        {
            InitializeComponent();
        }
    }
}
