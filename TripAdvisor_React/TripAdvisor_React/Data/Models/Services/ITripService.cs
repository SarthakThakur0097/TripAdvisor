using System.Collections.Generic;
using TripAdvisor_React.Data.Models;

namespace TripAdvisor_React.Data
{
    public interface ITripService{
        List<Trip> GetAllTrips();
        Trip GetTripById(int tripId);
        void UpdateTrip(int tripId, Trip trip);
        void DeleteTrip(int tripId);
        void AddTrip(Trip trip);
    }
}