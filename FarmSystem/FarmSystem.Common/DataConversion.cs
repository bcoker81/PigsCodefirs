using FarmSystem.Domain;
using FarmSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Common
{
    public class DataConversion
    {
        public static AnimalDto ReturnDto(Animal animal)
        {
            return new AnimalDto
            {
                AnimalId = animal.AnimalId,
                AnimalType = animal.AnimalType,
                Breed = animal.Breed,
                DateAcquired = animal.DateAcquired,
                Dob = animal.Dob,
                Name = animal.Name,
                TagNumber = animal.TagNumber
            };
        }
    }
}
