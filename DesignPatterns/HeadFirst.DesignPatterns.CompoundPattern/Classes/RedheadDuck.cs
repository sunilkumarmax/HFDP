namespace HeadFirst.DesignPatterns.CompoundPattern.Classes
{
    using Interfaces;
    using System;

    public class RedheadDuck: IQuackable
    {
        private IQuackObservable observable;

        public RedheadDuck()
        {
            this.observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("This is redhead duck - Quack!!");
            this.UpdateObservers();
        }

        public string GetName()
        {
            return "Redhead Duck";
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
