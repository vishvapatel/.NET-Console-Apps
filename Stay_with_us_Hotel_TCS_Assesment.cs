/*
 * Author: Vishva Patel
 * Program: Stay With us hotel problem.
 * Asked-in: TCS Unproctorred Assessment 24th April 2020
 * Github: vishvapatel/Csharp
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaywithusHotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            List<Guest> guestlist = new List<Guest>();
            Guest guest1 = new Guest("Radhika", 25, 2, 2, 20000);
            hotel.Classicroomcount--;
            Guest guest2 = new Guest("Saras", 25, 3, 3, 15000);
            hotel.Singleroomcount--;
            Guest guest3 = new Guest("Suman", 25, 10, 5, 50000);
            hotel.Deluxeroomcount--;

            guestlist.Add(guest1);
            guestlist.Add(guest2);
            guestlist.Add(guest3);
            Guest gue = new Guest();
            string guest_name;
            DateTime dob, checkout;
            int inmates,duration =0, rent;
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                     foreach(Guest gu in guestlist)
                    {
                        Console.WriteLine($"{gu.name}({gu.Age}) + {gu.inmates -1}, {gu.duration}day(s) - {gu.rent}");
                    }
                        break;
                case 2:
                    guest_name = Console.ReadLine();
                    dob = Convert.ToDateTime(Console.ReadLine());
                    checkout = Convert.ToDateTime(Console.ReadLine());
                    inmates = Convert.ToInt32(Console.ReadLine());
                    rent = Convert.ToInt32(Console.ReadLine());
                    int age = DateTime.Now.Year - dob.Year;
                    if (age <= 18)
                    {
                        Console.WriteLine("Guest is too young to accomodate");
                        
                    }
                    if(checkout.Date > gue.checkin.Date)
                    {
                        duration = Convert.ToInt32(checkout.Date - gue.checkin.Date);
                        if (duration <= 0)
                        {
                            Console.WriteLine("Duration should be greater than 0");
                            
                        }
                    }
                    if(inmates == 0)
                    {
                        Console.WriteLine("There should be at least one guest");
                    }
                    if(inmates == 1)
                    {
                        hotel.Singleroomcount--;
                    }
                    if(inmates >1 && inmates <= 3)
                    {
                        hotel.Classicroomcount--;
                    }
                    if (inmates > 3 && inmates <= 5)
                    {
                        hotel.Deluxeroomcount--;
                    }
                    if(inmates > 5)
                    {
                        Console.WriteLine("Guest should not be more than 5");
                        break;
                    }
                    if(rent <= 0)
                    {
                        Console.WriteLine("Invalid amount");
                    }
                    if(hotel.Singleroomcount ==0 && hotel.Classicroomcount ==0 && hotel.Deluxeroomcount == 0)
                    {
                        Console.WriteLine($"{guest_name} cannot be accomodated as no rooms are available");
                        
                    }
                    Guest g = new Guest(guest_name,age,duration,inmates,rent) ;
                    guestlist.Add(g);
                    Console.WriteLine($"{guest_name} was added to the guest list");
                    break;

               case 3:
                    Console.WriteLine($"Single Rooms - {hotel.Singleroomcount}");
                    Console.WriteLine($"Classic Rooms - {hotel.Classicroomcount}");
                    Console.WriteLine($"Deluxe Rooms - {hotel.Deluxeroomcount}");
                    break;
               case 4:
                    string nme = Console.ReadLine();
                    DateTime dob1 = Convert.ToDateTime(Console.ReadLine());
                    int ag = DateTime.Now.Year - dob1.Year;
                    bool flag = true;
                    foreach(Guest guest in guestlist)
                    {
                        if(guest.name == nme && guest.Age == ag)
                        {
                            flag = false;
                            Console.WriteLine($"{guest.name}({guest.Age}) + {guest.inmates - 1}, {guest.duration}day(s) - {guest.rent}");
                            if (guest.inmates == 1)
                            {
                                hotel.Singleroomcount++;
                            }
                            if (guest.inmates > 1 && guest.inmates <= 3)
                            {
                                hotel.Classicroomcount++;
                            }
                            if (guest.inmates > 3 && guest.inmates <= 5)
                            {
                                hotel.Deluxeroomcount++;
                            }
                            guestlist.Remove(guest);
                        }
                    }
                    if (flag == true)
                    {
                        Console.WriteLine($"Guest with {nme} aged {ag} was not found");
                    }
                    break;
            }
        }
    }
    class Hotel
    {
        public int Singleroomcount = 5;
        public int Classicroomcount = 3;
        public int Deluxeroomcount = 2;

    }
    class Guest 
    {
        public string name;
        public int rent;
        public DateTime checkin = DateTime.Now;
        public int duration;
        public int Age;
        public int inmates;
        public Guest() { }
        public Guest(string name, int Age, int duratin,int inmates, int rent)
        {
            this.name = name;
            this.Age = Age;
            duration = duratin;
            this.inmates = inmates;
            this.rent = rent;
        }
    }
}
