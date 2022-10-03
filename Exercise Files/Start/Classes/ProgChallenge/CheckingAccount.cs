namespace ProgChallenge
{
    public class CheckingAccount : Bank
    {
        private const decimal OVERDRAW_CHARGE = 35.0m;
        public CheckingAccount(string fname, string lname, decimal initial) : base(fname, lname, initial)
        {
        }
        public override void Withdraw(decimal amount)
        {
            // If the account gets overdrawn, add an extra charge
            if(amount > Balance){
                amount=+OVERDRAW_CHARGE;
            }
            base.Withdraw(amount);
        }
    }
}