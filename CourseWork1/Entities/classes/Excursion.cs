using System;

namespace CourseWork1
{
    public class Excursion : IExcursion
    {
        private long id;
        private string name;
        private string description;

        public Excursion(long id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public long Id
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