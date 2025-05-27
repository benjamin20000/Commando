namespace Commando;


static class Program
{
    static void Main(string[] args)
    {
        Commando commando = new Commando("benny","benn11");
        commando.Walk();
        commando.Hide();
        commando.Attack();

        Weapon weapon = new Weapon("calach12", "h.h.b", 3);
        weapon.Shoot();
        weapon.Shoot();
        weapon.Shoot();
        weapon.Shoot();
    }
}