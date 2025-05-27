namespace Commando;

public class SeaCommando : Commando
{
    public SeaCommando(string name, string code) : base(name, code){}
    
    public void swim()
    {
        Console.WriteLine("the soldier is winning");
    }

    public override void Attack()
    {
        Console.WriteLine("the SeaCommando is atacking from the see....");
    }
    
}