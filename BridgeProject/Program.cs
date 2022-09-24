Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
freelancer.DoWork();
freelancer.EarnMoney();

freelancer.Language=new CSharpLanguage();
freelancer.DoWork();
freelancer.EarnMoney();

Programmer corpprogrammer = new CorporateProgrammer(new CSharpLanguage());
corpprogrammer.DoWork();
corpprogrammer.EarnMoney();

interface ILanguage
{
    void Build();
    void Execute();
}

class CPPLanguage : ILanguage
{
    public void Build()
    {
        Console.WriteLine("С помощью компилятора С++ компилируем программу в бинарный код"); ;
    }

    public void Execute()
    {
        Console.WriteLine("Запускаем исполняемый файл программы"); ;
    }
}
class CSharpLanguage : ILanguage
{
    public void Build()
    {
        Console.WriteLine("С помощью компилятора переводим в промежуточный язык CIL"); ;
    }

    public void Execute()
    {
        Console.WriteLine("JIT компилирует программу в бинарный код");
        Console.WriteLine("CLR выполняет скомпилированный бинарный код");
    }
}
abstract class Programmer
{
    protected ILanguage language;
    public ILanguage Language
    {
        set { language = value; }
    }
    protected Programmer(ILanguage language)
    {
        this.language = language;
    }
    public virtual void DoWork()
    {
        language.Build();
        language.Execute();
    }
    public abstract void EarnMoney();
}
class FreelanceProgrammer : Programmer
{
    public FreelanceProgrammer(ILanguage language) : base(language)
    {
    }

    public override void EarnMoney()
    {
        Console.WriteLine("Получаем оплату за выполненный заказ");
    }
}

class CorporateProgrammer : Programmer
{
    public CorporateProgrammer(ILanguage language) : base(language)
    {
    }

    public override void EarnMoney()
    {
        Console.WriteLine("Получить зарплату в конце месяца"); ;
    }
}