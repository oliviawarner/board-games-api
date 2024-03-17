namespace BoardGamesApi;

public class BoardGame
{
    public Guid Id {get;set;} = Guid.NewGuid();
    public string Name {get;set;}
    public double Rating {get;set;}
    public string Played {get;set;}
    public DateTime CreatedDate {get;set;} = DateTime.UtcNow;
}