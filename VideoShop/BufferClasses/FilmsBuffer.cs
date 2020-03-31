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
    class FilmsBuffer
    {
        private TableTemplate<Films> filmsTable = new TableTemplate<Films>();
        private List<Object> filmsArray = new List<Object>();

        public FilmsBuffer()
        {

        }
        public bool initializeFilmsArray()
        {
            if( !filmsTable.Select("FILMS", filmsArray))
            {
                MessageBox.Show("Неуспешно зареждане на данните");
                return false;
            }
            return true;
        }
        public List<Object> returnRecords()
        {
            return filmsArray;
        }

        public Films returnFilmByID(int id)
        {
            foreach(Films i in filmsArray)
            {
                if(i.getID() == id)
                {
                    return i;
                }
            }
            return null;
        }

        /// <summary>
        /// Enters a row into the DB
        /// </summary>
        /// <param name="f">The structure that needs to be inserted</param>
        /// <returns>Returns true if the data is selected successfully, and false if occured an error</returns>
        public bool insertRow(Films f)
        {
            if (!checkDuplicateRecord(f))
            {
                MessageBox.Show("Този град вече съществува.");
                return false;
            }

            if (!filmsTable.Insert("FILMS", f))
            {
                MessageBox.Show("Неуспешен опит за извършване на операцията. ");
                return false;
            }

            addNewRecord(f);
            return true;
        }
        public int getID(string name)
        {
            foreach(Films f in filmsArray)
            {
                if(f.getName() == name)
                {
                    return f.getID();
                }
            }
            return 0;
        }

        /// <summary>
        /// Функция за промяна на запис
        /// </summary>
        /// <param name="f">Вече промененият запис</param>
        /// <returns>Връща true ако промяната е станала успешно</returns>
        public bool changeRow(Films f)
        {
            if (!checkIfInside(f))
            {
                MessageBox.Show("Не можe");
                return false;
            }

            foreach (Films n in filmsArray)
            {
                if (n.getID() == f.getID())
                {
                    n.setFilmSettings(f);
                    if (!filmsTable.Update("FILMS", n))
                    {
                        MessageBox.Show("no");
                        return false;
                    }
                    MessageBox.Show("yes");
                }
            }
            return true;
        }

        /// <summary>
        /// Изтриване на запис
        /// </summary>
        /// <param name="f">Записут, който ще изтриваме</param>
        /// <returns>Връща true ако успешно изтрием записа</returns>
        public bool deleteRow(Films f)
        {
            if (!checkIfNameInside(f))
            {
                MessageBox.Show("no");
                return false;
            }

            foreach (Films n in filmsArray)
            {
                if (n.getName() == f.getName())
                {
                    f.setID(n.getID());
                    filmsArray.Remove(n);
                    if (!filmsTable.Delete(f))
                    {
                        MessageBox.Show("no");
                        return false;
                    }
                    break;
                }
            }
            MessageBox.Show("yes");
            return true;
        }


        /// <summary>
        /// Checks if a record exists 
        /// </summary>
        /// <param name="f">The new structure that we need to change</param>
        /// <returns>Returns true if the record exists, and false if it does not exist</returns>
        private bool checkIfInside(Films f)
        {
            foreach (Films n in filmsArray)
            {
                if (n.getID() == f.getID())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Проверка дали записът съществува в масива
        /// </summary>
        /// <param name="f">Записът, който търсим</param>
        /// <returns>Връща true ако записът съществува </returns>
        private bool checkIfNameInside(Films f)
        {
            foreach (Films i in filmsArray)
            {
                if (f.getName() == i.getName())
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
        private bool checkDuplicateRecord(Films f)
        {
            foreach (Films i in filmsArray)
            {
                if (i.getName() == f.getName())
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Adds the new record to the buffer list without selecting from the DB
        /// </summary>
        /// <param name="f">The new structure that needs to be added</param>
        private void addNewRecord(Films f)
        {
            filmsArray.Add(f);
        }
    }
}
