
using System.Collections.Generic;

using EChartsCSharp.Html.Generators;

namespace EChartsCSharp.Html.HtmlChartExtensions
{
    public static class HtmlChartPageExtensions
    {
        public static string BuildHtmlPage(this Chart @chart)
        {
            return GetEChartsHtmlGenerator().GenerateHtmlPage(new List<Chart>() { @chart });
        }

        public static string BuildHtmlPage(this List<Chart> @charts)
        {
            return GetEChartsHtmlGenerator().GenerateHtmlPage(@charts);
        }

        private static EChartsHtmlGenerator GetEChartsHtmlGenerator()
        {
            return new EChartsHtmlGenerator(new HtmlPageHAPGenerator(new HtmlTagGenerator()), new HtmlTagGenerator());
        }
    }
}
