using Levva.newbie.coins.Domain.Enuns;
namespace Levva.newbie.coins.Logic.Dtos
{
    public class TransactionDto
    {
        public int Id{get; set;}
        public string Description{get; set;}
        public decimal Amount{get; set;}
        public DateTime Date{get; set;}
        public TypeTransaction Type{get; set;}
        public int CategoryId{get; set;}
        public virtual CategoryDto Category{get; set;}
        public int UserId{get; set;}
    }
}