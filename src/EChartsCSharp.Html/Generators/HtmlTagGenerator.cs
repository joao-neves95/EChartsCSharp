
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EChartsCSharp.Html.Interfaces;

namespace EChartsCSharp.Html.Generators
{
    /// <summary>
    /// Html string generator. It returns HTML string content, not HTML node objects.
    ///
    /// </summary>
    internal class HtmlTagGenerator : IHtmlTagGenerator
    {
        private string ParseTagProps(IEnumerable<KeyValuePair<string, string>> htmlTagProps)
        {
            if (!htmlTagProps.Any())
            {
                return "";
            }

            StringBuilder props = new StringBuilder();

            for (int i = 0; i < htmlTagProps.Count(); ++i)
            {
                props.Append(' ');
                props.Append(htmlTagProps.ElementAt(i).Key);
                props.Append('=');
                props.Append('"');
                props.Append(htmlTagProps.ElementAt(i).Value);
                props.Append('"');
            }

            return props.ToString();
        }

        public string Tag(string name, IEnumerable<KeyValuePair<string, string>> htmlTagProps, string content)
        {
            return this.Tag(name, this.ParseTagProps(htmlTagProps), content);
        }

        public string Tag(string name, string props, string content)
        {
            return $"<{name} {props}>{content}</{name}>";
        }

        public string TagSelfClosing(string name, IEnumerable<KeyValuePair<string, string>> htmlTagProps)
        {
            return this.TagSelfClosing(name, this.ParseTagProps(htmlTagProps));
        }

        public string TagSelfClosing(string name, string props)
        {
            return $"<{name} {props} />";
        }

        public string Link(string rel, string type, string href)
        {
            return this.TagSelfClosing("link", $"rel=\"{rel}\" type=\"{type}\" href=\"{href}\"");
        }

        public string LinkStylesheet(string href)
        {
            return this.Link("stylesheet", "text/css", href);
        }

        public string Script(string src)
        {
            return this.Script(src, "");
        }

        public string Script(string src, string content)
        {
            return this.Script(src, Array.Empty<KeyValuePair<string, string>>(), content);
        }

        public string Script(string src, IEnumerable<KeyValuePair<string, string>> htmlTagProps, string content)
        {
            return this.Tag(
                "script",
                $"{(src?.Length == 0 ? "" : $"src=\"{src}\" crossorigin=\"anonymous\"")}" + this.ParseTagProps(htmlTagProps),
                content
            );
        }

        public string Paragraph(string content)
        {
            return this.Paragraph(content, Array.Empty<KeyValuePair<string, string>>());
        }

        public string Paragraph(string content, IEnumerable<KeyValuePair<string, string>> htmlTagProps)
        {
            return this.Tag("p", htmlTagProps, content);
        }

        public string Heading(uint size, string content)
        {
            return this.Heading(size, Array.Empty<KeyValuePair<string, string>>(), content);
        }

        public string Heading(uint size, IEnumerable<KeyValuePair<string, string>> htmlTagProps, string content)
        {
            return this.Tag($"h{size}", htmlTagProps, content);
        }

        public string Div(string content)
        {
            return this.Div(content, Array.Empty<KeyValuePair<string, string>>());
        }

        public string Div(string content, IEnumerable<KeyValuePair<string, string>> htmlTagProps)
        {
            return this.Tag("div", htmlTagProps, content);
        }
    }
}
