using System;

namespace Tools
{
    public interface IReadOnlySubscriptionProperty<T>
    { 
        T Value { get; }
        void SubscribeOnChange(Action<T> subscriptionAction);
        void UnSubscriptionOnChange(Action<T> unsubscriptionAction);
    } 
}

