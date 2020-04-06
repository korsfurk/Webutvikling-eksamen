using Microsoft.AspNetCore.Mvc;
using EksamenApi.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace EksamenApi.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class drinkController : ControllerBase {
        private readonly restaurantContext _context;
        private readonly IWebHostEnvironment _hosting;

        public drinkController(restaurantContext context, IWebHostEnvironment hosting){
            _context = context;
            _hosting = hosting;
        }

        [HttpGet]
        public async Task<IEnumerable<drink>> Get(){
            List<drink> drinkList = await _context.Drink.ToListAsync();
            return drinkList;
        }
    }
}