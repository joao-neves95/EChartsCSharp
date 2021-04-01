
using System.Collections.Generic;

namespace EChartsCSharp.Html.Interfaces
{
    public interface IHtmlTagGenerator
    {
        public string Tag(string name, IEnumerable<KeyValuePair<string, string>> htmlTagProps, string content);

        public string Tag(string name, string props, string content);

        public string TagSelfClosing(string name, IEnumerable<KeyValuePair<string, string>> htmlTagProps);

        public string TagSelfClosing(string name, string props);

        public string Link(string rel, string type, string href);

        public string LinkStylesheet(string href);

        public string Script(string src, IEnumerable<KeyValuePair<string, string>> htmlTagProps, string content);

        public string Script(string src, string content);

        public string Script(string src);

        public string Paragraph(string content);

        public string Paragraph(string content, IEnumerable<KeyValuePair<string, string>> htmlTagProps);

        public string Heading(uint size, IEnumerable<KeyValuePair<string, string>> htmlTagProps, string content);

        public string Heading(uint size, string content);

        public string Div(string content);

        public string Div(string content, IEnumerable<KeyValuePair<string, string>> htmlTagProps);
    }
}
