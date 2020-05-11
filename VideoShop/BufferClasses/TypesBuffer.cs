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
    class TypesBuffer
    {
        private TableTemplate<Types> typesTable = new TableTemplate<Types>();
        private List<Object> typesArray = new List<Object>();


        public TypesBuffer()
        {

        }

        /// <summary>
        /// Зареждане на филмите от базата данни
        /// </summary>
        /// <returns>Връща true ако успешно са заредени данните от базата данни</returns>
        public bool initializeTypesArray()
        {
            if (!typesTable.Select("[TYPES]", typesArray))
            {
                MessageBox.Show("Неуспешно зареждане на данните");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Функцията връща масива от филми от базата данни
        /// </summary>
        /// <returns>Връща масива</returns>
        public List<Object> returnRecords()
        {
            return typesArray;
        }

        public int getID(string name)
        {
            foreach (Types g in typesArray)
            {
                if (g.getType() == name)
                {
                    return g.getID();
                }
            }
            return 0;
        }

        /// <summary>
        /// Enters a row into the DB
        /// </summary>
        /// <param name="f">The structure that needs to be inserted</param>
        /// <returns>Returns true if the data is selected successfully, and false if occured an error</returns>
        public bool insertRow(Types t)
        {
            if (!checkDuplicateRecord(t))
            {
                MessageBox.Show("Този град вече съществува.");
                return false;
            }

            if (!typesTable.Insert("TYPES", t))
            {
                MessageBox.Show("Неуспешен опит за извършване на операцията. ");
                return false;
            }

            addNewRecord(t);
            return true;
        }

        /// <summary>
        /// Функция за промяна на запис
        /// </summary>
        /// <param name="f">Вече промененият запис</param>
        /// <returns>Връща true ако промяната е станала успешно</returns>
        public bool changeRow(Types f)
        {
            if (!checkIfInside(f))
            {
                MessageBox.Show("Не можe");
                return false;
            }

            foreach (Types n in typesArray)
            {
                if (n.getID() == f.getID())
                {
                    n.setID(f.getID());
                    n.setType(f.getType());
                    if (!typesTable.Update("TYPES", n))
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
        /// <param name="f">Записът, който ще изтриваме</param>
        /// <returns>Връща true ако успешно изтрием записа</returns>
        public bool deleteRow(Types t)
        {
            if (!checkIfNameInside(t))
            {
                MessageBox.Show("no");
                return false;
            }

            foreach (Types n in typesArray)
            {
                if (n.getType() == t.getType())
                {
                    t.setID(n.getID());
                    typesArray.Remove(n);
                    if (!typesTable.Delete(t))
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
        /// Добавя новия запис в буферния масив
        /// </summary>
        /// <param name="f">Новата структура, която ще добавяме</param>
        private void addNewRecord(Types t)
        {
            typesArray.Add(t);
        }

        /// <summary>
        /// Проверява дали вече съществува дубликат 
        /// </summary>
        /// <param name="f">Структурата, която ще проверяваме</param>
        /// <returns>Връща true ако не съществува</returns>
        private bool checkDuplicateRecord(Types t)
        {
            foreach (Types i in typesArray)
            {
                if (i.getType() == t.getType())
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Проверява дали структурата съществува
        /// </summary>
        /// <param name="f">Структурата, която искаме да проверим</param>
        /// <returns>Връща true ако съществува</returns>
        private bool checkIfInside(Types f)
        {
            foreach (Types n in typesArray)
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
        private bool checkIfNameInside(Types f)
        {
            foreach (Types i in typesArray)
            {
                if (f.getType() == i.getType())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
