using Xunit;

public class CartTests
{
      // Tests that an empty cart contains zero items
    [Fact]
    public void EmptyCartShouldHaveZeroItems()
    {
        Cart cart = new Cart();

        Assert.Equal(0, cart.GetTotalCount());
    }

 // Tests that adding one product increases the item count to one.
    [Fact]
    public void AddingOneProductShouldIncreaseCount()
    {
        Cart cart = new Cart();

        Product pen = new Product();
        pen.Code = "PEN";
        pen.Name = "Pen";
        pen.PriceInPence = 120;

        cart.AddItem(pen, 1);

        Assert.Equal(1, cart.GetTotalCount());
    }

  // Tests that adding two pens increases the item count to two.
    [Fact]
    public void AddingTwoPensShouldCountTwoItems()
    {
        Cart cart = new Cart();

        Product pen = new Product();
        pen.Code = "PEN";
        pen.Name = "Pen";
        pen.PriceInPence = 120;

        cart.AddItem(pen, 2);

        Assert.Equal(2, cart.GetTotalCount());
    }

 // Tests that an empty cart has a total price of zero pence.
    [Fact]
    public void EmptyCartShouldCostZero()
    {
        Cart cart = new Cart();

        Assert.Equal(0, cart.GetTotalInPence());
    }

    // Tests that one pen costs 120 pence.
    [Fact]
    public void OnePenShouldCost120Pence()
    {
        Cart cart = new Cart();

        Product pen = new Product();
        pen.Code = "PEN";
        pen.Name = "Pen";
        pen.PriceInPence = 120;

        cart.AddItem(pen, 1);

        Assert.Equal(120, cart.GetTotalInPence());
    }

 // Tests that the cart calculates the correct total for different products.
    [Fact]
    public void DifferentProductsShouldCalculateCorrectTotal()
    {
        Cart cart = new Cart();

        Product pen = new Product();
        pen.Code = "PEN";
        pen.Name = "Pen";
        pen.PriceInPence = 120;

        Product mug = new Product();
        mug.Code = "MUG";
        mug.Name = "Mug";
        mug.PriceInPence = 600;

        cart.AddItem(pen, 1);
        cart.AddItem(mug, 1);

        Assert.Equal(720, cart.GetTotalInPence());
    }
}