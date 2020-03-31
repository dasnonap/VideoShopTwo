using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.Classes;
using VideoShop.TableClasses;
using System.Windows.Forms;

namespace VideoShop.BufferClasses
{
    class SeriesBuffer
    {
        private TableTemplate<Series> seriesTable = new TableTemplate<Series>();
        private List<Object> seriesArray = new List<Object>();

        public SeriesBuffer()
        {

        }

        public Series returnSeriesByID(int id)
        {
            foreach (Series i in seriesArray)
            {
                if (i.getSeriesID() == id)
                {
                    return i;
                }
            }
            return null;
        }

        /// <summary>
        /// Функция за връщане на пълният масив
        /// </summary>
        /// <returns>Връща масив от обекти</returns>
        public List<Object> returnRecords()
        {
            return seriesArray;
        }

        /// <summary>
        /// Взима данните от базата данни и ги записва в буферния масив
        /// </summary>
        /// <returns>Връща true ако всички данни са добавени успешно</returns>
        public bool initializeSeriesArray()
        {
            if (!seriesTable.Select("SERIES", seriesArray))
            {
                MessageBox.Show("Неуспешно зареждане на данните");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Функция за добавяне на запис 
        /// </summary>
        /// <param name="s">Записът, който ще добавяме</param>
        /// <returns>Връща true ако записът е добавен успешно</returns>
        public bool insertRow(Series s)
        {
            if (!checkDuplicateRecord(s))
            {
                MessageBox.Show("Този град вече съществува.");
                return false;
            }

            if (!seriesTable.Insert("SERIES", s))
            {
                MessageBox.Show("Неуспешен опит за извършване на операцията. ");
                return false;
            }

            addNewRecord(s);
            return true;
        }

        /// <summary>
        /// Функция за промяна на запис
        /// </summary>
        /// <param name="s">Вече промененият запис</param>
        /// <returns>Връща true ако промяната е станала успешно</returns>
        public bool changeRow(Series s)
        {
            if (!checkIfInside(s))
            {
                MessageBox.Show("Не можe");
                return false;
            }

            foreach (Series n in seriesArray)
            {
                if (n.getSeriesID() == s.getSeriesID())
                {
                    n.setSettings(s);
                    if (!seriesTable.Update("SERIES", n))
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
        /// Премахване на запис
        /// </summary>
        /// <param name="s">Записът, който ще премахваме</param>
        /// <returns>Връща true ако премахването е успешно</returns>
        public bool removeRecord(Series s)
        {

            if (!checkIfInside(s))
            {
                MessageBox.Show("Не можe");
                return false;
            }

            foreach (Series n in seriesArray)
            {
                if (n.getName() == s.getName())
                {
                    s.setSeriesID(n.getSeriesID());
                    seriesArray.Remove(n);
                    if (!seriesTable.Delete(s))
                    {
                        MessageBox.Show("no");
                        return false;
                    }

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
        private bool checkIfInside(Series s)
        {
            foreach (Series n in seriesArray)
            {
                if (n.getSeriesID() == s.getSeriesID())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Проверява дали има дублиращ запис
        /// </summary>
        /// <param name="s">Записът, който проверяваме</param>
        /// <returns>Връща true ако записът не се дублира</returns>
        private bool checkDuplicateRecord(Series s)
        {
            foreach (Series n in seriesArray)
            {
                if (n.getName() == s.getName())
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Добавяне на нов запис в буферния масив
        /// </summary>
        /// <param name="s">Записът, който добавяме</param>
        private void addNewRecord(Series s)
        {
            seriesArray.Add(s);
        }
    }
}
