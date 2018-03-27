using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public abstract class Plant : Living
    {
        public override string Sustenance()
        {
            return "Sunlight";
        }
        public override string Lifespan { get; set; } = "indefinite";
    }
}
