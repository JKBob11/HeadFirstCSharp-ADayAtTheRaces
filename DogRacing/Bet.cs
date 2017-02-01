using System;

namespace DogRacing
{
    class Bet
    {
        public decimal Amount { get; }
        public int Dog { get; }
        public string Owner { get; }

        public Bet()
        {
            
        }
        public Bet(decimal amount, int dog, string owner)
        {
            this.Amount = amount;
            this.Dog = dog;
            this.Owner = owner;
        }
        public string GetDescription()
        {
            if (Amount > 0)
                return String.Format("{0} bets ${1} on dog number {2}", Owner, Amount, Dog);
            return String.Format("{0} has not made a bet", Owner);
        }
    }
}