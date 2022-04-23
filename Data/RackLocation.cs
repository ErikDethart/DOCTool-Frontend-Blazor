using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class RackLocation
    {
        public String Label { get; set; }

        public List<Box> contents = new List<Box>();
    }
}
