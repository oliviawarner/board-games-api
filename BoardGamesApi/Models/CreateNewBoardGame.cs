namespace BoardGamesApi;

public class CreateNewBoardGame
{
    public string Id {get;set;}
    public string Name {get;set;}
    public double Rating {get;set;}
    public bool Played {get;set;}
    public DateTime CreatedDate {get;set;}
}