using System.Collections.Generic;

using EChartsCSharp.OptionEnums;

namespace EChartsCSharp.OptionModels
{
    public class DataZoomOptions
    {
        public DataZoomOptions()
        {
            // Default values here.
            this.Show = true;
            this.Disabled = false;
        }

        public string Type { get; private set; }

        public DataZoomOptions SetType(DataZoomType dataZoomType)
        {
            switch (dataZoomType)
            {
                case DataZoomType.Inside:
                    this.Type = "inside";
                    break;
                case DataZoomType.Slider:
                    this.Type = "slider";
                    break;
            }

            return this;
        }

        public bool Show { get; private set; }

        public bool Disabled { get; set; }

        public DataZoomOptions DeactivateVisibility()
        {
            this.Show = true;

            return this;
        }

        public int Start { get; private set; }

        public DataZoomOptions SetStart(int startPercentage)
        {
            this.Start = startPercentage;

            return this;
        }

        public int End { get; private set; }

        public DataZoomOptions SetEnd(int endPercentage)
        {
            this.End = endPercentage;

            return this;
        }

        public List<int> xAxisIndex { get; private set; }

        public DataZoomOptions SetXAxisControlCoordinates(List<int> xAxisIndexCoordinates)
        {
            this.xAxisIndex = xAxisIndexCoordinates;

            return this;
        }

        public List<int> yAxisIndex { get; private set; }

        public DataZoomOptions SetYAxisControlCoordinates(List<int> radiusAxisIndexCoordinates)
        {
            this.yAxisIndex = radiusAxisIndexCoordinates;

            return this;
        }

        public List<int> RadiusAxisIndex { get; private set; }

        public DataZoomOptions SetRadiusAxisControlCoordinates(List<int> radiusAxisIndexCoordinates)
        {
            this.RadiusAxisIndex = radiusAxisIndexCoordinates;

            return this;
        }

        public List<int> AngleAxisIndex { get; private set; }

        public DataZoomOptions SetAngleAxisControlCoordinates(List<int> angleAxisIndexCoordinates)
        {
            this.AngleAxisIndex = angleAxisIndexCoordinates;

            return this;
        }
    }
}
