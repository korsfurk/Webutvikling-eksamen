using Microsoft.AspNetCore.Mvc;
using EksamenApi.Models;

namespace EksamenApi.Controllers{

    public class adminController : ControllerBase {
        private readonly restaurantContext _context;

        public adminController(restaurantContext context){
            _context = context;
        }
    }
}