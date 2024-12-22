using System;
using System.IO;

namespace CourseWork1
{
    public class Client : IClient
    {
        private int id;
        private string firstName;
        private string lastName;
        private string patronymic;
        private DateTime dateOfBirth;
        private IPassport passportData;
        private string pathToPhoto;

        public Client(int id, string firstName, string lastName, string patronymic, DateTime dateOfBirth, IPassport passportData, string pathToPhoto)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            PassportData = passportData;
            PathToPhoto = pathToPhoto;
        }

        public override string ToString()
        {
            return $"{Id} {LastName} {FirstName} {Patronymic} {DateOfBirth.ToShortDateString()} {PassportData.Series} {PassportData.Number}";
        }

        public string GetName()
        {
            return $"{LastName} {FirstName} {Patronymic}";
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

        public DateTime DateOfBirth
        {
            set
            {
                if (value != null)
                {
                    dateOfBirth = value;
                }
                else
                {
                    throw new ArgumentException("Неверная дата рождения");
                }
            }
            get
            {
                return dateOfBirth;
            }
        }

        public IPassport PassportData
        {
            set
            {
                if (value != null)
                {
                    passportData = value;
                }
                else
                {
                    throw new ArgumentException("Неверные данные паспорта");
                }
            }
            get
            {
                return passportData;
            }
        }

        public string PathToPhoto
        {
            set
            {
                if (File.Exists(value))
                {
                    pathToPhoto = value;
                }
                else
                {
                    throw new ArgumentException("Такого файла не существует");
                }
            }
            get
            {
                return pathToPhoto;
            }
        }

    }
}
