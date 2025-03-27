using System.Windows.Controls;

namespace RetailCorrector.Parser.Pages
{
    public partial class PreviewPage : UserControl, IPage
    {
        string IPage.TitlePage => "Предпоказ";
        bool IPage.UsageMenu => false;
        public PreviewPage()
        {
            InitializeComponent();
        }
    }
}
