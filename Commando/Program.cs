namespace Commando;


static class Program
{
    static void Main(string[] args)
    {
        Commando commando = new Commando("benny","benn11");
        commando.Walk();
        commando.Hide();
        commando.Attack();
        Console.WriteLine(commando.CodeName);

        Weapon weapon = new Weapon("calach12", "h.h.b", 3);
        weapon.Shoot();
        weapon.Shoot();
        weapon.Shoot();
        weapon.Shoot();
        
        Commando regular_commando = new Commando("regular_beeny","b132");
        AirCommando air_commando = new AirCommando("air_solder","b1");
        SeaCommando see_commando = new SeaCommando("see_solder","b1");
        
        Commando[] commandos = new Commando[] { regular_commando, air_commando, see_commando };

        foreach (Commando commando_man in commandos)
        {
            commando_man.Attack();
        }

    }
}