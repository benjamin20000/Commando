namespace Commando;

class Commando
{
    private string Name;
    private string Code;
    private string[] Tools;
    private string status;

    public Commando(string name, string code)
    {
        this.Name = name;
        this.Code = code;
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
    public void Attack()
    {
        this.status = "attacking";
        Console.WriteLine($"the soldier {this.Code} attacking");
    }
    
}