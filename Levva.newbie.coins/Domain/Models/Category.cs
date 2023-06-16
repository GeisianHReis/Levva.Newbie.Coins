namespace Levva.newbie.coins.Domain.Models
{
    public class Category
    {
        public int Id{get; set;}
        public string Description{get; set;}
        public int TransactionId{get; set;}
        public List<Transaction> Transactions{get; set;}

    }
}