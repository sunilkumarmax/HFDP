namespace HeadFirst.DesignPatterns.CompoundPattern.Classes
{
    using Interfaces;
    
    public class DuckFactory : IAbstractDuckFactory
    {
        public IQuackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public IQuackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
