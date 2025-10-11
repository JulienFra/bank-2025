public class Person
{
    public string FirstName;
    public string lastName;
    public DateTime BirthDate;

}

public class currentAccount
{
    public string number;
    public double balance { get; }
    public double creditLine;
    public Person owner;

    public void Withdraw(double amount)
    {

    }
    public void Deposit(double amount)
    {

    }
}

public class Bank
{
    public Dictionary<string, currentAccount> Account { get; }
    public string name;
}