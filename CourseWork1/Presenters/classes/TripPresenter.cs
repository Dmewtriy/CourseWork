using CourseWork1.DTOs;
using CourseWork1.Mappers;
using CourseWork1.Presenters.interfaces;
using CourseWork1.Services;
using CourseWork1.Services.interfaces;
using CourseWork1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Presenters.classes
{
    public class TripPresenter : ITripPresenter
    {
        private readonly ITripService service;
        private readonly ITripView view;

        public TripPresenter(ITripService service, ITripView view)
        {
            this.service = service;
            this.view = view;
            view.TripAdded += (sender, Trip) => AddTrip(Trip);
            view.TripUpdated += (sender, Trip) => UpdateTrip(Trip);
            view.TripDeleted += (sender, Trip) => DeleteTrip(Trip);
            view.LoadTripsRequested += (sender, e) => LoadTrips();
            view.TripSearchRequested += (sender, id) => GetTripById(id);
            view.TripSelected += (sender, Trip) => GetTourists(Trip);
        }

        public void AddTrip(TripDTO Trip)
        {
            service.RegisterTrip(TripMapper.ToEntity(Trip));
            view.UpdateTripsList(GetTrips());
        }

        public void DeleteTrip(TripDTO Trip)
        {
            bool result = service.DeleteTrip(TripMapper.ToEntity(Trip));
            if (result)
            {
                view.UpdateTripsList(GetTrips());
            }
            else
            {
                view.ShowErrorMessage("Что-то пошло не так при удалении клиента. Попробуйте еще раз");
            }
        }

        public void GetTripById(long id)
        {
            try
            {
                TripDTO Trip = TripMapper.ToDTO(service.GetTripById(id));
                view.UpdateTripsList(GetTrips());
                view.HighlightTrip(Trip);
            }
            catch (Exception ex)
            {
                view.ShowErrorMessage(ex.Message);
            }
        }

        public IEnumerable<TripDTO> GetTrips()
        {
            var Trips = service.GetAllTrips();
            var TripsDTO = new List<TripDTO>();
            foreach (var Trip in Trips)
            {
                TripsDTO.Add(TripMapper.ToDTO(Trip));
            }
            return TripsDTO;
        }

        private void LoadTrips()
        {
            view.UpdateTripsList(GetTrips());
        }

        public void UpdateTrip(TripDTO Trip)
        {
            service.EditTrip(TripMapper.ToEntity(Trip));
            view.UpdateTripsList(GetTrips());
            view.HighlightTrip(Trip);
        }

        public void GetTourists(TripDTO Trip)
        {
            var tourists = TripMapper.ToDTO(service.GetTripById(Trip.Id)).Tourists;
            view.ShowTourists(tourists);
        }

        public void PayPenalty(TripDTO Trip)
        {
            /* умная логика оплаты*/
            view.PenaltyHighlightTrip(Trip);
        }
    }
}
