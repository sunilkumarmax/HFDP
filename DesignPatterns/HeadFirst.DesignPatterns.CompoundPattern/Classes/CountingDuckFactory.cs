namespace HeadFirst.DesignPatterns.CompoundPattern.Classes
{
    using Interfaces;

    public class CountingDuckFactory : IAbstractDuckFactory
    {
        public IQuackable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public IQuackable CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
