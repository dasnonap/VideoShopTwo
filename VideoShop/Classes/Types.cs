using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    class Types
    {
        private string typeName;
        public Types() { }
        public void setType(string name)
        {
            typeName = name;
        }
        public string getType()
        {
            return typeName;
        }
    }
}
