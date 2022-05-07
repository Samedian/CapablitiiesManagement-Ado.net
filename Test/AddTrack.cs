using Autofac.Extras.Moq;
using DataAccessLayer;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Test
{
    [TestClass]
    public class AddTrack
    {
        [TestMethod]
        public void TestMethod1()
        {
            TrackDataAccessLayer trackDataAccessLayer = new TrackDataAccessLayer();
            using(var mock = AutoMock.GetLoose())
            {
                var track = new Track(9,"ABC");
                //var result = mock.Create<Track>();
                string query = "INSERT INTO Track Values (" + track.TrackId + ",'" + track.TrackName + "');";

                mock.Mock<TrackDataAccessLayer>().Setup(AddTrackToDataBase(track));
                var data = mock.Create<Track>();

               // mock.Mock<TrackDataAccessLayer>().Verify(x => x.AddTrackToDataBase(track), Times.Exactly(1));
            };
        }
    }
}
