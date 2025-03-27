using System.Windows;
using RetailCorrector.Parser.Pages;

namespace RetailCorrector.Parser
{
    public partial class App : Application
    {
        internal readonly static IPage[] Pages = [
            new ParserPage(),
            new EditorPage(),
            new PreviewPage(),
            new ReporterPage(),
            new FinishPage(),
            ];
    }

}
