using System;
using System.Collections.Generic;
using System.Text;

namespace Kompleksni
{
    class KompleksniBrojKlasa
    {
        public KompleksniBrojKlasa(double realni, double imaginarni) {
            RealniDio = realni;
            ImaginarniDio = imaginarni;
        }

        public double RealniDio;
        public double ImaginarniDio;

        public override string ToString()
        {
            return $"({RealniDio}, {ImaginarniDio})";
        }
    }
}
