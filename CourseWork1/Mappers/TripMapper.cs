using CourseWork;
using CourseWork1.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork1.Mappers
{
    public static class TripMapper
    {
        public static TripDTO ToDTO(ITrip Trip)
        {
            return new TripDTO()
            {
                Id = Trip.Id,
                RouteName = Trip.RouteName,
                Representative = CompanyRepresentativeMapper.ToDTO(Trip.Representative),
                Price = Trip.Price,
                StartDate = Trip.StartDate,
                EndDate = Trip.EndDate,
                TouristNumber = Trip.TouristNumber,
                Tourists = (List<ClientDTO>)Trip.Tourists.Select(t => ClientMapper.ToDTO(t)),
                Penalty = Trip.Penalty,
            };
        }
        public static ITrip ToEntity(TripDTO trip)
        {
            return new Trip(trip.Id, trip.RouteName, CompanyRepresentativeMapper.ToEntity(trip.Representative), 
                trip.Price, trip.StartDate, trip.EndDate,
                trip.TouristNumber, (List<IClient>)trip.Tourists.Select(t => ClientMapper.ToEntity(t)), 
                trip.Penalty);
        }
    }
}
