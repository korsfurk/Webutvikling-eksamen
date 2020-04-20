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
        [Route("[action]")]
        public async Task<IEnumerable<drink>> GetDrinks(){
            List<drink> drinkList = await _context.Drink.ToListAsync();
            return drinkList;
        }

        [HttpGet("{id}")]
        [Route("[action]/{id}")]
        public async Task<drink> GetDrinkById(int DrinkId){
            drink chosenDrink = await _context.Drink.FirstOrDefaultAsync(drink => drink.DrinkId == DrinkId);
            return chosenDrink;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<drink> Post(drink newDrink){
            _context.Drink.Add(newDrink);
            await _context.SaveChangesAsync();
            return newDrink;
        }

          [HttpPut]
        [Route("[action]")]
        public async Task<drink> Put(drink changeDrink){
            _context.Update(changeDrink);
            await _context.SaveChangesAsync();
            return changeDrink;
        }

         [HttpDelete("{id}")]
        [Route("[action]/{id}")]
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

      


    