using System.Collections.Generic;

namespace CourseWork1.Services.interfaces
{
    public interface ITripService
    {
        void RegisterTrip(ITrip Trip);
        bool DeleteTrip(ITrip Trip);
        void EditTrip(ITrip Trip);
        ITrip GetTripById(long id);
        IEnumerable<ITrip> GetAllTrips();
    }
}
