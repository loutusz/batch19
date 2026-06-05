// See https://aka.ms/new-console-template for more information

Console.Write("Enter hero name: ");
string heroName = Console.ReadLine() ?? string.Empty;

Console.Write("Input power: ");
int heroPower = int.Parse(Console.ReadLine() ?? "0");

SuperHero hero = new SuperHero
{
    Nama = heroName,
    PowerLevel = heroPower,
};
hero.Attack();
hero.DisplayInfo();
class SuperHero
{
    public required string Nama { get; set; }
    public int PowerLevel { get; set; }
    public int Damage { get; set; }
    public void Attack()
    {
        if (PowerLevel >= 1000)
        {
            Damage = (PowerLevel / 100) * 10;
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Nama: {Nama}, Power Level: {PowerLevel}, Damage: {Damage}");
    }
}
