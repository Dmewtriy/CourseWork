using System;
using System.IO;

namespace CourseWork1
{
    public class Client : Person, IClient
    {
        private int id;
        private DateTime dateOfBirth;
        private IPassport passportData;
        private string pathToPhoto;

        public Client(int id, string firstName, string lastName, string patronymic, DateTime dateOfBirth, IPassport passportData, string pathToPhoto) :
            base(firstName, lastName, patronymic)
        {
            Id = id;
            DateOfBirth = dateOfBirth;
            PassportData = passportData;
            PathToPhoto = pathToPhoto;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {DateOfBirth} {PassportData.Series} {PassportData.Number}";
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
