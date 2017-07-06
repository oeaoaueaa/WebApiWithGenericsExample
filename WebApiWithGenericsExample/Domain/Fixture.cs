namespace WebApiWithGenericsExample.Domain
{
    public abstract class Fixture<TAvailableSources> : IFixture<TAvailableSources> where TAvailableSources : IAvailableSources
    {
        protected Fixture(int id, TAvailableSources availableSources)
        {
            Id = id;
            AvailableSources = availableSources;
        }

        public int Id { get; }        
        public TAvailableSources AvailableSources { get; }
        public abstract string Type { get; }
    }
}