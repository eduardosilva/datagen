using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public static class Commerce
    {
        public static string GetProductName()
        {
            return String.Format("{0} {1} {2}", Product.adjective.GetElementRandom(), 
                                                Product.material.GetElementRandom(),
                                                Product.product.GetElementRandom());
        }

        public static string GetDepartmentName()
        {
            return Department.department.GetElementRandom();
        }
    }

    public static class Department
    {
        public static string[] department = new string[] {  "Books",
  "Movies",
  "Music",
  "Games",
  "Electronics",
  "Computers",
  "Home",
  "Garden",
  "Tools",
  "Grocery",
  "Health",
  "Beauty",
  "Toys",
  "Kids",
  "Baby",
  "Clothing",
  "Shoes",
  "Jewelery",
  "Sports",
  "Outdoors",
  "Automotive",
  "Industrial" };
    }

    public static class Product
    {
        public static string[] adjective = new string[] {     "Small",
    "Ergonomic",
    "Rustic",
    "Intelligent",
    "Gorgeous",
    "Incredible",
    "Fantastic",
    "Practical",
    "Sleek",
    "Awesome",
    "Generic",
    "Handcrafted",
    "Handmade",
    "Licensed",
    "Refined",
    "Unbranded",
    "Tasty" };

        public static string[] material = new string[] {     "Steel",
    "Wooden",
    "Concrete",
    "Plastic",
    "Cotton",
    "Granite",
    "Rubber",
    "Metal",
    "Soft",
    "Fresh",
    "Frozen"};

        public static string[] product = new string[] {    "Chair",
    "Car",
    "Computer",
    "Keyboard",
    "Mouse",
    "Bike",
    "Ball",
    "Gloves",
    "Pants",
    "Shirt",
    "Table",
    "Shoes",
    "Hat",
    "Towels",
    "Soap",
    "Tuna",
    "Chicken",
    "Fish",
    "Cheese",
    "Bacon",
    "Pizza",
    "Salad",
    "Sausages",
    "Chips" };
    }
}
