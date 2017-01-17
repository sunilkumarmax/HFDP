namespace HeadFirst.DesignPatterns.CompoundPattern.Classes
{
    using System;
    using Interfaces;

    public class QuackCounter: IQuackable
    {
        private static int quackCount = 0;
        private IQuackObservable observable;
        IQuackable duck;

        public QuackCounter(IQuackable duck)
        {
            quackCount = 0;
            this.duck = duck;
            this.observable = new Observable(this);
        }

        public void Quack()
        {
            this.duck.Quack();
            quackCount++;
        }

        public string GetName()
        {
            return this.duck.GetName();
        }

        public static int GetQuackCount()
        {
            return quackCount;
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
