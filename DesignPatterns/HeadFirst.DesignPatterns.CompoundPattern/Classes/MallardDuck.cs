namespace HeadFirst.DesignPatterns.CompoundPattern.Classes
{
    using Interfaces;
    using System;

    public class MallardDuck: IQuackable
    {
        private IQuackObservable observable;

        public MallardDuck()
        {
            this.observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("This is Mallard duck - Quack!!");
            this.UpdateObservers();
        }

        public string GetName()
        {
            return "Mallard Duck";
        }

        public Guid RegisterObserver(IObserver observer)
        {
            return this.observable.RegisterObserver(observer);
        }

        public void RemoveObserver(Guid id)
        {
            this.observable.RemoveObserver(id);
            return;
        }

        public void UpdateObservers()
        {
            this.observable.UpdateObservers();
        }
    }
}
