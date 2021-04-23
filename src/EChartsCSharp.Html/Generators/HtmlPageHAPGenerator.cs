
using System.Collections.Generic;
using System.IO;
using System.Linq;

using HtmlAgilityPack;

using EChartsCSharp.Html.Interfaces;

namespace EChartsCSharp.Html.Generators
{
    /// <summary>
    /// An IHtmlPageGenerator using HtmlAgilityPack.
    ///
    /// </summary>
    internal class HtmlPageHAPGenerator : IHtmlPageGenerator
    {
        public HtmlPageHAPGenerator(IHtmlTagGenerator htmlTagGenerator)
        {
            this.HtmlTagGenerator = htmlTagGenerator;
            this.HtmlDocument = new HtmlDocument();

            this.LoadTemplate();
        }

        private readonly HtmlDocument HtmlDocument;

        public IHtmlTagGenerator HtmlTagGenerator { get; private set; }

        private void LoadTemplate()
        {
            this.HtmlDocument.LoadHtml(File.ReadAllText("../Templates/htmlPageTemplate.html"));
        }

        public void AddHeadElem(IEnumerable<string> htmlHeadElems)
        {
            for (int i = 0; i < htmlHeadElems.Count(); ++i)
            {
                this.AddHeadElem(htmlHeadElems.ElementAt(i));
            }
        }

        public void AddHeadElem(string htmlHeadElem)
        {
            this.AddElemTo("//html/head", htmlHeadElem);
        }

        public void AddBodyElem(IEnumerable<string> htmlBodyElems)
        {
            for (int i = 0; i < htmlBodyElems.Count(); ++i)
            {
                this.AddBodyElem(htmlBodyElems.ElementAt(i));
            }
        }

        public void AddBodyElem(string htmlBodyElem)
        {
            this.AddElemTo("//html/body", htmlBodyElem);
        }

        public void AddElemTo(string xPath, string htmlContent)
        {
            this.HtmlDocument.DocumentNode.SelectSingleNode(xPath).AppendChild(HtmlNode.CreateNode(htmlContent));
        }

        public override string ToString()
        {
            return this.HtmlDocument.DocumentNode.OuterHtml;
        }
    }
}
