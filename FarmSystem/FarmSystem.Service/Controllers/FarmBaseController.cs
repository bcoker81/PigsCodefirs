using FarmSystem.Contract;
using FarmSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FarmSystem.Service.Controllers
{
    public class FarmBaseController : ApiController
    {
        public static readonly IRepository _repo = new FarmRepository();
    }
}
