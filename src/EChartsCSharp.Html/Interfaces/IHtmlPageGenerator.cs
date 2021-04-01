
using System.Collections.Generic;

namespace EChartsCSharp.Html.Interfaces
{
    public interface IHtmlPageGenerator
    {
        public IHtmlTagGenerator HtmlTagGenerator { get; }

        public void AddHeadElem(string htmlHeadElem);

        public void AddHeadElem(IEnumerable<string> htmlHeadElems);

        public void AddBodyElem(string htmlBodyElem);

        public void AddBodyElem(IEnumerable<string> htmlBodyElems);

        public void AddElemTo(string tag, string htmlContent);

        public string ToString();
    }
}
