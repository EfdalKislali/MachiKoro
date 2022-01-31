using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro
{
    class Landmark : Cards
    {
        public Landmark(int _cost, int _effect, string _name, string _type)
            :base(_cost, _name, _cost)
        {
            landmarks = new List<Landmark>();
        }
        public List<Landmark> landmarks;

        public void VoegToe(Landmark newLandmark)
        {
            landmarks.Add(newLandmark);
        }

        

    }
}
