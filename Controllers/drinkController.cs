using Microsoft.AspNetCore.Mvc;
using EksamenApi.Models;

namespace EksamenApi.Controllers{

    public class drinkController : ControllerBase {
        private readonly restaurantContext _context;

        public drinkController(restaurantContext context){
            _context = context;
        }
    }
}