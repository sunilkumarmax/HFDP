namespace HeadFirst.DesignPatterns.CompoundPattern.Classes
{
    using Interfaces;
    using System;

    public class DuckCall: IQuackable
    {
        private IQuackObservable observable;

        public DuckCall()
        {
            this.observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("This is just a duck call - Kwak!!");
            this.UpdateObservers();
        }

        public string GetName()
        {
            return "Duck Call";
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
