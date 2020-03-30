using Microsoft.AspNetCore.Mvc;
using EksamenApi.Models;

namespace EksamenApi.Controllers{

    public class menuController : ControllerBase {
        private readonly restaurantContext _context;

        public menuController(restaurantContext context){
            _context = context;
        }
    }
}