using System;
using System.Collections.Generic;

namespace CourseWork1
{
    public class Route : IRoute
    {
        private int id;
        private string name;
        private string country;
        private int duration; // В днях
        private List<IRoutePoint> points;

        public Route(int id, string name, string country, int duration, List<IRoutePoint> points)
        {
            Id = id;
            Name = name;
            Country = country;
            Duration = duration;
            Points = points;
        }

        public override string ToString()
        {
            return $"{id} {name} {country} {duration}";
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
                    throw new ArgumentException("Неверное название поездки");
                }
            }
            get
            {
                return name;
            }
        }

        public string Country
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    country = value;
                }
                else
                {
                    throw new ArgumentException("Неверное название страны");
                }
            }
            get
            {
                return country;
            }
        }

        public int Duration
        {
            set
            {
                if (value > 0)
                {
                    duration = value;
                }
                else
                {
                    throw new ArgumentException("Неверная продолжительность поездки");
                }
            }
            get
            {
                return duration;
            }
        }

        public List<IRoutePoint> Points
        {
            set
            {
                if (value != null)
                {
                    points = value;
                }
                else
                {
                    throw new ArgumentException("Неверный список пунтков маршрута");
                }
            }
            get
            {
                return points;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Route route)
            {
                return route.Id == Id;
            }
            return false;
        }
    }
}
