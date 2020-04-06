using Microsoft.AspNetCore.Mvc;
using EksamenApi.Models;

namespace EksamenApi.Controllers{

    public class foodController : ControllerBase {
        private readonly restaurantContext _context;

        public foodController(restaurantContext context){
            _context = context;
        }
    }
}