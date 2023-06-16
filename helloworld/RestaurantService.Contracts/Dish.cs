namespace RestaurantService.Contracts
{
    public class Dish
    {
        public string Title { get; set; } = null!;
        
        public decimal Price { get; set; }
        
        public int Id { get; set; }
    }
}