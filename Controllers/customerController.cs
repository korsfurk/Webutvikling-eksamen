using Microsoft.AspNetCore.Mvc;
using EksamenApi.Models;

namespace EksamenApi.Controllers{

    public class customerController : ControllerBase {
        private readonly restaurantContext _context;

        public customerController(restaurantContext context){
            _context = context;
        }
    }
}