using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuegoPago.Models;
using LuegoPago.Services;
namespace LuegoPago.Controllers.Cupones
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CuponUpdateController : ControllerBase
    {
        private readonly ICuponRepository _cuponRepository;
        public CuponUpdateController(ICuponRepository cuponRepository)
        {
            _cuponRepository = cuponRepository;
        }
        [HttpPut("{id}")]
        // [Route("api/cupones/{id}/update")]
        public string Update(int id, [FromBody] Cupon cupon)
        {
            var cuponExistente = _cuponRepository.GetById(id);
            cuponExistente.Id = cupon.Id;
            cuponExistente.Nombre = cuponExistente.Nombre;
            cuponExistente.Descripcion = cuponExistente.Descripcion;
            cuponExistente.FechaInicio = cuponExistente.FechaInicio;
            cuponExistente.FechaFin = cuponExistente.FechaFin;
            cuponExistente.ValorDescuento = cuponExistente.ValorDescuento;
            cuponExistente.Usabilidad = cuponExistente.Usabilidad;
            cuponExistente.Estado = cuponExistente.Estado;

            _cuponRepository.Update(cuponExistente);
            return "Cupon actualizado";
        }

    }
}