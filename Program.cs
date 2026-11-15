Cart cart = new Cart();

Product pen = new Product();
pen.Code = "PEN";
pen.Name = "Pen";
pen.PriceInPence = 120;

Product mug = new Product();
mug.Code = "MUG";
mug.Name = "Mug";
mug.PriceInPence = 600;

cart.AddItem(pen, 2);
cart.AddItem(mug, 1);

Console.WriteLine("Total items: " + cart.GetTotalCount());

Console.WriteLine("Total price in pence: " + cart.GetTotalInPence());

//create a separate empty cart to test the empty case
Cart emptycart = new Cart();
Console.WriteLine("Empty cart items: " + emptycart.GetTotalCount());
Console.WriteLine("Empty cart price: " + emptycart.GetTotalInPence());
