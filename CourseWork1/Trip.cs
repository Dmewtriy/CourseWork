using System;
using System.Collections.Generic;
using CourseWork1;

namespace CourseWork
{
    public class Trip : ITrip
    {
        private int id;
        private string routeName;
        private ICompanyRepresentative representative;
        private int price;
        private DateTime startDate;
        private DateTime endDate;
        private int touristNumber;
        private List<IClient> tourists;
        private int penalty;

        public override string ToString()
        {
            return $"{routeName} {representative.GetName()} {price} {startDate} {endDate} {touristNumber} {penalty}";
        }

        public Trip(int id, string routeName, ICompanyRepresentative representative, int price, DateTime startDate, DateTime endDate, int touristNumber, List<IClient> tourists, int penalty)
        {
            Id = id;
            RouteName = routeName;
            Representative = representative;
            Price = price;
            StartDate = startDate;
            EndDate = endDate;
            TouristNumber = touristNumber;
            Tourists = tourists;
            Penalty = penalty;
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

        public string RouteName
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    routeName = value;
                }
                else
                {
                    throw new ArgumentException("Неверное название маршрута");
                }
            }
            get
            {
                return routeName;
            }
        }

        public ICompanyRepresentative Representative
        {
            set
            {
                if (value != null)
                {
                    representative = value;
                }
                else
                {
                    throw new ArgumentException("Неверный представитель компании");
                }
            }
            get
            {
                return representative;
            }
        }

        public int Price
        {
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("Неверная цена поездки");
                }
            }
            get
            {
                return price;
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

        public int TouristNumber
        {
            set
            {
                if (value > 0)
                {
                    touristNumber = value;
                }
                else
                {
                    throw new ArgumentException("Неверное количество туристов");
                }
            }
            get
            {
                return touristNumber;
            }
        }

        public List<IClient> Tourists
        {
            set
            {
                if (value != null)
                {
                    tourists = value;
                }
                else
                {
                    throw new ArgumentException("Неверный список клиентов");
                }
            }
            get
            {
                return tourists;
            }
        }

        public int Penalty
        {
            set
            {
                if (value > 0)
                {
                    penalty = value;
                }
                else
                {
                    throw new ArgumentException("Неверное значение неустойки");
                }
            }
            get
            {
                return penalty;
            }
        }
    }
}
