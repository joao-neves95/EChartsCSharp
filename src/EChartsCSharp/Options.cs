﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EChartsCSharp.OptionModels;

namespace EChartsCSharp
{
    public class Options
    {
        public TitleOptions Title { get; private set; }

        public Options SetTitle(TitleOptions titleOptions)
        {
            this.Title = titleOptions;

            return this;
        }

        public bool Animated { get; private set; }

        public Options ActivateAnimations()
        {
            this.Animated = true;

            return this;
        }

        public List<DataZoomOptions> DataZoom { get; private set; }

        public Options SetDataZoom(List<DataZoomOptions> dataZoomOptions)
        {
            this.DataZoom = dataZoomOptions;

            return this;
        }

        public Options AddDataZoom(DataZoomOptions dataZoomOptions)
        {
            this.DataZoom.Add(dataZoomOptions);

            return this;
        }
    }
}