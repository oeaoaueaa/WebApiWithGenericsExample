namespace WebApiWithGenericsExample.Domain
{
    public class TennisFixture : Fixture<TennisAvailableSources>
    {
        public TennisFixture(int id, TennisAvailableSources availableSources, int sets) : base(id, availableSources)
        {
            Sets = sets;
        }

        public override string Type { get; } = "Tennis";

        public int Sets { get; }
    }
}