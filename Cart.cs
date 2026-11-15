public class Cart
{
    private List<Product> items = new List<Product>();

    public void AddItem(Product product, int quantity)
    {
        for (int i = 0; i < quantity; i++)
        {
            items.Add(product);
        }
    }
    public int GetTotalCount()
    {
        return items.Count;
    }

    // Calculates and returns the total price of all items in pence
    public int GetTotalInPence()
    {
        int total = 0;

        foreach (Product product in items)
        {
            total = total + product.PriceInPence;
        }

        return total;
    }
}
