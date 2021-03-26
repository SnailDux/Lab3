using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Rates
    {
        public float EUR { set; get; }
        public float GPB { set; get; }
        public float PLN { set; get; }

    }
    class Money
    {
        public string disclaimer { set; get; }
        public string license { set; get; }
        public int timestamp { set; get; }
        public string Base {set; get;}
        public Rates Rates { set; get; }

    }
}
