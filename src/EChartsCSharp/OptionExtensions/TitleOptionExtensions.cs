
using EChartsCSharp.OptionModels;

namespace EChartsCSharp.OptionExtensions
{
    public static class TitleOptionExtensions
    {
        public static Options SetChartTitle(this Options @options, string title)
        {
            @options.SetTitle(new TitleOptions().SetTitle(title));

            return @options;
        }
    }
}
