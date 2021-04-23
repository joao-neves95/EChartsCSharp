
using System;
using System.Collections.Generic;

using EChartsCSharp.Html.Interfaces;
using EChartsCSharp.Html.HtmlChartExtensions;

namespace EChartsCSharp.Html.Generators
{
    internal class EChartsHtmlGenerator
    {
        private readonly IHtmlPageGenerator _HtmlPageGenerator;

        private readonly IHtmlTagGenerator _HtmlTagGenerator;

        public EChartsHtmlGenerator(
            IHtmlPageGenerator htmlPageGenerator,
            IHtmlTagGenerator htmlTagGenerator
        )
        {
            this._HtmlPageGenerator = htmlPageGenerator;
            this._HtmlTagGenerator = htmlTagGenerator;
        }

        private bool _Disposed;

        public string GenerateHtmlPage(List<Chart> charts)
        {
            if (this._Disposed)
            {
                throw new ObjectDisposedException(this.GetType().Name);
            }

            // temp.
            this._HtmlPageGenerator.AddHeadElem(this._HtmlTagGenerator.Script("https://cdn.jsdelivr.net/npm/echarts@4.9.0/dist/echarts-en.min.js"));

            foreach(Chart chart in charts)
            {
                this.AddHtmlChartDiv(chart);
            }

            this._Disposed = true;
            return this._HtmlPageGenerator.ToString();
        }

        private void AddHtmlChartDiv(Chart chart)
        {
            string chartDivID = $"{chart.GlobalHtmlOptions.Id}_CHART";
            string chartVarName = $"{chartDivID}_ELEM";

            this._HtmlPageGenerator.AddBodyElem(this._HtmlTagGenerator.Div(
                "",
                new KeyValuePair<string, string>[]
                {
                    new KeyValuePair<string, string>( "id", chartDivID ),
                    new KeyValuePair<string, string>( "style", "width: 1000px; height: 600px;" )
                }
            ));

            this._HtmlPageGenerator.AddBodyElem(this._HtmlTagGenerator.Script(
                "",
                $@"
                    let {chartVarName} = echarts.init( document.getElementById( '{chartDivID}' ) );

                    {chartVarName}.setOption( JSON.parse( '{@chart.GlobalOptionsToJson()}' ) );
                "
            ));
        }
    }
}
