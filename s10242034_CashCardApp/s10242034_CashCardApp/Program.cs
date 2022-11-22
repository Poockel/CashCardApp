void initcardlist(List<CashCard> cardlist)
{
    CashCard c1 = new CashCard("001", 25.0);
    CashCard c2 = new CashCard("002", 25.0);
    CashCard c3 = new CashCard("003", 30.0);
    CashCard c4 = new CashCard("004", 30.0);
    CashCard c5 = new CashCard("005", 50.0);
    cardlist.Add(c1);
    cardlist.Add(c2);
    cardlist.Add(c3);
    cardlist.Add(c4);
    cardlist.Add(c5);
}

List<CashCard> cardlist = new();
initcardlist(cardlist);

CashCard Search(List<CashCard> cardlist, string id)
{
    foreach (var card in cardlist)
    {
        if (card.Id == id)
        {
            return card;
        }
    }
    return null;
}

foreach (var c in cardlist)
{
    Console.WriteLine("{0}  {1}", c.Id, c.Balance);
}

Console.Write("Enter Id: ");
String id = Console.ReadLine();
CashCard card = Search(cardlist, id);

if (card != null)
{
    Console.WriteLine("Balance" + card.Balance);
    Console.WriteLine("Enter amount to deduct: ");
    double amount = Convert.ToDouble(Console.ReadLine());
    bool success = card.Deduct(amount);
    if(success)
    {
        Console.WriteLine("Successful deduction");
        Console.WriteLine("Balance" + card.Balance);
    }
    else
    {
        Console.WriteLine("Insufficient balance");
    }
}
else
{
    Console.WriteLine("Card not found");
}
