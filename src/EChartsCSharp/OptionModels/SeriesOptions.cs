
using System.Collections.Generic;

using EChartsCSharp.OptionEnums;

namespace EChartsCSharp.OptionModels
{
    public class SeriesOptions
    {
        public SeriesOptions()
        {
            this.SetCursor(CursorType.Default);
        }

        public string Name { get; private set; }

        public SeriesOptions SetName(string name)
        {
            this.Name = name;

            return this;
        }

        public bool Smooth { get; set; }

        public SeriesOptions ActivateSmoothing()
        {
            this.Smooth = true;

            return this;
        }

        public string Color { get; private set; }

        public SeriesOptions SetColor(string color)
        {
            this.Color = color;

            return this;
        }

        public string Type { get; private set; }

        public SeriesOptions SetType(SeriesType seriesType)
        {
            switch (seriesType)
            {
                case SeriesType.Line:
                    this.Type = "line";
                    break;
                case SeriesType.Bar:
                    this.Type = "bar";
                    break;
                case SeriesType.Pie:
                    this.Type = "pie";
                    break;
                case SeriesType.Candlestick:
                    this.Type = "candlestick";
                    break;
                case SeriesType.Scatter:
                    this.Type = "scatter";
                    break;
            }
            return this;
        }

        public string Cursor { get; private set; }

        public SeriesOptions SetCursor(CursorType cursor)
        {
            switch (cursor)
            {
                case CursorType.Default:
                    this.Type = "default";
                    break;
                case CursorType.Auto:
                    this.Cursor = "auto";
                    break;
                case CursorType.Pointer:
                    this.Cursor = "pointer";
                    break;
                case CursorType.Grab:
                    this.Cursor = "grab";
                    break;
                case CursorType.Crosshair:
                    this.Cursor = "crosshair";
                    break;
                case CursorType.Help:
                    this.Cursor = "help";
                    break;
                case CursorType.Wait:
                    this.Cursor = "wait";
                    break;
                case CursorType.ZoomIn:
                    this.Cursor = "zoom-in";
                    break;
                case CursorType.None:
                    this.Cursor = "none";
                    break;
            }

            return this;
        }

        public List<object> Data { get; private set; }

        public SeriesOptions SetData()
        {
            return this;
        }
    }
}
