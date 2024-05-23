using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuegoPago.Models;

namespace LuegoPago.Services
{
    public interface ICuponRepository
    {
        // Estos son las funciones que voy a utilizar aqui se mapean
        IEnumerable<Cupon> GetAll(); // Select * from users
        Cupon GetById(int id); // Select * from users where id = ?
        void add(Cupon cupon); // Insert into users ()values()
        void remove(int id); // Delete from users where id = ?
        void update(Cupon cupon); // update set Name='' , LastName='' from user where id = ?
    }
}