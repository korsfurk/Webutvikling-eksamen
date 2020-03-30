using Microsoft.AspNetCore.Mvc;
using EksamenApi.Models;

namespace EksamenApi.Controllers{

    public class kundeController : ControllerBase {
        private readonly restaurantContext _context;

        public kundeController(restaurantContext context){
            _context = context;
        }
    }
}