using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1
{
    public class Excursion
    {
        private string name;
        private string description;
        private DateTime startDate;
        private DateTime endDate;

        public Excursion(string name, string description, DateTime startDate, DateTime endDate)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string Name
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Неверное название экскурсии");
                }
            }
            get
            {
                return name;
            }
        }

        public string Description
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
                else
                {
                    throw new ArgumentException("Неверное описание экскурсии");
                }
            }
            get
            {
                return description;
            }
        }

        public DateTime StartDate
        {
            set
            {
                if (DateTime.Compare(value, new DateTime(1900, 1, 1)) > 0)
                {
                    startDate = value;
                }
                else
                {
                    throw new ArgumentException("Неверная начальная дата");
                }
            }
            get
            {
                return startDate;
            }
        }

        public DateTime EndDate
        {
            set
            {
                if (DateTime.Compare(value, new DateTime(1900, 1, 1)) > 0 && DateTime.Compare(value, StartDate) > 0)
                {
                    endDate = value;
                }
                else
                {
                    throw new ArgumentException("Неверная конечная дата");
                }
            }
            get
            {
                return endDate;
            }
        }
    }
}