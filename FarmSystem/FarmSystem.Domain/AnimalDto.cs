using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Domain
{
    public class AnimalDto
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string TagNumber { get; set; }
        public string Breed { get; set; }
        public string AnimalType { get; set; }
        public DateTime Dob { get; set; }
        public DateTime DateAcquired { get; set; }
    }
}
