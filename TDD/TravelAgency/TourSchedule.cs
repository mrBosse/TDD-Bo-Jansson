﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelAgency
{
    public class TourSchedule
    {
            private List<Tour> listOfTours;
            public TourSchedule()
        {
            listOfTours = new List<Tour>();
        }


        public void CreateTour(string nameoftour, DateTime dateTime, int numberofseats)
        {
            var result = listOfTours.Count(x => x.DateOfTour.Date == dateTime.Date);
            var hasConflictingTour = listOfTours.Any(x => x.NameOfTour == nameoftour && x.DateOfTour.Date == dateTime.Date);

            if (result >= 3)
            {
                throw new TourAllocationException(dateTime.AddDays(1).Date);
            }
            if (hasConflictingTour)
            {
                throw new SameNameSameDateException();
            }
            if (numberofseats < 1)
            {
                throw new NegativeSeatException();
            }
            listOfTours.Add(new Tour { NameOfTour = nameoftour, DateOfTour = dateTime.Date, NumberOfSeats = numberofseats });
        }

        public List<Tour> GetToursFor(DateTime timeTour)
        {
            return listOfTours.Where(x => x.DateOfTour.Date == timeTour.Date).ToList();
        }
    }
}