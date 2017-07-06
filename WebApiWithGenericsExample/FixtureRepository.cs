using System;
using System.Collections.Generic;
using System.Linq;
using WebApiWithGenericsExample.Domain;

namespace WebApiWithGenericsExample
{
    internal class FixtureRepository : IFixtureRepository
    {

        private readonly Dictionary<Type, List<IFixture<IAvailableSources>>> _fixtureStorageSimulation;

        public FixtureRepository()
        {
            // simulating the database/ninject/other repository :)
            _fixtureStorageSimulation = new Dictionary<Type, List<IFixture<IAvailableSources>>>
            {
                {
                    typeof(FootballFixture), new List<IFixture<IAvailableSources>>
                    {
                        new FootballFixture(1, new FootballAvailableSources(true, false), "jose"),
                        new FootballFixture(2, new FootballAvailableSources(true, true), "carlos"),
                    }
                },
                {
                    typeof(TennisFixture), new List<IFixture<IAvailableSources>>
                    {
                        new TennisFixture(102, new TennisAvailableSources(true), 3)
                    }
                }
            };
        }

        public IEnumerable<TFixture> GetAll<TFixture, TAvailableSources>() where TFixture : IFixture<TAvailableSources> where TAvailableSources : IAvailableSources
        {
            return _fixtureStorageSimulation[typeof(TFixture)].Select(f => (TFixture)f);
        }

        public void Insert<TFixture, TAvailableSources>(TFixture value) where TFixture : IFixture<TAvailableSources> where TAvailableSources : IAvailableSources
        {
            _fixtureStorageSimulation[typeof(TFixture)].Add((IFixture<IAvailableSources>) value);
        }

        public TFixture Get<TFixture, TAvailableSources>(int id) where TFixture : IFixture<TAvailableSources> where TAvailableSources : IAvailableSources
        {
            return (TFixture) _fixtureStorageSimulation[typeof(TFixture)].FirstOrDefault(f => f.Id == id);
        }
    }
}