﻿namespace BlazingPizza.Data;
public static class SeedData
{
 public static void Initialize(PizzaStoreContext db)
{
    var specials = new PizzaSpecial[]
    {
 new PizzaSpecial()
 {
 Name= "BasicCheese Pizza",
 Description =
 "It'scheesy anddelicious. Whywouldn'tyou wantone?",
 BasePrice =9.99m,
 ImageUrl ="img/pizzas/cheese.jpg",
 },
 new PizzaSpecial()
 {
 Id= 2,
 Name= "TheBaconatorizor",
 Description ="IthasEVERYkind ofbacon",
 BasePrice =11.99m,
 ImageUrl = "img/pizzas/bacon.jpg",
 },
 new PizzaSpecial()
 {
 Id = 3,
 Name = "Classic pepperoni",
 Description =
 "It's the pizza you grew up with, but Blazing hot!",
 BasePrice = 10.50m,
 ImageUrl = "img/pizzas/pepperoni.jpg",
 },
 new PizzaSpecial()
 {
 Id = 4,
 Name = "Buffalo chicken",
 Description = "Spicy chicken, hot sauce and bleu cheese, guaranteed to warm you up",
 BasePrice = 12.75m,
 ImageUrl = "img/pizzas/meaty.jpg",
 },
 new PizzaSpecial()
 {
 Id = 5,
 Name = "Mushroom Lovers",
 Description =
 "It has mushrooms. Isn't that obvious?",
 BasePrice = 11.00m,
 ImageUrl = "img/pizzas/mushroom.jpg",
 },
 new PizzaSpecial()
 {
 Id = 7,
 Name = "Veggie Delight",
 Description = "It's like salad, but on a pizza",
 BasePrice = 11.50m,
 ImageUrl = "img/pizzas/salad.jpg",
 },
 new PizzaSpecial()
 {
 Id = 8,
 Name = "Margherita",
 Description =
 "Traditional Italian pizza with tomatoes and basil",
 BasePrice = 9.99m,
 ImageUrl = "img/pizzas/margherita.jpg",
 },
 };
    db.Specials.AddRange(specials);
    db.SaveChanges();
}
 }