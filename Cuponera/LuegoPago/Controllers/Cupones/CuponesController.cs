using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuegoPago.Services;
using LuegoPago.Models;

namespace LuegoPago.Controllers.Cupones
{
    public class CuponesController : ControllerBase
    {
        private readonly ICuponRepository _CuponRepository;
        public CuponesController(ICuponRepository cuponRepository)
        {
            _CuponRepository = cuponRepository;
        }
        [HttpGet]
        [Route("api/cupones")]
        public IEnumerable<Cupon> GetUsers()
        {
            return _CuponRepository.GetAll();
        }
        [HttpGet]
        [Route("api/cupones/{id}")]
        public Cupon Details(int id)
        {
            return _CuponRepository.GetById(id);
        }


    }
}