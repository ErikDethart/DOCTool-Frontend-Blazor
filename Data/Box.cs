using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class Box
    {
        public String Label { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public List<Asset> contents = new List<Asset>();
    }
}
