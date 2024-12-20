using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CourseWork1
{
    public class CompanyRepresentative : Person, ICompanyRepresentative
    {
        private string number;
        private string email;

        public CompanyRepresentative(string firstName, string lastName, string patronymic, string number, string email) : base(firstName, lastName, patronymic)
        {
            Number = number;
            Email = email;
        }


        public override string ToString()
        {
            return $"{base.ToString()} {number} {email}";
        }

        public string Number
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    if(value.Length == 12 && value.StartsWith("+7") || value.Length == 11 && value[0] == '8')
                    {
                        number = value;
                    }
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
                if(IsValidEmail(value))
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

        private static bool IsValidEmail(string email) 
        {
            if (string.IsNullOrWhiteSpace(email) && string.IsNullOrEmpty(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
