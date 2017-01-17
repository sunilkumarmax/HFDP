namespace HeadFirst.DesignPatterns.CompoundPattern.Classes
{
    using Interfaces;
    using System;
    using System.Collections.Generic;

    class Observable : IQuackObservable
    {
        private static Dictionary<Guid, IObserver> observerDict;
        IQuackObservable duck;

        public Observable(IQuackObservable duck)
        {
            this.duck = duck;
            observerDict = new Dictionary<Guid, IObserver>();
        }

        public string GetName()
        {
            return this.duck.GetName();
        }

        public Guid RegisterObserver(IObserver observer)
        {
            Guid id = new Guid();
            observerDict.Add(id, observer);
            return id;
        }

        public void RemoveObserver(Guid id)
        {
            observerDict.Remove(id);
        }

        public void UpdateObservers()
        {
            foreach(KeyValuePair<Guid, IObserver> pair in observerDict)
            {
                pair.Value.Update(this.duck);
            }
        }
    }
}
