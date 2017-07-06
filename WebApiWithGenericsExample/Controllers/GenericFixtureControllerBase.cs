using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApiWithGenericsExample.Domain;

namespace WebApiWithGenericsExample.Controllers
{
    public abstract class GenericFixtureControllerBase<TFixture, TAvailableSources> : Controller 
        where TFixture : IFixture<TAvailableSources> 
        where TAvailableSources : IAvailableSources
    {
        private static readonly IFixtureRepository FixtureRepository = new FixtureRepository();
        protected GenericFixtureControllerBase()
        {
            
        }

        [HttpGet]
        public IEnumerable<TFixture> Get()
        {
            return FixtureRepository.GetAll<TFixture, TAvailableSources>();
        }

        [HttpGet("{id}")]
        public TFixture Get(int id)
        {
            return FixtureRepository.Get<TFixture, TAvailableSources>(id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]TFixture value)
        {
            FixtureRepository.Insert<TFixture, TAvailableSources>(value);
        }
    }
}