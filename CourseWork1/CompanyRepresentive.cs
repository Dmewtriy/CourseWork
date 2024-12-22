using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CourseWork1
{
    public class CompanyRepresentative : Person, ICompanyRepresentative
    {
        private int id;
        private string number;
        private string email;

        public CompanyRepresentative(int id, string firstName, string lastName, string patronymic, string number, string email) : base(firstName, lastName, patronymic)
        {
            Id = id;
            Number = number;
            Email = email;
        }


        public override string ToString()
        {
            return $"{base.ToString()} {number} {email}";
        }

        public string GetName()
        {
            return base.ToString();
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

        public string Number
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    number = value;
                }
                else
                {
                    throw new ArgumentException("Неверный номер телефона");
                }
            }
            get
            {
                return number;
            }
        }

        public string Email
        {
            set
            {
                if(!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    email = value;
                }
                
                else
                {
                    throw new ArgumentException("Неверная почта");
                }
            }
            get
            {
                return email;
            }
        }

    }
}
