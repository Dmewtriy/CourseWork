using CourseWork1.DTOs;
using System;
using System.Collections.Generic;

namespace CourseWork1.Views
{
    public interface ITripsView
    {
        event EventHandler<TripDTO> TripAdded;
        event EventHandler<TripDTO> TripUpdated;
        event EventHandler<TripDTO> TripDeleted;
        event EventHandler LoadTripsRequested;
        event EventHandler<long> TripSearchRequested;
        event EventHandler<TripDTO> TripSelected;
        event EventHandler<TripDTO> PenaltyPaid;

        void ShowErrorMessage(string message);
        void UpdateTripsList(IEnumerable<TripDTO> Trips);
        void HighlightTrip(TripDTO Trip);
        void ShowTourists(IEnumerable<ClientDTO> tourists);
        void PenaltyHighlightTrip(TripDTO Trip);
    }
}
