using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNet5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CovidShopController : ControllerBase
    {
        private static List<CovidShop> shopList = new List<CovidShop>()
        {
            new CovidShop(1, 12, 45,"Pancakes"),
            new CovidShop(2,2, 12,"Tea Shop")
        };

        // GET: api/shop
        [HttpGet]
        public List<CovidShop> Get()
        {
            return shopList;
        }

        // GET: api/shop/5
        // [HttpGet("{id}", Name = "Get")]
        [HttpGet]
        [Route("{id}")]
        public CovidShop GetshopWithId(int id /*int id*/)
        {
            return shopList.Find(i => i.Id == id);
        }

        // POST: api/shop
        [HttpPost]
        public CovidShop Post([FromBody] CovidShop shop)
        {
            shopList.Add(shop);
            return shop;
        }


        // PUT: api/Covid/5
        [Route("{id}")]
        public bool Put(int id, [FromBody] CovidShop shop)
        {
            CovidShop selectedShop = GetshopWithId(id);
            if (selectedShop != null)
            {
                selectedShop.Id = shop.Id;
                selectedShop.Antal = shop.Antal;
                selectedShop.AntalMax = shop.AntalMax;
                selectedShop.ButiksNavn = shop.ButiksNavn;
                return true;
            }

            return false;
        }
    }
}
