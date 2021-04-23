
using RandomNameGeneratorLibrary;

namespace EChartsCSharp
{
    public class HtmlOptions
    {
        public HtmlOptions()
        {
            PersonNameGenerator randomNameGen = new PersonNameGenerator();
            this.Id = randomNameGen.GenerateRandomFirstName();
        }
        public string Id { get; private set; }

        public HtmlOptions SetId(string id)
        {
            this.Id = id;

            return this;
        }
    }
}
