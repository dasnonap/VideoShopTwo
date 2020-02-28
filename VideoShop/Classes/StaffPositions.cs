using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    class StaffPositions
    {
        private string positionName;
        public StaffPositions() { }
        public void setPosName(String name)
        {
            positionName = name;
        }
        public string getPosName()
        {
            return positionName;
        }
    }
}
