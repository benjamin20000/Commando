namespace Commando;

public class Weapon
{
    private string Name;
    private string Manufacturer;
    private int BulletsNumber;

    public Weapon(string name, string manufacturer, int bulletsNumber)
    {
        this.Name = name;
        this.Manufacturer = manufacturer;
        this.BulletsNumber = bulletsNumber;
    }

    public void Shoot()
    {
        if (this.BulletsNumber > 0)
        {
            Console.WriteLine("shooting.....");
            this.BulletsNumber--;
        }
        else
        {
            Console.WriteLine("no bullets left");
        }
    }
}
    