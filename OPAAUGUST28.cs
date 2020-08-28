using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelManager manager = new HotelManager();

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                String name = Console.ReadLine(); 
                String address = Console.ReadLine();
                float grade = float.Parse(Console.ReadLine());
                double averageRoomCharge =Convert.ToDouble(Console.ReadLine());
                int noOfRooms =Convert.ToInt32( Console.ReadLine());
                manager.AddHotel(name,address,grade,averageRoomCharge,noOfRooms);
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            // Enter code for handling the 2 operations
            //Choice 1 for fetchHotelBasedOnCharge
            //Choice 2 for countNoOfResorts
             #region solution1
            //Using switchcase for menu driven app.
            switch(choice)
            {
                case 1:
                        float grade = float.Parse(Console.ReadLine());
                        Hotel hotel;
                        hotel = manager.GetHotelBasedOnCharge(grade);
                        if(hotel == null){
                            Console.WriteLine("No such hotel available");
                        }
                        else
                        {
                            string grde = hotel.grade.ToString("#.0");
                            string arc = hotel.averageRoomCharge.ToString("####.0");
                            Console.WriteLine($"{hotel.name}#{hotel.address}#{arc}#{grde}");
                        }
                    break;
                case 2:
                        int noOfResorts = manager.CountNoOfResorts();
                        if(noOfResorts == 0)
                        {
                            Console.WriteLine("No Resort");
                        }
                        else{
                            Console.WriteLine(noOfResorts);
                        }
                    break;
                
            }


             #endregion
        }
    }
    // Create class Hotel with the required property and constructor
    #region solution2
    class Hotel
    {
        //parameters
        public string name {get; set;}
        public string address {get; set;}
        public float grade {get; set;}
        public double averageRoomCharge {get; set;}
        public int noOfRooms {get; set;}

        //Constructor: layout of the data to be stored into the list.
        public Hotel(string nme, string adds, float grd, double arc, int norooms){
            name = nme;
            address = adds;
            grade = grd;
            averageRoomCharge = arc;
            noOfRooms = norooms;

        }
    }
    #endregion

    // Create class HotelManager as per given specification
    // Write code for all 3 methods that would perform operations handled in solution1
    #region solution3
    class HotelManager
    {
        private static List<Hotel> hotels = new List<Hotel>(); //Declaring a private static list hotels of type Hotel class.

        //Getting the cheapest hotel
        public Hotel GetHotelBasedOnCharge(float grd)
        {
            Hotel hotel = null;
            if(!hotels.Any(g => g.grade > grd)){
                return null;
            }
            else{
                var getCheapestHotelQuery = hotels
                .Where(g => g.grade > grd)
                .OrderBy(h => h.averageRoomCharge)
                .Take(1);
                foreach(var h in getCheapestHotelQuery)
                {
                    hotel = h;
                };
                return hotel;
            }
        }

        //counting the number of resorts
        public int CountNoOfResorts()
        {
            int count =0;
            
            //getting just the name of hotels
            var getHotelNamesQuery = from h in hotels
                                select new {Name = h.name};
            
            //splitting Names
            foreach(var h in getHotelNamesQuery)
            {
                string[] hotelName = h.Name.Split(' ');
                
                //Checking if the name consists the word "resort"
                foreach(var n in hotelName) 
                {
                    if(n.ToLower() == "resort")
                    {
                        count++; //incrementing the count
                        break;
                    }
                }
            }
            return count != 0 ? count : 0; //return count
        }

        public void AddHotel(string nme, string adds, float grd, double arc, int norooms)
        {
            
            hotels.Add(new Hotel(nme, adds, grd, arc, norooms)); //Adding a hotel to the list.
        }
    }

    #endregion
}