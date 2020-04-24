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
    public class foodController : ControllerBase {
        private readonly restaurantContext _context;
        private readonly IWebHostEnvironment _hosting;

        public foodController(restaurantContext context, IWebHostEnvironment hosting){
            _context = context;
            _hosting = hosting;
        }

         [HttpGet]
        public async Task<IEnumerable<food>> Get(){
            List<food> foodList = await _context.Food.ToListAsync();
            return foodList;
        }

        [HttpGet("{id}")]
        public async Task<food> GetById(int id){
            food chosenFood = await _context.Food.FirstOrDefaultAsync(food => food.FoodId == id);
            return chosenFood;
        }

        [HttpPost]
        public async Task<food> Post(food newFood){
            _context.Food.Add(newFood);
            await _context.SaveChangesAsync();
            return newFood;
        }

        [HttpPut]
        public async Task<food> Put(food changeFood){
            _context.Update(changeFood);
            await _context.SaveChangesAsync();
            return changeFood;
        }

        [HttpDelete("{id}")]
        public async Task<food> Delete(int id){
            food deleteFood = await _context.Food.FirstOrDefaultAsync(food => food.FoodId == id);
            _context.Food.Remove(deleteFood);
            await _context.SaveChangesAsync();
            return deleteFood;
        }

    }
} 

      


    