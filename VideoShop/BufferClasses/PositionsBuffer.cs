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
    class PositionsBuffer
    {
        private TableTemplate<Positions> posTable = new TableTemplate<Positions>();
        private List<Object> positionsArray = new List<Object>();

        public PositionsBuffer()
        {

        }

        /// <summary>
        /// Функция за връщане на пълният масив
        /// </summary>
        /// <returns>Връща масив от обекти</returns>
        public List<Object> returnRecords()
        {
            return positionsArray;
        }

        public int getID(string name)
        {
            foreach (Positions p in positionsArray)
            {
                if (name == p.getPosName())
                {
                    return p.getID();
                }
            }
            return 0;
        }

        public string getPosition(int id)
        {
            foreach (Positions p in positionsArray)
            {
                if (id == p.getID())
                {
                    return p.getPosName();
                }
            }
            return "";
        }

        /// <summary>
        /// Взима данните от базата данни и ги записва в буферния масив
        /// </summary>
        /// <returns>Връща true ако всички данни са добавени успешно</returns>
        public bool initializePositionsArray()
        {
            if (!posTable.Select("POSITIONS", positionsArray))
            {
                MessageBox.Show("Неуспешно зареждане на данните");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Функция за добавяне на запис 
        /// </summary>
        /// <param name="e">Записът, който ще добавяме</param>
        /// <returns>Връща true ако записът е добавен успешно</returns>
        public bool insertRow(Positions e)
        {
            if (!checkDuplicateRecord(e))
            {
                MessageBox.Show("Този град вече съществува.");
                return false;
            }

            if (!posTable.Insert("POSITIONS", e))
            {
                MessageBox.Show("Неуспешен опит за извършване на операцията. ");
                return false;
            }

            addNewRecord(e);
            return true;
        }

        /// <summary>
        /// Функция за промяна на запис
        /// </summary>
        /// <param name="s">Вече промененият запис</param>
        /// <returns>Връща true ако промяната е станала успешно</returns>
        public bool changeRow(Positions e)
        {
            if (!checkIfInside(e))
            {
                MessageBox.Show("Не можe");
                return false;
            }

            foreach (Positions n in positionsArray)
            {
                if (n.getID() == e.getID())
                {
                    n.setPosName(e.getPosName());
                    if (!posTable.Update("POSITIONS", e))
                    {
                        MessageBox.Show("no");
                        return false;
                    }
                    break;
                }
            }
            return true;
        }


        /// <summary>
        /// Премахване на запис
        /// </summary>
        /// <param name="s">Записът, който ще премахваме</param>
        /// <returns>Връща true ако премахването е успешно</returns>
        public bool removeRecord(Positions e)
        {

            if (!checkIfInside(e))
            {
                MessageBox.Show("Не можe");
                return false;
            }

            foreach (Positions n in positionsArray)
            {
                if (n.getID() == e.getID())
                {
                    positionsArray.Remove(n);
                    if (!posTable.Delete(e))
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
        /// Проверка дали записът съществува в масива
        /// </summary>
        /// <param name="s">Записът, който търсим</param>
        /// <returns>Връща true ако записът съществува </returns>
        private bool checkIfInside(Positions e)
        {
            foreach (Positions n in positionsArray)
            {
                if (n.getID() == e.getID())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Проверява дали има дублиращ запис
        /// </summary>
        /// <param name="e">Записът, който проверяваме</param>
        /// <returns>Връща true ако записът не се дублира</returns>
        private bool checkDuplicateRecord(Positions e)
        {
            foreach (Positions n in positionsArray)
            {
                if (n.getID() == e.getID())
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Добавяне на нов запис в буферния масив
        /// </summary>
        /// <param name="e">Записът, който добавяме</param>
        private void addNewRecord(Positions e)
        {
            positionsArray.Add(e);
        }

    }
}
