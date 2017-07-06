namespace WebApiWithGenericsExample.Domain
{
    public class FootballAvailableSources : IAvailableSources
    {
        public FootballAvailableSources(bool isFootballFeedOne, bool isFootballFeedTwo)
        {
            IsFootballFeedOne = isFootballFeedOne;
            IsFootballFeedTwo = isFootballFeedTwo;
        }

        public bool IsFootballFeedOne { get; }
        public bool IsFootballFeedTwo { get; }
    }
}