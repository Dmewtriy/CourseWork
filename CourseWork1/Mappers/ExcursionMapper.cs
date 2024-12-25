﻿using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                StartDate = Excursion.StartDate,
                EndDate = Excursion.EndDate,
            };
        }
        public static IExcursion ToEntity(ExcursionDTO Excursion)
        {
            return new Excursion(Excursion.Id, Excursion.Name, Excursion.Description, Excursion.StartDate,
                Excursion.EndDate);
        }
    }
}