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
    public class adminController : ControllerBase {
        private readonly restaurantContext _context;
        private readonly IWebHostEnvironment _hosting;

        public adminController(restaurantContext context, IWebHostEnvironment hosting){
            _context = context;
            _hosting = hosting;
        }

        [HttpGet]
        public async Task<IEnumerable<admin>> GetAdmins(){
            List<admin> adminList = await _context.Admin.ToListAsync();
            return adminList;
        }

        [HttpGet]
        public async Task<IEnumerable<food>> GetFoods(){
            List<food> foodList = await _context.Food.ToListAsync();
            return foodList;
        }

        [HttpGet]
        public async Task<IEnumerable<drink>> GetDrinks(){
            List<drink> drinkList = await _context.Drink.ToListAsync();
            return drinkList;
        }

        [HttpGet]
        public async Task<IEnumerable<customer>> GetCustomers(){
            List<customer> customerList = await _context.Customer.ToListAsync();
            return customerList;
        }

        [HttpGet("{FoodId}")]
        public async Task<food> GetFoodById(int FoodId){
            food chosenFood = await _context.Food.FirstOrDefaultAsync(food => food.FoodId == FoodId);
            return chosenFood;
        }



        [HttpPost]
        [Route("[action]")]
        public void UploadImage(IFormFile file){
            string webRootPath = _hosting.WebRootPath;
            string absolutePath = Path.Combine($"{webRootPath}/images/{file.FileName}");
            using(var fileStream = new FileStream(absolutePath, FileMode.Create)){
                file.CopyTo(fileStream);
            }
        }

    }
}