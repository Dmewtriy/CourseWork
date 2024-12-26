using CourseWork1.DTOs;
using System.Collections.Generic;

namespace CourseWork1.Presenters.interfaces
{
    public interface ITripPresenter
    {
        void AddTrip(TripDTO Trip);
        void DeleteTrip(TripDTO Trip);
        void UpdateTrip(TripDTO Trip);
        IEnumerable<TripDTO> GetTrips();
        void GetTripById(long id);
        void GetTourists(TripDTO Trip);
        void PayPenalty(TripDTO Trip);
    }
}
