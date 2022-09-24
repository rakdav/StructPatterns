Driver driver = new Driver();
Auto auto = new Auto();
driver.Travel(auto);
Camel camel= new Camel();
ITransport camelTransport = new CamelToTransportAdapter(camel);
driver.Travel(camelTransport);

interface ITransport
{
    void Drive();
}
class Auto : ITransport
{
    public void Drive()
    {
        Console.WriteLine("Машина едет по дороге");
    }
}
class Driver
{
    public void Travel(ITransport transport)
    {
        transport.Drive();
    }
}
interface ICamel
{
    void Move();
}
class Camel : ICamel
{
    public void Move()
    {
        Console.WriteLine("Верблюд едет по пустыне");
    }
}
class CamelToTransportAdapter:ITransport
{
    Camel camel;

    public CamelToTransportAdapter(Camel camel)
    {
        this.camel = camel;
    }

    public void Drive()
    {
        camel.Move();
    }
}
