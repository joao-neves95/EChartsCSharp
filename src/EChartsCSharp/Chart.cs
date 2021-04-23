
namespace EChartsCSharp
{
    public class Chart
    {
        public Options GlobalOptions { get; private set; }

        public Chart SetGlobalOptions(Options globalOptions)
        {
            this.GlobalOptions = globalOptions;

            return this;
        }

        public HtmlOptions GlobalHtmlOptions { get; private set; } = new HtmlOptions();

        public Chart SetGlobalHtmlOptions(HtmlOptions globalHtmlOptions)
        {
            this.GlobalHtmlOptions = globalHtmlOptions;

            return this;
        }
    }
}
