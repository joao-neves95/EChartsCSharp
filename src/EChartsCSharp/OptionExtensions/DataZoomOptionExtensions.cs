using System.Collections.Generic;

using EChartsCSharp.OptionEnums;
using EChartsCSharp.OptionModels;

namespace EChartsCSharp.OptionExtensions
{
    public static class DataZoomOptionExtensions
    {
        public static Options AddDefaultHorizontalSlider(this Options @options)
        {
            DataZoomOptions dataZoomOptions = new DataZoomOptions()
                                                  .SetType(DataZoomType.Slider)
                                                  .SetStart(0)
                                                  .SetEnd(35)
                                                  .SetXAxisControlCoordinates(new List<int>() { 0 });

            @options.AddDataZoom(dataZoomOptions);
            return @options;
        }

        public static Options AddDefaultVerticalSlider(this Options @options)
        {
            DataZoomOptions dataZoomOptions = new DataZoomOptions()
                                                  .SetType(DataZoomType.Slider)
                                                  .SetStart(0)
                                                  .SetEnd(35)
                                                  .SetYAxisControlCoordinates(new List<int>() { 0 });

            @options.AddDataZoom(dataZoomOptions);
            return @options;
        }

        public static Options AddDefaultHorizontalInside(this Options @options)
        {
            DataZoomOptions dataZoomOptions = new DataZoomOptions()
                                                  .SetType(DataZoomType.Inside)
                                                  .SetStart(0)
                                                  .SetEnd(35)
                                                  .SetXAxisControlCoordinates(new List<int>() { 0 });

            @options.AddDataZoom(dataZoomOptions);
            return @options;
        }

        public static Options AddDefaultVerticalInside(this Options @options)
        {
            DataZoomOptions dataZoomOptions = new DataZoomOptions()
                                                  .SetType(DataZoomType.Inside)
                                                  .SetStart(0)
                                                  .SetEnd(35)
                                                  .SetYAxisControlCoordinates(new List<int>() { 0 });

            @options.AddDataZoom(dataZoomOptions);
            return @options;
        }
    }
}
