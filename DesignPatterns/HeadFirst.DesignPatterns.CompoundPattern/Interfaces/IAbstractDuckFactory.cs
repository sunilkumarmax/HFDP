namespace HeadFirst.DesignPatterns.CompoundPattern.Interfaces
{
    interface IAbstractDuckFactory
    {
        IQuackable CreateMallardDuck();
        IQuackable CreateRedheadDuck();
        IQuackable CreateDuckCall();
        IQuackable CreateRubberDuck();
    }
}
