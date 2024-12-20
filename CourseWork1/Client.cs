using System;
using System.IO;

namespace CourseWork1
{
    public class Client : Person, IClient
    {
        private DateTime dateOfBirth;
        private IPassport passportData;
        private string pathToPhoto;

        public Client(string firstName, string lastName, string patronymic, DateTime dateOfBirth, IPassport passportData, string pathToPhoto) :
            base(firstName, lastName, patronymic)
        {
            DateOfBirth = dateOfBirth;
            PassportData = passportData;
            PathToPhoto = pathToPhoto;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {DateOfBirth} {PassportData.Series} {PassportData.Number}";
        }

        public DateTime DateOfBirth
        {
            set
            {
                if (DateTime.Compare(value, new DateTime(1900,1,1)) > 0)
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
