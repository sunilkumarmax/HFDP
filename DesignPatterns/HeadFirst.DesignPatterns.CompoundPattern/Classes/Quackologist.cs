namespace HeadFirst.DesignPatterns.CompoundPattern.Classes
{
    using Interfaces;
    using System;

    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable observable)
        {
            Console.WriteLine("Quackologist speaking: Got an update from " + observable.GetName() + ". It just quacked!!");
        }
    }
}
