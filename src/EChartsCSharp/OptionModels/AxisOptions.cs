using System.Collections.Generic;

using EChartsCSharp.OptionEnums;

namespace EChartsCSharp.OptionModels
{
    public class AxisOptions
    {
        public AxisOptions()
        {
            this.SetType(AxisType.Category);
        }

        public bool Scale { get; set; }

        public AxisOptions ActivateScaling()
        {
            this.Scale = true;

            return this;
        }

        public string Type { get; private set; }

        public AxisOptions SetType(AxisType axisType)
        {
            switch (axisType)
            {
                case AxisType.Category:
                    this.Type = "category";
                    break;
                case AxisType.Value:
                    this.Type = "value";
                    break;
                case AxisType.Time:
                    this.Type = "time";
                    break;
                case AxisType.Log:
                    this.Type = "log";
                    break;
            }

            return this;
        }

        public List<object> Data { get; private set; }

        public AxisOptions SetData(List<object> axisData)
        {
            this.Data = axisData;

            return this;
        }

        public AxisOptions AddData(object axisData)
        {
            (this.Data ??= new List<object>()).Add(axisData);

            return this;
        }

        public AxisOptions AddData(List<object> axisData)
        {
            (this.Data ??= new List<object>()).AddRange(axisData);

            return this;
        }
    }
}
