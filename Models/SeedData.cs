using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FoodsOrderAPI.Data;
using System;
using System.Linq;

namespace FoodsOrderAPI.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FoodsOrderAPIContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FoodsOrderAPIContext>>()))
            {
                
                if (context.FoodItems.Any())
                {
                    return;   // DB has been seeded
                }

                context.FoodItems.AddRange(
                    new FoodItem
                    {
                        Id= 1,
                        ImgSource= "https://d1ralsognjng37.cloudfront.net/9dd6494b-84f6-4459-8b55-359d45f8723c.jpeg",
                        Title= "Wet Burrito",
                        Desc= "French Fries, Any Kind of meat, Lettuce, Cheese, Sour Cream, Beans, Pico de Gallo, Avocado"

                    },
					new FoodItem
					{
						Id = 2,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/e05d185a-cca5-418e-b12d-4896e0e76100.jpeg",
						Title = "Super Burrito de Carne",
						Desc = "Rice, Beans, Avocado, Sour Cream, Cheese, Hot Salsa, Onions and Choice of Meat."
					},
					new FoodItem
					{
						Id = 3,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/8271ecd9-5999-45ef-94bd-9548e20e2cc8",
						Title = "Shrimp Dumplings",
						Desc = "French Fries, Any Kind of meat, Lettuce, Cheese, Sour Cream, Beans, Pico de Gallo, Avocado"
					},
					new FoodItem
					{
						Id = 4,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/afe3299b-3d2c-42ae-bc2b-49ebae6f2a08.jpeg",
						Title = "House Spicy Chow Mein Bundle",
						Desc = "Prawns, beef, and chicken. Hot and spicy. Served with your choice of Coca-Cola product."
					},
					new FoodItem
					{
						Id = 5,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/df537120-d788-4c91-850d-7cfb36383aee",
						Title = "House Chow Mein Bundle",
						Desc = "Prawns, beef, and chicken. Served with your choice of Coca-Cola product."
					},
					new FoodItem
					{
						Id = 6,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/d620f5a2-7447-4661-995b-b5d72f30496a",
						Title = "Mango Matcha Latte",
						Desc = "Full-bodied, fragrant, and tropical. Organic ceremonial matcha. When autocomplete results are available, use up and down arrows to review and enter to select. Touch device users, explore by touch or with swipe gestures."
					},
					new FoodItem
					{
						Id = 7,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/f03c0162-9526-4b07-bebe-4cede928e7a5",
						Title = "Mango Matcha Latte",
						Desc = "Fried rice, with a coca-cola product"
					},
					new FoodItem
					{
						Id = 8,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/16fb7fa3-2b14-4636-a479-f906062f552e.jpeg",
						Title = "Procoly Ahu",
						Desc = "Fried. Served with your choice of Coca-Cola Product."
					},
					new FoodItem
					{
						Id = 9,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/c75bb883-af05-4769-ab20-679274f4d969.jpeg",
						Title = "Espresso Macchiato",
						Desc = "Our rich espresso marked with dollop of steamed milk and foam. A European-style classic."
					},
					new FoodItem
					{
						Id = 10,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/a0ebf83a-234a-475b-95ea-4f05249a7b0b",
						Title = "Roasted Duck",
						Desc = "Roasted Duck Bejing Formular."
					},
					new FoodItem
					{
						Id = 11,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/b4b84466-4ce7-4423-8852-388c6443ef93.jpeg",
						Title = "Noodle Soup with Wonton + Choice of Congee",
						Desc = "Noodle Soup with Wonton. Served with choice of Congee"
					},
					new FoodItem
					{
						Id = 12,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/5ccbfe25-5235-491f-92b6-06277e862332",
						Title = "BBQ Triple Combination",
						Desc = "Pork BBQ Triple Combination . Coffee or CocaCola"
					},
					new FoodItem
					{
						Id = 13,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/3df9fe44-d810-4d19-a63e-9615eb7fb999.jpeg",
						Title = "Dry Beef Pho - Phở xào bò",
						Desc = "Vietnam food - Pho famous"
					},
					new FoodItem
					{
						Id = 14,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/3b16e7d8-4890-490b-ad7d-26832be05bf0",
						Title = "Minced Beef with Chinese Parsley Soup",
						Desc = "Minced Beef with Chinese Parsley Soup - Server with Chinese Wine"
					},
					new FoodItem
					{
						Id = 15,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/8d0d39a4-9268-4124-912e-e3f39a945270",
						Title = "Salt and Pepper Lobster",
						Desc = "Salt and Pepper Lobster + 4 cans Tiger Beer"
					},
					new FoodItem
					{
						Id = 16,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/91ac561a-d34a-4381-9718-f944bfdd8f36",
						Title = "3 Kinds of BBQ Combinate Plate 三宝饭 Bundle",
						Desc = "Served with your choice of Coca-Cola product."
					},
					new FoodItem
					{
						Id = 17,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/65e2c21b-bd5c-4439-86cf-3ec2a2747186",
						Title = "BBQ Pork",
						Desc = "Served with your choice of Coca-Cola product."
					},
					new FoodItem
					{
						Id = 18,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/c93f79b6-b097-49b2-8f33-a169ff9463c9.jpeg",
						Title = "BBQ Pork Mix Combo",
						Desc = "Served with your choice of Coca-Cola product."
					},
					new FoodItem
					{
						Id = 19,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/64c53582-f3a4-4180-ae58-588b09b66c48.jpeg",
						Title = "Szechuan Beef Noodle Soup",
						Desc = "Served with your choice of Coca-Cola product."
					},
					new FoodItem
					{
						Id = 20,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/73ae7d02-586c-46e7-8fbf-228135920d8e.jpeg",
						Title = "Salt and Pepper Spices Half and Half",
						Desc = "With fried rice, boiled rice, or lo mein. + 1 CocaCola"
					},
					new FoodItem
					{
						Id = 21,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/6cd12011-8025-4188-a787-f0e61a972448",
						Title = "Dim Sum Platter",
						Desc = "Six pieces. Prawn, vegetarian, chive and prawn, scallop and prawn, zucchini and prawn, and spinach dumpling."
					},
					new FoodItem
					{
						Id = 22,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/f1d6d77d-9389-4e84-8fc5-fc2c589bf7d4",
						Title = "Steamed Prawn, Zucchini Dumplings",
						Desc = "Canton Element (Holborn) has a FHRS rating of 5. This information was updated on 14/05/2020. The current rating is on their page on the FSA Website."
					},
					new FoodItem
					{
						Id = 23,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/1953227c-6829-4d6f-8db2-3ebbbd5641ca",
						Title = "Stir Fried Scallops, King Prawns with Asparagus",
						Desc = "Canton Element (Holborn) has a FHRS rating of 5. This information was updated on 14/05/2020. The current rating is on their page on the FSA Website."
					},
					new FoodItem
					{
						Id = 24,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/601d7eff-0d52-4cc3-931c-f950e809d890",
						Title = "Bulgogi",
						Desc = "Korean traditional stir fried beef marinated in sweet soy sauce."
					},
					new FoodItem
					{
						Id = 25,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/f30d538c-10b2-4a92-a0ee-65842404581e",
						Title = "Pork Belly",
						Desc = "Pan fried pork belly."
					},
					new FoodItem
					{
						Id = 26,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/90e95fa8-6f74-43f6-8217-7775e6bc592a",
						Title = "Cheese Buldak",
						Desc = "Super spicy stir-fried chicken with mozzarella cheese."
					},
					new FoodItem
					{
						Id = 27,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/300c3919-b7e8-4550-803e-6e11a3b87d1a",
						Title = "Jeyuk",
						Desc = "Korean traditional stir pork marinated in chilli."
					},
					new FoodItem
					{
						Id = 28,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/f5a3cef7-2deb-4928-9501-1a86c2954e7d",
						Title = "Bibimbab",
						Desc = "Steamed rice with assorted vegetables and fried egg in a bowl."
					},
					new FoodItem
					{
						Id = 29,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/c45e56a1-b46c-4460-a0c9-65d5694b293e",
						Title = "Osam Bulgogi",
						Desc = "Stir fried squId and pork belly in chilli sauce."
					},
					new FoodItem
					{
						Id = 30,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/03f8db8b-706b-472e-bba6-301b6587a724.jpeg",
						Title = "Chicken katsu curry",
						Desc = "Deep fried chicken katsu with curry and steamed rice."
					},
					new FoodItem
					{
						Id = 31,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/abaee2a3-beb2-4e14-b194-d0b1af4b0901",
						Title = "Jampong",
						Desc = "Medium sized noodles with mixed seafood in chicken soup."
					},
					new FoodItem
					{
						Id = 32,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/cd4158c9-9c53-4bfe-884c-ddd9d0b87475",
						Title = "King Prawn in Hot Sambal Sauce",
						Desc = "Yum Yum (Victoria) has a FHRS rating of 3. This information was updated on 14/05/2020. The current rating is on their page on the FSA Website."
					},
					new FoodItem
					{
						Id = 33,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/15dd12e8-12af-45a7-a44e-e7b05d514d6a.jpeg",
						Title = "Hand-Pulled Noodles, Xinjiang Style",
						Desc = "With one person. With bone in chicken and potatoes in a spicy sauce."
					},
					new FoodItem
					{
						Id = 34,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/2cbb139d-37c0-4eab-ad21-39a834a517e0.jpeg",
						Title = "Pork Biang Biang Noodles",
						Desc = "With tomato and egg sauce, and chilli oil."
					},
					new FoodItem
					{
						Id = 35,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/01aaa7cb-e759-4046-be64-d9f3317feb07.jpeg",
						Title = "Samgyetang(Ginseng chicken soup)",
						Desc = "Samgyetang (Ginseng Chicken Soup) is a hot, steaming, very traditional Korean healthy dish which is served with whole Poussin stuffed with rice, garlic, and jujube in the chicken broth made with ginseng and herbal ingredients."
					},
					new FoodItem
					{
						Id = 36,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/f369d010-b700-4b00-8325-d1860d56160b.jpeg",
						Title = "Boneless Chicken in Ginger Sauce",
						Desc = "With bamboo shoots, sesame seeds, soy sauce, and chilli oil. Also includes cucumber, radish, green and red pepper, wood ear mushroom, strawberry, tomato and lettuce."
					},
					new FoodItem
					{
						Id = 37,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/37244986-10f9-4025-9f7a-a1748f4bf116.jpeg",
						Title = "Xi’an Spicy Sliced Beef",
						Desc = "With cucumber, coriander, and sesame oil. Also includes cucumber, radish, green and red pepper, wood ear mushroom, strawberry, tomato and lettuce."
					},
					new FoodItem
					{
						Id = 38,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/c85cf098-f897-4e52-8036-2dd002e09afb.jpeg",
						Title = "With green peppers, red peppers, cucumber, spring onion, and beansprouts.",
						Desc = "Samgyetang (Ginseng Chicken Soup) is a hot, steaming, very traditional Korean healthy dish which is served with whole Poussin stuffed with rice, garlic, and jujube in the chicken broth made with ginseng and herbal ingredients."
					},
					new FoodItem
					{
						Id = 39,
						ImgSource = "https=//d1ralsognjng37.cloudfront.net/3d5a0d40-c76c-48ac-b8ed-2638774a7d37.jpeg",
						Title = "Chicken Spring Rolls",
						Desc = "Filled with assorted vegetables, bean thread noodles, and chicken."
					},
					new FoodItem
					{
						Id = 40,
						ImgSource = "https=//media.cooky.vn/recipe/g1/1615/s480x480/recipe1615-prepare-step3-636520093053653228.jpg",
						Title = "Bánh tráng trộn",
						Desc = "Bánh tráng, xoài, trứng cút, tôm khô, rau thơm + 1 CocaCola"
					}
                );
                context.SaveChanges();
            }
        }
    }
}