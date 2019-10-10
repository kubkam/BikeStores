﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BikeStores.Data;
using BikeStores.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BikeStores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IBikeStoresRepository _bikeStoresRepository;
        private readonly IMapper _mapper;

        public ValuesController(IBikeStoresRepository bikeStoresRepository, IMapper mapper)
        {
            _bikeStoresRepository = bikeStoresRepository;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ProductsDto> Get(int id)
        {
            var product = _bikeStoresRepository.ProductGetById(id);
            var model = _mapper.Map<ProductsDto>(product);
            
            return model;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
