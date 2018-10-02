using FarmSystem.Common;
using FarmSystem.Domain;
using FarmSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FarmSystem.Service.Controllers
{
    public class FarmController : FarmBaseController
    {
        public IEnumerable<AnimalDto> Get()
        {
            List<AnimalDto> animalList = new List<AnimalDto>();
            var result = _repo.GetAll();

            foreach (var animal in result)
            {
                animalList.Add(DataConversion.ReturnDto(animal));
            }

  
            return animalList;
        }
    }
}
