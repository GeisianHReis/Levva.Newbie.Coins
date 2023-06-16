
namespace Levva.newbie.coins.Logic.Dtos
{
    public class CategoryDto
    {
        public int Id{get; set;}
        public string Description{get; set;}
        public int TransactionId{get; set;}
        public List<TransactionDto> Transactions{get; set;}
    }
}