namespace HaveFun02.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date{ get; set; }
        [Required]
        public string Description { get; set;}
        [Reuired]
        public double Amount {get; set;}
        public string Category {get;set;}
    }
}
