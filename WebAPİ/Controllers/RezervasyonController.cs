using Business.Abstract;
using Core.Utilities;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPİ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervasyonController : ControllerBase
    {
        [HttpPost("hey")]
        public string Get(string x)
        {
            return x;
        }
        IRezervasyonService _rezervasyonService;
        public RezervasyonController(IRezervasyonService rezervsayonService)
        {
            _rezervasyonService = rezervsayonService;


        }


        [HttpPost("istek")]
        public void add(Rezervasyon rezervasyon)
        {

            _rezervasyonService.add(rezervasyon);

        }
    }
}
