using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }

        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("adding hyperlink...");
        }

    }
}
