using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoShop.Classes;
using VideoShop.TableClasses;

namespace VideoShop.BufferClasses
{
    class CitiesBuffer
    {
        private CitiesTable citiesTable = new CitiesTable();
        private List<Cities> citiesArray = new List<Cities>();

        //to do da mahna tez prostorii
        public CitiesBuffer()
        {
            citiesArray.Add(new Cities(1, "Варна"));
            citiesArray.Add(new Cities(2, "Добрич"));
        }

        /// <summary>
        /// Gets the data from tha DB
        /// </summary>
        /// <returns>Returns true if the data is selected successfully, and false if occured an error</returns>
        public bool initializeCitiesArray()
        {
            if( !citiesTable.Select(citiesArray) )
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Enters a row into the DB
        /// </summary>
        /// <param name="c">The structure that needs to be inserted</param>
        /// <returns>Returns true if the data is selected successfully, and false if occured an error</returns>
        public bool insertRow(Cities c)
        {
            if (!checkDuplicateRecord(c))
            {
                MessageBox.Show("Този град вече съществува.");
                return false;
            }

            if( !citiesTable.Insert(c))
            {
                MessageBox.Show("Неуспешен опит за извършване на операцията. ");
                return false;
            }

            addNewRecord(c);
            return true;            
        }
        public List<Cities> returnRecords()
        {
            return citiesArray;
        }

        public bool changeRow(Cities c)
        {
            //to do 
            if ( !checkIfInside(c))
            {
                MessageBox.Show("Не можe");
                return false;
            }

            foreach(Cities n in citiesArray)
            {
                if(n.getId() == c.getId())
                {
                    //tuka puska kym bazata
                    n.setCity( c.getCity() );
                    MessageBox.Show("yes");
                }
            }
            return true;
        }

        public bool removeRecord(Cities c)
        {
            //to do 
            if (!checkIfInside(c))
            {
                MessageBox.Show("Не можe");
                return false;
            }

            foreach (Cities n in citiesArray)
            {
                if (n.getId() == c.getId())
                {
                    //to do i zaqvka kym bzata pyrvo i posle update na masiva
                    citiesArray.Remove(n);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if a record exists 
        /// </summary>
        /// <param name="c">The new structure that we need to change</param>
        /// <returns>Returns true if the record exists, and false if it does not exist</returns>
        private bool checkIfInside(Cities c)
        {
            foreach(Cities n in citiesArray)
            {
                if(c.getId() == n.getId())
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Checks if there is already a duplicate record in the list
        /// </summary>
        /// <param name="c">The new structure that we need to change</param>
        /// <returns>Returns true if the record doesnot exist, and false if exists</returns>
        private bool checkDuplicateRecord(Cities c)
        {
            foreach(Cities n in citiesArray)
            {
                if(n.getCity() == c.getCity())
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Adds the new record to the buffer list without selecting from the DB
        /// </summary>
        /// <param name="c">The new structure that needs to be added</param>
        private void addNewRecord(Cities c)
        {
            citiesArray.Add(c);
        }
    }
}
