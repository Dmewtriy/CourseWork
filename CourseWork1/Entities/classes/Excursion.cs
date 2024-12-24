using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1
{
    public class Excursion : IExcursion
    {
        private int id;
        private string name;
        private string description;
        private DateTime startDate;
        private DateTime endDate;

        public Excursion(int id, string name, string description, DateTime startDate, DateTime endDate)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 0)
                {
                    id = value;
                }
                else
                {
                    throw new Exception("Неверный id");
                }

            }
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
                if (value != null)
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
                if (value != null && DateTime.Compare(value, StartDate) > 0)
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

        public override bool Equals(object obj)
        {
            if (obj is Excursion exc)
            {
                return exc.Id == Id;
            }
            return false;
        }
    }
}