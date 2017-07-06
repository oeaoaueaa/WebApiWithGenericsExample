namespace WebApiWithGenericsExample.Domain
{
    public class FootballFixture : Fixture<FootballAvailableSources>
    {
        public FootballFixture(int id, FootballAvailableSources availableSources, string goalScorer ) : base(id, availableSources)
        {
            GoalScorer = goalScorer;
        }

        public override string Type { get; } = "Football";

        public string GoalScorer { get; }        
    }
}