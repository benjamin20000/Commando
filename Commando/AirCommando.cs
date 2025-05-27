namespace Commando;

public class AirCommando : Commando
{
    public AirCommando(string name, string code) :base(name,code){}

    public void Parachuting()
    {
        Console.WriteLine("The air commando can parachute into the target zone!");
    }
}