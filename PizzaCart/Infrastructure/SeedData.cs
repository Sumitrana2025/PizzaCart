using Microsoft.EntityFrameworkCore;
using PizzaCart.Infrastructure;
using PizzaCart.Models;


namespace PizzaCart.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category pizza = new Category { Name = "Pizza", Slug = "pizza" };
                Category beverages = new Category { Name = "Beverages", Slug = "beverages" };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "Farmhouse",
                            Slug = "farmhouse",
                            Description = "Delightful combination of onion, capsicum, tomato & grilled mushroom",
                            Price = 459,
                            Category = pizza,
                            Image = "Farmhouse.jpg"
                        },
                        new Product
                        {
                            Name = "Peppy Paneer",
                            Slug = "peppy paneer",
                            Description = "Flavorful trio of juicy paneer, crisp capsicum with spicy red paprika",
                            Price = 459,
                            Category = pizza,
                            Image = "Peppy_Paneer.jpg"
                        },
                        new Product
                        {
                            Name = "Mexican Green Wave",
                            Slug = "mexican green wave",
                            Description = "Mexican herbs sprinkled on onion, capsicum, tomato & jalapeno",
                            Price = 449,
                            Category = pizza,
                            Image = "Mexican_Green_Wave.jpg"
                        },
                        new Product
                        {
                            Name = "Indi Tandoori Paneer",
                            Slug = "indi tandoori paneer",
                            Description = "It is hot. It is spicy. It is oh-so-Indian. Tandoori paneer with capsicum, red paprika & mint mayo",
                            Price = 549,
                            Category = pizza,
                            Image = "Indi_Tandoori_Paneer.jpg"
                        },
                        new Product
                        {
                            Name = "Chicken Dominator",
                            Slug = "chicken dominator",
                            Description = "Loaded with double pepper barbecue chicken, peri-peri chicken, chicken tikka & grilled chicken rashers",
                            Price = 599,
                            Category = pizza,
                            Image = "Chicken_Dominator.png"
                        },
                        new Product
                        {
                            Name = "Non Veg Supreme",
                            Slug = "non veg supreme",
                            Description = "Supreme combination of black olives, onion, capsicum, grilled mushroom, pepper barbecue chicken, peri-peri chicken & grilled chicken rashers",
                            Price = 599,
                            Category = pizza,
                            Image = "NonVeg_Supreme.png"
                        },
                        new Product
                        {
                            Name = "Chicken Fiesta",
                            Slug = "chicken fiesta",
                            Description = "Grilled chicken rashers, peri-peri chicken, onion & capsicum, a complete fiesta",
                            Price = 559,
                            Category = pizza,
                            Image = "Chicken_Fiesta.png"
                        },
                        new Product
                        {
                            Name = "Choco Lava Cake",
                            Slug = "choco lava cake",
                            Description = "Chocolate lovers delight! Indulgent, gooey molten lava inside chocolate cake",
                            Price = 109,
                            Category = beverages,
                            Image = "ChocoLava_Cake.jpg"
                        },
                        new Product
                        {
                            Name = "Pepsi",
                            Slug = "pepsi",
                            Description = "Sparkling and Refreshing Beverage",
                            Price = 60,
                            Category = beverages,
                            Image = "Pepsi.jpg"
                        },
                        new Product
                        {
                            Name = "7up",
                            Slug = "7-up",
                            Description = "Refreshing clear drink with a natural lemon flavor",
                            Price = 60,
                            Category = beverages,
                            Image = "7up.jpg"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}
