using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyTests
{
    [TestFixture]
    public class TourScheduleTests
    {
        [Test]
        public void CanCreateNewTour()
        {
            //arr part
            var sut = new TourSchedule();
            sut.CreateTour(
            "New years day safari",
            new DateTime(2013, 1, 1), 20);


        }
    }
}
