
namespace XamarinMALDemo.Interfaces
{
    public interface IPoll
    {
        string PollDescription { get; set; }
        string PollQuestion { get; set; }
        int NumberResponses { get; set; }
    }
}
