Console.WriteLine("Task 9\n" + "Experiment 1");
Console.Write("Enter your laptop model: ");
string model = Console.ReadLine();
Console.Write("Enter your CPU frequency: ");
string mhz = Console.ReadLine();
Console.Write("Enter your ram capacity: ");
string ram = Console.ReadLine();
Console.Write("Enter your hdd capacity: ");
string hdd = Console.ReadLine();
Console.Write("Enter weight: ");
string weight = Console.ReadLine();

Device laptop1 = new Device(model, mhz, ram, hdd, weight);
Device laptop2 = new Device("Lenovo 14ALC05", "2600MHz", "16GB", "256GB", "4 kilo");
Device laptop3 = new Device(laptop1);
Device laptop4 = laptop2.Clon();

Console.WriteLine($"\n1 Device:\n {laptop1.Info}");
Console.WriteLine($"2 Device:\n {laptop2.Info}");
Console.WriteLine($"3 Device:\n {laptop3.Info}");
Console.WriteLine($"4 Device:\n {laptop4.Info}");

class Device
{
    public string Model { get; set; }
    public string Mhz { get; set; }
    public string Ram { get; set; }
    public string Hdd { get; set; }
    public string Weight { get; set; }  

    public Device() { Model = "Undefined"; Mhz = "Undefined"; Ram = "Undefined"; Hdd = "Undefined"; Weight = "Undefined"; }
    public Device(string m, string mh, string r, string h, string w) { Model = m; Mhz = mh; Ram = r; Hdd = h; Weight = w; }
    public Device(Device obj) { Model = obj.Model; Mhz = obj.Mhz; Ram = obj.Ram; Hdd = obj.Hdd; Weight = obj.Weight; }
    public Device Clon() { return new Device(this); }
    public string Info
    {
        get
        {
            return $"Model: {Model}\n" +
                $"CPU Frequency: {Mhz}\n" +
                $"RAM Capacity: {Ram}\n" +
                $"HDD Capacity: {Hdd}\n" +
                $"Weight: {Weight}\n";

        }
    }
}