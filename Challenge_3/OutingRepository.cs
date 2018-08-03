using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingRepository
    {
        private List<Outing> outings = new List<Outing>();

        public List<Outing> GetList()
        {
            return outings;
        }

        public void AddOutingToList(Outing outing)
        {
            outings.Add(outing);
        }
    }
}
