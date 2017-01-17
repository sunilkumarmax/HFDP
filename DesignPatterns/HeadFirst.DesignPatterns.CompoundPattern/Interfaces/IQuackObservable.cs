namespace HeadFirst.DesignPatterns.CompoundPattern.Interfaces
{
    using System;

    public interface IQuackObservable
    {
        string GetName();

        Guid RegisterObserver(IObserver observer);

        void RemoveObserver(Guid id);

        void UpdateObservers();
    }
}
