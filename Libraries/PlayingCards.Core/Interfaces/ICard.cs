using System;

namespace PlayingCards.Core
{

    public interface ICard {
        bool CanPlay();
        bool FindCard<T>(Func<T, bool> predicate);
    }
}
