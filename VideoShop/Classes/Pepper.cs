using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    class Pepper
    {
       public string PepperOnTheDish(string unseasonedDish)
        {
            
            using ( SHA256 pepper = SHA256.Create() ){

                byte[] pepperContainer = pepper.ComputeHash(Encoding.UTF8.GetBytes(unseasonedDish));

                StringBuilder seasonedDish = new StringBuilder();
                for (int i = 0; i < pepperContainer.Length; i++)
                {
                    seasonedDish.Append(pepperContainer[i].ToString("x2") );
                }
                return seasonedDish.ToString();
            }
        }

    }
}
