List<Device> devices = new List<Device>()
{
    new Device("MacBook Air M1", "1", "2", "3", "4"),
    new Device("Acer Chromebook Spin 311", "1", "2", "3", "4"),
    new Device("MacBook Air M2", "1", "2", "3", "4"),
    new Device("Acer Aspire 5", "1", "2", "3", "4"),
    new Device("Dell XPS 15", "1", "2", "3", "4")

};

foreach (var device in devices)
{
    Console.WriteLine(device.Info);
}

Console.WriteLine("--------------------------------------Removed obj 1 & 3 from the list--------------------------------------");

devices.RemoveAt(1);
devices.RemoveAt(3);

foreach (var device in devices)
{
    Console.WriteLine(device.Info);
}