using System;

namespace OOPAssignment.IBase{
    public interface IObservable<T> where T:class
    {
        void Attach(IObserver<T> observer);
         void Notify();
    }
}
