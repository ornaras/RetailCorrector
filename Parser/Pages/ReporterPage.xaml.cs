using System.Windows.Controls;

namespace RetailCorrector.Parser.Pages
{
    public partial class ReporterPage : UserControl, IPage
    {
        public string TitlePage => "Дизайнер отчёта";
        public bool UsageMenu => true;

        public ReporterPage()
        {
            InitializeComponent();
        }
    }
}
