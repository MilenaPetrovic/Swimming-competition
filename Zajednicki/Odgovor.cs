using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki
{
    [Serializable]
    public class Odgovor
    {
        public bool Status { get; set; }
        public object Objekat { get; set; }
        public string Poruka { get; set; }
    }
}
