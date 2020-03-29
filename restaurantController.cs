using Microsoft.AspNetCore.Mvc;
using EksamenApi.Models;

namespace EksamenApi.Controllers{

    public class restaurantController : ControllerBase {
        private readonly restaurantContext _context;

        public restaurantController(restaurantContext context){
            _context = context;
        }
    }
}