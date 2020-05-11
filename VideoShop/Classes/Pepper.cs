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
        private static Pepper _instance = null;
        private static readonly object _syncObject = new object();

        public static Pepper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new Pepper();
                        }
                    }
                }
                return _instance;
            }
        }
        /// <summary>
        /// Функцията хешира незащитените данни
        /// </summary>
        /// <param name="unseasonedDish">Незащитените данни, които ще хешираме</param>
        /// <returns>Връща хешираните вече данни</returns>
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
        /// <summary>
        /// Проверява дали подадените данни са верни и сравнява паролите
        /// </summary>
        /// <param name="passOne">Първа парола</param>
        /// <param name="passTwo">Втора парола</param>
        /// <returns>Връща true ако паролите съвпадат</returns>
        public bool Authenticate(string passOne, string passTwo)
        {
            byte[] one = Encoding.ASCII.GetBytes(passOne);
            byte[] two = Encoding.ASCII.GetBytes(passTwo);

            for(int i = 0; i < two.Length; i++)
            {
                if (!one[i].Equals(two[i]))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Проверява дали влиза админ 
        /// </summary>
        /// <param name="adminName">Потребителското име на админа</param>
        /// <param name="adminPassword">Паролата</param>
        /// <returns>Връща true ако са автентични данните</returns>
        public bool CheckForAdmin(string adminName, string adminPassword)
        {
            if(adminName == this.PepperOnTheDish("admin"))
            {
                if(findAdmin(adminPassword))
                {
                    return true;
                }
                return false;
            }

            return false;
        }
        /// <summary>
        /// Проверява дали паролата съвпада със id на служител
        /// </summary>
        /// <param name="adminPass">Парола, която проверяваме</param>
        /// <returns>Връща true ако има такъв служител</returns>
        private bool findAdmin(string adminPass) 
        {
            int id = 0;
            char[] array = adminPass.ToCharArray();
            List<char> cID = new List<char>();
            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsDigit(array[i]))
                {
                    cID.Add(array[i]);
                }
            }
            id = Int32.Parse(new string(cID.ToArray()));
            foreach(Employees e in ViewControl.Instance.getEmployeesArray())
            {
                if(e.getID() == id)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
