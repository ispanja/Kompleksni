using System;
using System.Collections.Generic;
using System.Text;

namespace Kompleksni
{
    struct KompleksniBrojStruktura {

        public double RealniDio;
        public double ImaginarniDio;

        public KompleksniBrojStruktura(double realni, double imaginarni)
        {
            RealniDio = realni;
            ImaginarniDio = imaginarni;
        }

        public override string ToString()
        {
            return $"({RealniDio}, {ImaginarniDio})";
        }
    }
}

