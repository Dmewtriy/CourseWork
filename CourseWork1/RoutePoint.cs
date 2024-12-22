using System;
using System.Collections.Generic;

namespace CourseWork1
{
    public class RoutePoint : IRoutePoint
    {
        private int id;
        private string name;
        private int stayDuration; // В днях
        private string hotelName;
        private int hotelClass;
        private List<IExcursion> excursions;

        public RoutePoint(int id, string name, int stayDuration, string hotelName, int hotelClass, List<IExcursion> excursions)
        {
            Id = id;
            Name = name;
            StayDuration = stayDuration;
            HotelName = hotelName;
            HotelClass = hotelClass;
            Excursions = excursions;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {StayDuration} {HotelName} {HotelClass}";
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
                    throw new ArgumentException("Неверное название пункта маршрута");
                }
            }
            get
            {
                return name;
            }
        }

        public int StayDuration
        {
            set
            {
                if (value > 0)
                {
                    stayDuration = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Неверное значение срока пребывания в пункте");
                }
            }
            get
            {
                return stayDuration;
            }
        }

        public string HotelName
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    hotelName = value;
                }
                else
                {
                    throw new ArgumentException("Неверное название отеля");
                }
            }
            get
            {
                return hotelName;
            }
        }

        public int HotelClass
        {
            set
            {
                if (value > 0 && value < 6)
                {
                    hotelClass = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Неверное значение класса отеля");
                }
            }
            get
            {
                return hotelClass;
            }
        }

        public List<IExcursion> Excursions
        {
            set
            {
                if (value != null)
                {
                    excursions = value;
                }
                else
                {
                    throw new ArgumentException("Неверный список экскурсий");
                }
            }
            get
            {
                return excursions;
            }
        }
    }
}
