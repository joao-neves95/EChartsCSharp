
namespace EChartsCSharp.OptionModels
{
    public class TitleOptions
    {
        public  string Title { get; private set; } = "";

        public TitleOptions SetTitle(string title)
        {
            this.Title = title;

            return this;
        }
    }
}
