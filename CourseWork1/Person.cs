using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string patronymic;

        public Person(string firstName, string lastName, string patronymic)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
        }

        public string FirstName
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    firstName = value;
                }
                else
                {
                    throw new Exception("Неверное имя");
                }
            }
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    lastName = value;
                }
                else
                {
                    throw new Exception("Неверная фамилия");
                }
            }
            get
            {
                return lastName;
            }
        }

        public string Patronymic
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    patronymic = value;
                }
                else
                {
                    throw new Exception("Неверное отчество");
                }
            }
            get
            {
                return patronymic;
            }
        }

    }
}
