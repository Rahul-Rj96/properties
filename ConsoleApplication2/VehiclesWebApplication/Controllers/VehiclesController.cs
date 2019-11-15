using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using Vehicle.Models;

namespace VehiclesWebApplication.Controllers
{
    [RoutePrefix("api/vehicle")]
    [EnableCors(origins: "*", headers:"*", methods: "*")]
    public class VehiclesController : ApiController
    {
        
        [HttpGet, Route("car")]
        public IEnumerable<Car> GetCarView()
        {
            List<Car> carsViewList =Connection.ConnectionForReadingCar();
            return carsViewList;

        }

        [HttpGet, Route("car/{id}")]
        public Car GetCarViewId(int id)
        {
            return Connection.ConnectionForReadingCarId(id);
        }

        [HttpGet, Route("bike/{id}")]
        public Bike GetBikeViewId(int id)
        {           
            return Connection.ConnectionForReadingBikeId(id);          
        }

        [HttpGet, Route("bike")]
        public IEnumerable<Bike> GetBikeView()
        {
            List<Bike> bikesViewList = new List<Bike>();
            bikesViewList=(Connection.ConnectionForReadingBike());
            return bikesViewList;
        }

        [HttpPost, Route("car")]
        public IHttpActionResult PostWriteCar(Car car)
        {
            Connection.WriteDataTable(car);
            return Ok("Successfully entered to db");
        }

        [HttpPost, Route("bike")]
        public IHttpActionResult PostWriteBike(Bike bike)
        {
            Connection.WriteDataTable(bike);
            return Ok("Successfully entered to db");
        }
    }
}

