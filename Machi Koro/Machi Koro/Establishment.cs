using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro
{
    class Establishment : Cards
    {
        int rollNumber;
        // Amount is van hoeveel kaarten je van die soort hebt. 
        int Amount;
        
        public Establishment(int _cost, int _effect, string _name, string _type, int _RollNumber, int _Amount)
            :base(_cost, _name, _RollNumber)
        {
            
            establishments = new List<Establishment>();
        }

        public int RollNumber()
        {
            
            return rollNumber;
        }

        public List<Establishment> establishments;

        public void VoegToe(Establishment nieuwEstablishment)
        {
            establishments.Add(nieuwEstablishment);
        }

        
        
        
        
    }
}
