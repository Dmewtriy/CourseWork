﻿using System;

namespace CourseWork1
{
    public class CompanyRepresentative : ICompanyRepresentative
    {
        private long id;
        private string firstName;
        private string lastName;
        private string patronymic;
        private string number;
        private string email;

        public CompanyRepresentative(long id, string firstName, string lastName, string patronymic, string number, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Number = number;
            Email = email;
        }


        public override string ToString()
        {
            return $"{Id} {LastName} {FirstName} {Patronymic} {number} {email}";
        }

        public string GetName()
        {
            return $"{LastName} {FirstName} {Patronymic}";
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
                    throw new ArgumentException("Неверное имя");
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
                    throw new ArgumentException("Неверная фамилия");
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
                    throw new ArgumentException("Неверное отчество");
                }
            }
            get
            {
                return patronymic;
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

        public override bool Equals(object obj)
        {
            if (obj is CompanyRepresentative compRep)
            {
                return compRep.Id == Id;
            }
            return false;
        }

    }
}
