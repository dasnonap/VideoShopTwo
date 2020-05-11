using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Classes
{
    class Employees
    {
        private int empID;
        private string firstName;
        private string lastName;
        private int salary;
        private string phoneNumber;
        private int posID;
        private int cityID;
        private string pos;
        private string city;

        public Employees()
        {

        }
        public Employees(string fname, string lname, int salary, string phn, int posID, int cityID)
        {
            firstName = fname;
            lastName = lname;
            this.salary = salary;
            phoneNumber = phn;
            this.posID = posID;
            this.cityID = cityID;
        }
        public Employees(int id, string fname, string lname, int salary, string phn, int posID, int cityID)
        {
            empID = id;
            firstName = fname;
            lastName = lname;
            this.salary = salary;
            phoneNumber = phn;
            this.posID = posID;
            this.cityID = cityID;
        }

        //setters
        public void setID(int id)
        {
            empID = id;
        }
        public void setFirstName(string name)
        {
            firstName = name;
        }
        public void setLastName(string name)
        {
            lastName = name;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public void setPhone(string phone)
        {
            phoneNumber = phone;
        }
        public void setPos(int id)
        {
            posID = id;
        }
        public void setCity(int id)
        {
            cityID = id;
        }
        public void setStringPos(string pos)
        {
            this.pos = pos;
        }
        public void setStringCity(string city)
        {
            this.city = city;
        }





        //getters
        public int getID()
        {
            return empID;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public int getSalary()
        {
            return salary;
        }
        public string getPhone()
        {
            return phoneNumber;
        }
        public int getPos()
        {
            return posID;
        }
        public int getCity()
        {
            return cityID;
        }
        public string getStringPos()
        {
            return this.pos;
        }
        public string getStringCity()
        {
            return this.city;
        }

        public string[] getStringEmployee()
        {
            return new string[] { firstName, lastName, salary.ToString(), phoneNumber, pos, city };
        }
    }
}
