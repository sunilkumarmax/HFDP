namespace HeadFirst.DesignPatterns.CompoundPattern.Classes
{
    using Interfaces;
    using System;
    using System.Collections.Generic;

    class Flock : IQuackable
    {
        private List<IQuackable> duckList;
        private IQuackObservable observable;

        public Flock()
        {
            this.duckList = new List<IQuackable>();
            this.observable = new Observable(this);
        }

        public void Add(IQuackable duck)
        {
            this.duckList.Add(duck);
        }

        public void Quack()
        {
            foreach (IQuackable duck in duckList)
            {
                duck.Quack();
            }
        }

        public string GetName()
        {
            return "Flock of ducks";
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
