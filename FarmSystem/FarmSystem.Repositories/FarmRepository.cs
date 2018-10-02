using FarmSystem.Contract;
using FarmSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Repositories
{
    public class FarmRepository : IRepository
    {
        private readonly FarmDbContext _context = new FarmDbContext();

        public void Add(Animal animal)
        {
            _context.Animals.Add(animal);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var result = _context.Animals.First(p => p.AnimalId == id);
            _context.Animals.Remove(result);
            _context.SaveChanges();
        }

        public void Delete(Animal animal)
        {
            _context.Animals.Remove(animal);
            _context.SaveChanges();
        }

        public IEnumerable<Animal> GetAll()
        {
           return _context.Animals.ToList();
        }

        public Animal GetbyId(int id)
        {
            return _context.Animals.First(p => p.AnimalId == id);
        }
    }
}
