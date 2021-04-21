
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
    }
}
