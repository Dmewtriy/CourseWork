using System;

namespace CourseWork1
{
    public class RUPassport : IPassport
    {
        private string series;
        private string number;
        private DateTime issuedDate;
        private string issuedBy;

        public RUPassport(string series, string number, DateTime issuedDate, string issuedBy)
        {
            Series = series;
            Number = number;
            IssuedDate = issuedDate;
            IssuedBy = issuedBy;
        }

        public override string ToString()
        {
            return $"{series} {number}";
        }

        public string Series
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 4)
                {
                    if (char.IsDigit(value[0]) && char.IsDigit(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]))
                    {
                        series = value;
                    }
                }
                else
                {
                    throw new Exception("Неверное значение серии паспорта");
                }
            }
            get
            {
                return series;
            }
        }

        public string Number
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 6)
                {
                    if (char.IsDigit(value[0]) && char.IsDigit(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]) && char.IsDigit(value[4]) && char.IsDigit(value[5]))
                    {
                        number = value;
                    }
                }
                else
                {
                    throw new Exception("Неверное значение номера паспорта");
                }
            }
            get
            {
                return number;
            }
        }

        public DateTime IssuedDate
        {
            set
            {
                if (DateTime.Compare(value, new DateTime(1900, 1, 1)) > 0)
                {
                    issuedDate = value;
                }
                else
                {
                    throw new Exception("Неверная дата выдачи паспорта");
                }
            }
            get
            {
                return issuedDate;
            }
        }

        public string IssuedBy
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    issuedBy = value;
                }
                else
                {
                    throw new Exception("Неверное значение того, кем выдан паспорт");
                }
            }
            get
            {
                return issuedBy;
            }
        }
    }
}