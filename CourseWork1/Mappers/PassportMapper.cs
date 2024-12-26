using CourseWork1.DTOs;

namespace CourseWork1.Mappers
{
    public static class PassportMapper
    {
        public static PassportDTO ToDTO(IPassport passport)
        {
            return new PassportDTO()
            {
                Series = passport.Series,
                Number = passport.Number,
                IssuedDate = passport.IssuedDate,
                IssuedBy = passport.IssuedBy,
            };
        }
        public static IPassport ToEntity(PassportDTO passport)
        {
            return new RUPassport(passport.Series, passport.Number, passport.IssuedDate,
                passport.IssuedBy);
        }
    }
}
