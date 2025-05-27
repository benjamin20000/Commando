namespace Commando;

public class AirCommando : Commando
{
    public AirCommando(string name, string code) :base(name,code){}

    public void Parachuting()
    {
        Console.WriteLine("The air commando can parachute into the target zone!");
    }
    public override void Attack()
    {
        Console.WriteLine("the AirCommando is atacking from the sky....");
    }
}