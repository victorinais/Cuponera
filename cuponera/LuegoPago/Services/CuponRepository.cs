using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuegoPago.Data;
using LuegoPago.Models;
using Microsoft.EntityFrameworkCore;

namespace LuegoPago.Services
{
    public class CuponRepository : ICuponRepository
    {
        private readonly CuponDbContext _context;
        public CuponRepository(CuponDbContext context)
        {
            _context = context;
        }
        public void add(Cupon cupon)
        {
            _context.Cupones.Add(cupon);
            _context.SaveChanges();
        }

        public IEnumerable<Cupon> GetAll()
        {
            return _context.Cupones.ToList();
        }

        public Cupon GetById(int id)
        {
            return _context.Cupones.Find(id);
        }

        public void remove(int id)
        {
            var cupon = _context.Cupones.Find(id);
            _context.Cupones.Remove(cupon);
            _context.SaveChanges();
        }

        public void update(Cupon cupon)
        {
            _context.Cupones.Update(cupon);
            _context.SaveChanges();
        }

    }
}