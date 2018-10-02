using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Entities
{
    [Table("Animals")]
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string TagNumber { get; set; }
        public string Breed { get; set; }
        public string AnimalType { get; set; }
        public DateTime Dob { get; set; }
        public DateTime DateAcquired { get; set; }
    }
}
