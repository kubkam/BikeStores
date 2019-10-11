using AutoMapper;
using BikeStores.Data;
using BikeStores.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BikeStores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IBikeStoresRepository _bikeStoresRepository;
        private readonly IMapper _mapper;

        public ProductsController(IBikeStoresRepository bikeStoresRepository, IMapper mapper)
        {
            _bikeStoresRepository = bikeStoresRepository;
            _mapper = mapper;
        }

        // GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<ProductsDto>> Get()
        {
            var products = _bikeStoresRepository.GetProducts();
            var model = _mapper.Map<IEnumerable<ProductsDto>>(products).ToList();

            return model;
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public ActionResult<ProductsDto> Get(int id)
        {
            var product = _bikeStoresRepository.ProductGetById(id);
            var model = _mapper.Map<ProductsDto>(product);

            return model;
        }

        // POST api/products
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}