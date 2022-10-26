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