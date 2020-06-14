/*
* Author: Vishva Patel
  Problem: To build a console application for shopping shop to manage orders of its users.
  Asked in: TCS OPA June 12th 2020
  Github: vishvapatel/.NET-Console-Apps
*/

using System;
using System.Linq;
using System.Collectons.Generic;
using System.Text;

class Program
{
    public static void Main(string args[])
    {
        //Given
        List<User> users = new List<User>
        User1 = new User("Mohit", 21, "Surat");  users.Add(user1);
        user2 = new User("Pansingh", 24, "Bhatinda"); users.Add(user2);
        user3 = new User("Priya", 21, "Mumbai"); users.Add(user3);
        user4 = new User("Manoj", 25, "Indore"); users.Add(user4);
        user5 = new User("Vihan", 30, "Banglore"); users.Add(user5);
        //Given    
        List<Orders> orderlist = new List<Orders>
        int choice  = Convert.ToInt32(Console.ReadLine());
        
        //From here the coding starts
        
        switch (choice)
        {
            //This case deals for placing orders based on checking some conditions.
            case 1: string name = Console.ReadLine();
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    int price = Convert.ToInt32(Console.ReadLine());
                    DateTime orderdate = Convert.ToDateTime(Console.ReadLine());
                    string address =Console.ReadLine();
                    if(quantity <= 0){
                        Console.WriteLine("There should be atleast 1 quantity");
                        break;
                    }
                    else{
                        if(price <=0){
                            Console.WriteLine("Invalid Price");
                            break;
                        }else{
                            if(orderdate.Date > DateTime.Now.Date){
                                Console.WriteLine("Order date cannot be a future date");
                                break;
                            }
                            else{
                                orderlist.Add(new Orders(name, orderdate, quantity, price, address));
                                Console.WriteLine("Order placed successfully");    
                            }
                        }
                    }
                break;
            //This case returns the 5 Most expensive orders from te order list.
            case 2:
                var expensive = (from od in orderlist
                                order by od.price
                                select od).Take(5);
                foreach (var order in orderlist)
                {
                    Console.WriteLine($"{order.name} placed order on {order.orderdate} with {order.quantity} item(s) for price {order.price} to {order.address}");
                }

            break;

            //This case deals with listing orders where delivery address was not user's home address.
            case 3:
                    foreach(Orders order in orderlist){
                        foreach (User us in users)
                        {
                            if(order.name == us.name){
                                if(order.address != us.address){
                                    Console.WriteLine($"{order.name} placed order on {order.orderdate} with {order.quantity} item(s) for price {order.price} to {order.address} instead of {us.address}");
                                }
                            }
                        }
                    }
                break;
        }

    }

}


class User
{
    public string name; //User's name
    public int age; //User's age
    public string address; //User's Home address.

    public User(string nme, int ag, string add)
    {
        name = nme;
        age = ag;
        address = add;
    }

}

class Orders
{
    public string name; //User name
    public int quantity; // Quantity of an item
    public int price; // price total
    public DateTime orderdate; // order date which cannot be a future date.
    public string address; // Delivery address.

    public Orders(string nme, DateTime od, int quanty, int prce, string add)
    {
        name = nme;
        orderdate = od;
        price = prce;
        orderdate = od;
        address = add;
    }

}