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
            List<ClientDTO> tourists = new List<ClientDTO>();
            foreach(IClient client in Trip.Tourists)
            {
                tourists.Add(ClientMapper.ToDTO(client));
            }
            return new TripDTO()
            {
                Id = Trip.Id,
                RouteName = Trip.RouteName,
                Representative = CompanyRepresentativeMapper.ToDTO(Trip.Representative),
                Price = Trip.Price,
                StartDate = Trip.StartDate,
                EndDate = Trip.EndDate,
                TouristNumber = Trip.TouristNumber,
                Tourists = tourists,
                Penalty = Trip.Penalty,
            };
        }
        public static ITrip ToEntity(TripDTO trip)
        {
            List<IClient> tourists = new List<IClient>();
            foreach (ClientDTO client in trip.Tourists)
            {
                tourists.Add(ClientMapper.ToEntity(client));
            }
            return new Trip(trip.Id, trip.RouteName, CompanyRepresentativeMapper.ToEntity(trip.Representative), 
                trip.Price, trip.StartDate, trip.EndDate, trip.TouristNumber, tourists, trip.Penalty);
        }
    }
}
