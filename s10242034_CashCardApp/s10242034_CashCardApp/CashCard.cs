using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CashCard
{
    private string id;
    private double balance;
        
    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public CashCard() { }

    public CashCard(string i, double b)
    {
        Id = i;
        Balance = b;
    }

    public void TopUp(double a)
    {
        Balance = Balance + a;
    }

    public bool Deduct(double a)
    {
        if (a <= Balance)
        {
            Balance = Balance - a;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return "Id" + Id + "Balance" + Balance;
    }

    
}

