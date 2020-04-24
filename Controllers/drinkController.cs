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

        [HttpGet("{id}")]
        
        public async Task<drink> GetById(int DrinkId){
            drink chosenDrink = await _context.Drink.FirstOrDefaultAsync(drink => drink.DrinkId == DrinkId);
            return chosenDrink;
        }

        [HttpPost]
        
        public async Task<drink> Post(drink newDrink){
            _context.Drink.Add(newDrink);
            await _context.SaveChangesAsync();
            return newDrink;
        }

        [HttpPut]
        public async Task<drink> Put(drink changeDrink){
            _context.Update(changeDrink);
            await _context.SaveChangesAsync();
            return changeDrink;
        }

        [HttpDelete("{id}")]
        public async Task<drink> Delete(int id){
            drink deleteDrink = await _context.Drink.FirstOrDefaultAsync(drink => drink.DrinkId == id);
            _context.Drink.Remove(deleteDrink);
            await _context.SaveChangesAsync();
            return deleteDrink;
        }

    }
} 

      


    