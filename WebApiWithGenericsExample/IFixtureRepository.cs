using System.Collections.Generic;
using WebApiWithGenericsExample.Domain;

namespace WebApiWithGenericsExample
{
    internal interface IFixtureRepository
    {
        IEnumerable<TFixture> GetAll<TFixture, TAvailableSources>()
            where TFixture : IFixture<TAvailableSources>
            where TAvailableSources : IAvailableSources;

        void Insert<TFixture, TAvailableSources>(TFixture value)
            where TFixture : IFixture<TAvailableSources>
            where TAvailableSources : IAvailableSources;

        TFixture Get<TFixture, TAvailableSources>(int id)
            where TFixture : IFixture<TAvailableSources>
            where TAvailableSources : IAvailableSources;
    }
}