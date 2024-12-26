using CourseWork1.DTOs;

namespace CourseWork1.Mappers
{
    public static class ExcursionMapper
    {
        public static ExcursionDTO ToDTO(IExcursion Excursion)
        {
            return new ExcursionDTO()
            {
                Id = Excursion.Id,
                Name = Excursion.Name,
                Description = Excursion.Description,
            };
        }
        public static IExcursion ToEntity(ExcursionDTO Excursion)
        {
            return new Excursion(Excursion.Id, Excursion.Name, Excursion.Description);
        }
    }
}
