using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro
{
    class Table
    {
        public List<Cards> kaarten;

        public Table()
        {
            kaarten = new List<Cards>();
        }

        public void VoegToe(Cards nieuwekaart)
        {
            kaarten.Add(nieuwekaart);
        }
    }
}
