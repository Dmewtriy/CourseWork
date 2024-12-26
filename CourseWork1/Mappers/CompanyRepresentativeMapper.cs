using CourseWork1.DTOs;

namespace CourseWork1.Mappers
{
    public static class CompanyRepresentativeMapper
    {
        public static CompanyRepresentativeDTO ToDTO(ICompanyRepresentative cR)
        {
            return new CompanyRepresentativeDTO()
            {
                FirstName = cR.FirstName,
                LastName = cR.LastName,
                Patronymic = cR.Patronymic,
                Id = cR.Id,
                Number = cR.Number,
                Email = cR.Email,
            };
        }
        public static ICompanyRepresentative ToEntity(CompanyRepresentativeDTO cR)
        {
            return new CompanyRepresentative(cR.Id, cR.FirstName, cR.LastName, cR.Patronymic, cR.Number, cR.Email);
        }
    }
}
