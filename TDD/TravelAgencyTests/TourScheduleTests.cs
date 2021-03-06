﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    [TestFixture]
    public class TourScheduleTests
    {
        private TourSchedule sut;
        [SetUp]
        public void Setup()
        {
            sut = new TourSchedule();
        }
        [Test]
        public void CanCreateNewTour()
        {
            //act part
            //var sut = new TourSchedule();
            sut.CreateTour(
            "New years day safari",
            new DateTime(2013, 1, 1), 20);
            var result = sut.GetToursFor(new DateTime(2013, 1, 1));

            //assert
            Assert.AreEqual(1, result.Count);
        }
        [Test]
        public void ToursAreScheduledByDateOnly()
        {
            //var sut = new TourSchedule();
            //Act
            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);
            var result = sut.GetToursFor(new DateTime(2013, 1, 1));

            //Assert
            Assert.AreEqual(new DateTime(2013, 1, 1), result[0].DateOfTour.Date);
        }
        [Test]
        public void GetToursForGivenDayOnly()
        {
            //Act
            sut.CreateTour("New Year's Day Safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("Christmas Day Safari", new DateTime(2013, 5, 1, 10, 15, 0), 20);
            sut.CreateTour("Boxing Day Safari", new DateTime(2013, 7, 1, 10, 15, 0), 20);
            sut.CreateTour("Three Kings Day Safari", new DateTime(2013, 4, 1, 10, 15, 0), 20);

            var result = sut.GetToursFor(new DateTime(2013, 4, 1));

            //Assert
            Assert.AreEqual(new DateTime(2013, 4, 1), result[0].DateOfTour.Date);
            Assert.AreEqual(1, result.Count);
        }
        [Test]
        public void ThrowsExceptionWhenThereIsMoreThanOneTourPerDay()
        {
            sut.CreateTour("Holiday Safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("Christmas Safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("Winter safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);

            Assert.Throws<TourAllocationException>(() => sut.CreateTour("Holiday Safari", new DateTime(2013, 1, 1, 10, 15, 0), 20));
        }

    }
}
