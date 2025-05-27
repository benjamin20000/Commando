namespace Commando;

public class Commando
{
    private string Name;
    public string CodeName { set; get; }
    private string[] Tools;
    private string status;

    public Commando(string name, string code)
    {
        this.Name = name;
        this.CodeName = code;
        this.Tools = new []{"Hammer", "chisel", "rope", "bag", "canteen"};
    }

    public void Walk()
    {
        this.status = "walking";
        Console.WriteLine("the soldier walking");
    }
    public void Hide()
    {
        this.status = "hiding";
        Console.WriteLine("the soldier hiding");
    } 
    public virtual void  Attack()
    {
        this.status = "attacking";
        Console.WriteLine($"the soldier {this.CodeName} attacking");
    }

    public void SayName(string commanderRank)
    {
        if (commanderRank == "GENERAL") {Console.WriteLine($"the soldier name is {this.Name}");}
        else if(commanderRank == "COLONEL") {Console.WriteLine($"the soldier code name is {this.CodeName}");}
        else{ Console.WriteLine($"you dont have the permission to know something like this");}
    }
    
}