using FarmSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Contract
{
    public interface IRepository
    {
        void Add(Animal animal);
        IEnumerable<Animal> GetAll();
        Animal GetbyId(int id);
        void Delete(int id);
        void Delete(Animal animal);
    }
}
