namespace ShopEaseApp
{
    // Module 3 - Category Management
    // Simple class to hold category details
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public Category(int categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }
    }
}
