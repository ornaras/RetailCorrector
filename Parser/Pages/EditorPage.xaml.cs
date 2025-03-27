using System.Windows.Controls;

namespace RetailCorrector.Parser.Pages
{
    public partial class EditorPage : UserControl, IPage
    {
        public string TitlePage => "Редактор чеков";
        public bool UsageMenu => true;

        public EditorPage()
        {
            InitializeComponent();
        }
    }
}
