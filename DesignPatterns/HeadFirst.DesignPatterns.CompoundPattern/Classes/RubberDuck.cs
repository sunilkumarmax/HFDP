namespace HeadFirst.DesignPatterns.CompoundPattern.Classes
{
    using Interfaces;
    using System;

    public class RubberDuck: IQuackable
    {
        private IQuackObservable observable;

        public RubberDuck()
        {
            this.observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("This is rubber duck - Squeak!!");
            this.UpdateObservers();
        }

        public string GetName()
        {
            return "Rubber Duck";
        }

        public Guid RegisterObserver(IObserver observer)
        {
            return this.observable.RegisterObserver(observer);
        }

        public void RemoveObserver(Guid id)
        {
            this.observable.RemoveObserver(id);
        }

        public void UpdateObservers()
        {
            this.observable.UpdateObservers();
        }
    }
}
