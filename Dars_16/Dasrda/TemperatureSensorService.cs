namespace Dars_16.Dasrda;
/*
 * N16-T2

- temperaturani saqlab boradigan TemperatureSensorService servisidan foydalaning
- unda Temperature write-only parameteri bo'lsin
- har safar set qilganda temperature list ga saqlab borilsin
- saqlang temperaturalar Display methodi orqali ekranga chiqarilsin
 */
public class TemperatureSensorService
{
    private List<int> _temperatureList = new List<int>();
    private int _temperature;
    public int Temperature
    {
        set => _temperature = value;
    }
    
    public void Display()
    {
        foreach (var t in _temperatureList)
        {
            Console.WriteLine($"Temperature {t}˚C");
        }
    }

    public void SetTemperature(int temperature)
    {
        _temperatureList.Add(temperature);
    }
    
    public TemperatureSensorService(int temperature)
    {
        _temperatureList.Add(temperature);
        SetTemperature(13);
        SetTemperature(30);
        SetTemperature(42);
        SetTemperature(36);
        SetTemperature(33);
        SetTemperature(31);
    }
}