using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EChartsCSharp.Html.HtmlChartExtensions
{
    public static class HtmlChartJsonExtensions
    {
        public static string GlobalOptionsToJson(this Chart @chart)
        {
            return JsonConvert.SerializeObject(
                @chart.GlobalOptions,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.None,
                    ContractResolver = new DefaultContractResolver()
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    }
                }
            );
        }

        public static async Task<string> GlobalOptionsToJsonAsync(this Chart @chart)
        {
            return await Task.Run(() => @chart.GlobalOptionsToJson()).ConfigureAwait(false);
        }
    }
}
