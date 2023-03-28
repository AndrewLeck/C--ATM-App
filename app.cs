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

    public String getNum()
    {
        return cardNum;
    }

     public int getPin()
    {
        return pin;
    }

     public String getFirstName()
    {
        return firstName;
    }

     public String getLastName()
    {
        return lastName;
    }

     public double getBalance()
    {
        return balance;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(string newLastName)
    {
        LastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(string[] args)
    {
        vouid printOptions()
        {
            Console.WriteLine("Please chose from one of the folliwing options");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
        }

        void Withdraw(cardHolder currentUser)
        {
          Console.WriteLine("How much $$ would you like to withdraw?");  
          double withdraw = Double.Parse(Console.ReadLine());
          //check if user has enough moeny
          if(currentUser.getBalance() > withdraw)
          {
            Console.WriteLine("Insufficiate balance");
          }
          else
          {
            currentUser.setBalance(currentUser.getBalance() - withdraw);
            Console.WriteLine("Thank you! All set ");
          }
        }

        voice balance(cardHolder currentUser)
        {
           Console.writeLine("Current balance: " + currentUser.getBalance()); 
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        carHolders.Add(new cardHolder("45327728527396", 1234, "John", "Snow", 150.31));
        carHolders.Add(new cardHolder("12345678912345", 4567, "Abby", "Star", 70.31));
        carHolders.Add(new cardHolder("76543215678934", 9999, "Tyler", "Jones", 850.45));
        carHolders.Add(new cardHolder("45362749210485", 4323, "Ash", "Rose", 300.31));
        carHolders.Add(new cardHolder("67894918364719", 1234, "Fin", "Hip", 10000.31));

        //prompt User
        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your debit card: ");
        string debtCardNum = "";
        cardHolder currentUser;

        while(true)
        {
            try
            {
                debtCardNum = Console.ReadLine();
                //check agaist our "db"
                currentUser = cardHolders.FirstorDefault(a => a.cardNum == debtCardNum);
                if (currentUser != null){break;}
                else{ Console.WriteLine("Card not recognized. Please try again"); }
            }
            catch{Console.WriteLine("Card not recognized. Please try again"); }
        }
        
        Console.WriteLine("Please enter your Pin: ");
        int userPin = 0;
        while(true)
        {
            try
            {
                userPin = Int.Parse(Console.ReadLine());
                if (currentUser .getPin() == userPin){break;}
                else{ Console.WriteLine("Incorrect pin. Please try again"); }
            }
            catch{Console.WriteLine("Incorrect pin. Please try again"); }
        }

        Console.WritLine("Welcome " + currentUser.getFirstName() +" :)");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch{ }
            if( option == 1 ){ deposit(currentUser);}
            else if( option == 2){ Withdraw(currentUser);}
            else if( option == 3){ balance(currentUser);}
            else if( option == 4){ break; }
            else { option = 0; }

        }
        while(optoion != 4);
        Console.WriteLine("Thank you hagve a nice day :)");
    }

}