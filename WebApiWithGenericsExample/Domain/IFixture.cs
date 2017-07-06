namespace WebApiWithGenericsExample.Domain
{
    public interface IFixture<out TAvailableSources> where TAvailableSources : IAvailableSources
    {
        int Id { get; }
        string Type { get; }
        TAvailableSources AvailableSources { get; }        
    }
}