using System.Windows.Controls;

namespace RetailCorrector.Parser.Pages
{
    public partial class ParserPage : UserControl, IPage
    {
        public string TitlePage => "Парсер чеков";
        public bool UsageMenu => true;

        public ParserPage()
        {
            InitializeComponent();
        }
    }
}
