namespace GreyHoundRacing.Models
{
    public class Bet
    {
        public int amount;
        public GreyHound dog;
        public Gambler player;

        public string GetDescription()
        {
            return $"{player.Name} bet {amount:C0} on {dog.Name}"; 
        }

        public int Payout()
        {
            if (player.MyBet.dog.win == true)
                return amount*2;
            else
                return 0; 
        }

    }
}