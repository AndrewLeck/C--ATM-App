using Systems;

public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string LastName;
    double balance;

    public cardHolder(string carNum, int pin, string firstName, string lastName, double balance )
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.LastName = LastName;
        this.balance = balance;
    }
}