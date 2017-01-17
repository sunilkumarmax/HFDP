namespace HeadFirst.DesignPatterns.CompoundPattern.Classes
{
    using Interfaces;
    using System;

    public class GooseAdaptor: IQuackable
    {
        private Goose goose;
        private IQuackObservable observable;

        public GooseAdaptor(Goose goose)
        {
            this.goose = goose;
            this.observable = new Observable(this);
        }

        public void Quack()
        {
            this.goose.Honk();
            this.UpdateObservers();
        }

        public string GetName()
        {
            return "Goose";
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
