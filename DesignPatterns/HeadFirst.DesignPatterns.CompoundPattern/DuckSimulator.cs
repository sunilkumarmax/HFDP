namespace HeadFirst.DesignPatterns.CompoundPattern
{
    using Classes;
    using Interfaces;
    using System;

    public class DuckSimulator
    {
        public static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            CountingDuckFactory duckFactory = new CountingDuckFactory();
            simulator.Prepare(duckFactory);
            Console.ReadLine();
        }

        private void Prepare(IAbstractDuckFactory duckFactory)
        {
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable goose = new GooseAdaptor(new Goose());

            Flock duckFlock = new Flock();
            duckFlock.Add(redheadDuck);
            duckFlock.Add(duckCall);
            duckFlock.Add(rubberDuck);
            duckFlock.Add(goose);

            Flock mallardFlock = new Flock();
            mallardFlock.Add(duckFactory.CreateMallardDuck());
            mallardFlock.Add(duckFactory.CreateMallardDuck());
            mallardFlock.Add(duckFactory.CreateMallardDuck());
            mallardFlock.Add(duckFactory.CreateMallardDuck());
            duckFlock.Add(mallardFlock);

            Quackologist quackologist = new Quackologist();
            Guid quackologistID = duckFlock.RegisterObserver(quackologist);

            Console.WriteLine("-------------Whole flock Simulation-------------");
            simulate(duckFlock);
            Console.WriteLine("The duck quacked " + QuackCounter.GetQuackCount() + " times");
        }

        private void simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
