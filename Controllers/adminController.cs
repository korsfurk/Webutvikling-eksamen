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

        [HttpGet("{id}")]
        public async Task<food> GetFoodById(int FoodId){
            food chosenFood = await _context.Food.FirstOrDefaultAsync(food => food.FoodId == FoodId);
            return chosenFood;
        }

        [HttpGet("{id}")]
        public async Task<drink> GetDrinkById(int DrinkId){
            drink chosenDrink = await _context.Drink.FirstOrDefaultAsync(drink => drink.DrinkId == DrinkId);
            return chosenDrink;
        }

        [HttpPost]
        public async Task<food> Post(food newFood){
            _context.Food.Add(newFood);
            await _context.SaveChangesAsync();
            return newFood;
        }

        [HttpPost]
        public async Task<drink> Post(drink newDrink){
            _context.Drink.Add(newDrink);
            await _context.SaveChangesAsync();
            return newDrink;
        }

        [HttpPut]
        public async Task<food> Put(food changeFood){
            _context.Update(changeFood);
            await _context.SaveChangesAsync();
            return changeFood;
        }

        [HttpPut]
        public async Task<drink> Put(drink changeDrink){
            _context.Update(changeDrink);
            await _context.SaveChangesAsync();
            return changeDrink;
        }

        [HttpDelete("{id}")]
        public async Task<food> DeleteFood(int FoodId){
            food deleteFood = await _context.Food.FirstOrDefaultAsync(food => food.FoodId == FoodId);
            _context.Food.Remove(deleteFood);
            return deleteFood;
        }

        [HttpDelete("{id}")]
        public async Task<drink> DeleteDrink(int DrinkId){
            drink deleteDrink = await _context.Drink.FirstOrDefaultAsync(drink => drink.DrinkId == DrinkId);
            _context.Drink.Remove(deleteDrink);
            return deleteDrink;
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