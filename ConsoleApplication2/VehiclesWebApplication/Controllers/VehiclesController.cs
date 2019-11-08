using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ConsoleApplication2;
using System.Web.Http.Cors;
using Newtonsoft.Json;

namespace VehiclesWebApplication.Controllers
{
    [RoutePrefix("api/vehicle")]
    [EnableCors(origins: "*", headers:"*", methods: "*")]
    public class VehiclesController : ApiController
    {
        
        [HttpGet, Route("car")]
        public IEnumerable<Car> GetCarView()
        {
            Vehicle.carsViewList.Clear();
            Vehicle.carsViewList.AddRange(Connection.ConnectionForReadingCar());
            return Vehicle.carsViewList;

        }
        [HttpGet, Route("bike")]
        public IEnumerable<Bike> GetBikeView()
        {
            Vehicle.bikesViewList.Clear();
            Vehicle.bikesViewList.AddRange(Connection.ConnectionForReadingBike());
            return Vehicle.bikesViewList;
        }
        [HttpPost, Route("car")]
        public void PostWriteCar(Car car)
        {
            Connection.GetDataTable(car);
        }
        [HttpPost, Route("bike")]
        public void PostWriteBike(Bike bike)
        {
            Connection.GetDataTable(bike);
        }
    }
}
