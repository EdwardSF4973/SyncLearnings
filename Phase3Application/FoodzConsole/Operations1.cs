using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FoodzConsole
{
    public class Operations1
    {


        //Total for calculating the amount to be deducted
        public static double total = 0;

        //CustomList for customers to store the data
        static CustomList<CustomerDetails> customers = new CustomList<CustomerDetails>();
        //CustomList for Food details
        static CustomList<FoodDetails> foods = new CustomList<FoodDetails>();
        //CustomList for the Bookings data
        static CustomList<BookingDetails> bookings = new CustomList<BookingDetails>();
        //CustomList for the storing the cart data
        static CustomList<CarDetails> carts = new CustomList<CarDetails>();
        //CustomList for the Purchased items
        static CustomList<PurchasedItems> purchases = new CustomList<PurchasedItems>();

        //Variable to store the instance of Current Customer
        static CustomerDetails CurrentLoggedInCustomer;

        public static void ReadFromCSV()
        {
            FileHandling<CustomerDetails>.ReadFromCSV(customers);
            FileHandling<FoodDetails>.ReadFromCSV(foods);
            FileHandling<BookingDetails>.ReadFromCSV(bookings);
            FileHandling<CarDetails>.ReadFromCSV(carts);
            FileHandling<PurchasedItems>.ReadFromCSV(purchases);
        }

        public static void WriteToCSV()
        {
            FileHandling<CustomerDetails>.WriteToCSV(customers);
            FileHandling<FoodDetails>.WriteToCSV(foods);
            FileHandling<BookingDetails>.WriteToCSV(bookings);
            FileHandling<CarDetails>.WriteToCSV(carts);
            FileHandling<PurchasedItems>.WriteToCSV(purchases);
        }

        //Default Data
        public static void DefaultData()
        {
            //customer  Details
            CustomerDetails customer1 = new(10000, "Ravi", "Ettapparajan", GenderDetails.Male, "974774646", "11/11/1999", "ravi@gmail.com");
            CustomerDetails customer2 = new(0, "Baskaran", "Sethurajan", GenderDetails.Male, "847575775", "11/11/1999", "baskaran@gmail.com");
            //Adding to the lsit
            customers.AddRange(new CustomList<CustomerDetails>() { customer1, customer2 });


            //Food Data
            //foods
            FoodDetails food1 = new("Chicken Briyani 1Kg",12 ,100);
            FoodDetails food2 = new("Mutton Briyani 1Kg", 10, 150);
            FoodDetails food3 = new("Veg Full Meals", 30,80);
            FoodDetails food4 = new("Noodles", 40,100);
            FoodDetails food5 = new("Dosa", 40,40);
            FoodDetails food6 = new("Idly (2 pieces)", 50,20);
            FoodDetails food7 = new("Pongal", 20, 40);
            FoodDetails food8 = new("Vegetable Briyani", 15, 80);
            FoodDetails food9 = new("Lemon Rice", 3,50);
            FoodDetails food10 = new("Veg Pulav", 30,120);
            FoodDetails food11 = new("Chicken 65 (200 Grams)", 30,75);
            foods.AddRange(new CustomList<FoodDetails>() { food1, food2, food3, food4, food5, food6, food7, food8, food9, food10, food11, });
     
            //Grid<FoodDetails>.PrintTables(foods);

            //Booking Data
            BookingDetails book1 = new("CID1001", 220, "26/09/2024", BookingInfo.Booked);
            BookingDetails book2 = new("CID1002", 400, "24/09/2024", BookingInfo.Booked);
            BookingDetails book3 = new("CID1001", 280, "20/09/2024", BookingInfo.Cancelled);
            bookings.AddRange(new CustomList<BookingDetails>() { book1, book2, book3 });
            //Grid<BookingDetails>.PrintTables(bookings);

            //CartItem Data
            CarDetails cart1 = new("CID1002", "FID2002", 4, 200);
            CarDetails cart2 = new("CID1001", "FID2001", 2, 80);
            CarDetails cart3 = new("CID1002", "FID2003", 1, 40);
            carts.AddRange(new CustomList<CarDetails>() { cart1, cart2, cart3 });
            //Grid<CarDetails>.PrintTables(carts);

            //PurchasedItems Data
            PurchasedItems item1 = new("CRID4001", "BID3001", "FID2001", 2, 80);
            PurchasedItems item2 = new("CRID4002", "BID3001", "FID2002", 2, 100);
            PurchasedItems item3 = new("CRID4003", "BID3001", "FID2003", 1, 40);
            PurchasedItems item4 = new("CRID4004", "BID3002", "FID2001", 1, 40);
            PurchasedItems item5 = new("CRID4005", "BID3002", "FID2002", 4, 200);
            PurchasedItems item6 = new("CRID4006", "BID3002", "FID2010", 1, 140);
            PurchasedItems item7 = new("CRID4007", "BID3002", "FID2009", 1, 20);
            PurchasedItems item8 = new("CRID4008", "BID3003", "FID2002", 2, 100);
            PurchasedItems item9 = new("CRID4009", "BID3003", "FID2008", 4, 100);
            PurchasedItems item10 = new("CRID4010", "BID3003", "FID2001", 2, 80);
            purchases.AddRange(new CustomList<PurchasedItems>() { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 });
            //Grid<PurchasedItems>.PrintTables(purchases);
        }

        public static void MainMenu()
        {
            //Flag for the exit the do while loop 
            bool flag = true;

            do
            {

                System.Console.WriteLine("Welcome to Cafetaria");
                //asking the user for the action to be done
                System.Console.WriteLine("Enter \n1.Registration\n2.Login\n3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            //registering a new user
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            //Login for the user 
                            Login();
                            break;
                        }
                    case 3:
                        {
                            //Convert the flag to exit the loop
                            flag = false;
                            break;
                        }
                }

            } while (flag);//Looping Condition
        }

        public static void Registration()
        {
            //getting the information from the user for registration
            System.Console.WriteLine("Registration\n");
            //asking the details
            System.Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Your FatherName");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter Your Gender");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            System.Console.WriteLine("Enter your MobileNumber");
            string mobile = Console.ReadLine();
            System.Console.WriteLine("Enter your Date Of Birth");
            string dob = Console.ReadLine();
            System.Console.WriteLine("Enter Mail ID");
            string mailID = Console.ReadLine();
            System.Console.WriteLine("Enter the WalletBalance");
            double walletBalance = double.Parse(Console.ReadLine());


            //creating an instance for the carts
            //Adding the information the users CustomList
            CustomerDetails cust = new(walletBalance, name, fatherName, gender, mobile, dob, mailID);
            //Adding to the CustomList
            customers.Add(cust);
            //showing the customer id
            System.Console.WriteLine($"Registratiomn is Successfull \n Your CustomerID : {cust.CustomerID}");
        }

        public static void Login()
        {
            //flag for the displaying the wrong userID
            bool flag = true;

            System.Console.WriteLine("Login Page\n");

            //Asking and getting the UserID from the user
            System.Console.WriteLine("Enter Your CustomerID");
            string cID = Console.ReadLine().ToUpper();

            foreach (CustomerDetails cust in customers)
            {
                //checks each id is equals to customer id 
                if (cust.CustomerID.Equals(cID))
                {
                    //flag false as the userid is available
                    flag = false;
                    //saving the user instance to the variable current loggedinuser
                    CurrentLoggedInCustomer = cust;
                    //calling submenu function
                    SubMenu();
                    //break if once the user id equals
                    break;
                }
            }
            if (flag)
            {
                //print if the user enters a wrong id
                System.Console.WriteLine("Wrong CustomerID");
            }


        }

        public static void SubMenu()
        {
            //bool flag for the exit
            bool flag = true;
            do
            {
                //ask and the action to be performed by the user
                System.Console.WriteLine("Sub Menu");
                System.Console.WriteLine("Enter The Option\n1.Show Customer Details\n2.Show Food Details\n3.Wallet Recharge\n4.Add To Cart\n5.Purchase\n6.Cancel Booking\n7.Booking History\n8.Show Balance\n9.Exit");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            //This function show the customer details
                            ShowCustomerDetails();
                            break;
                        }
                    case 2:
                        {
                            //This shows the food details in the food CustomList
                            ShowFoodDetails();
                            break;
                        }
                    case 3:
                        {
                            //This will get the amount to recharged in the user wallet
                            WalletRecharge();
                            break;
                        }
                    case 4:
                        {
                            //get the food id and add it to the cart CustomList
                            AddToCart();
                            break;
                        }
                    case 5:
                        {
                            //This method provides confirm delete and modify the cart
                            FoodOrder();
                            break;
                        }
                    case 6:
                        {
                            //This cancel the booking
                            CancelBooking();
                            break;
                        }
                    case 7:
                        {
                            //this shows the booking history of the current customer
                            BookingHistory();
                            break;
                        }
                    case 8:
                        {
                            //This function is to show the balance from the user's wallet
                            ShowBalance();
                            break;
                        }
                    case 9:
                        {
                            //termination the loop
                            flag = false;
                            break;
                        }
                    case 10:
                        {
                            //this function is created for my usage
                            showcart();
                            break;
                        }



                }
            } while (flag);//looping condition
        }

        public static void BookingHistory()
        {
            //creating a temparary CustomList for storing the booking details of the current user
            CustomList<BookingDetails> userB = new CustomList<BookingDetails>();

            foreach (BookingDetails bo in bookings)
            {
                //Checks the condition and add to the temp CustomList for shoowing it
                if (bo.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID))
                {
                    userB.Add(bo);
                }
            }
            //if it is not empty 
            if (userB.Count > 0)
            {
                //it prints the CustomList
                Grid<BookingDetails>.PrintTables(userB);
            }
            else
            {
                //else show no history
                System.Console.WriteLine("\n\nNo History");
            }


        }

        public static void showcart()
        {
            //this function is for me to keeping track the cart items
            Grid<CarDetails>.PrintTables(carts);
        }

        public static void ShowCustomerDetails()
        {
            //create a temp CustomList for the customerdetails to store the instance of current user
            CustomList<CustomerDetails> cu = new CustomList<CustomerDetails>();
            foreach (CustomerDetails cus in customers)
            {
                //checks the condition and add it to the CustomList
                if (cus.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID))
                {
                    cu.Add(cus);
                    break;
                }
            }
            //print the CustomList via grid function
            Grid<CustomerDetails>.PrintTables(cu);
        }
        public static void ShowFoodDetails()
        {
            //Grid shows the entire food CustomList
            Grid<FoodDetails>.PrintTables(foods);
        }
        public static void ShowBalance()
        {
            //To sghow the balance of the user
            System.Console.WriteLine($"Your Current Balance is : {CurrentLoggedInCustomer.WalletBalance}");
        }

        public static void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to be recharged");
            double amount = double.Parse(Console.ReadLine());

            if (amount > 0)
            {
                CurrentLoggedInCustomer.WalletRecharge(amount);
            }
            else { System.Console.WriteLine("Enter a Valid Amount"); }
        }



        public static void AddToCart()
        {
            //bool flag if food id not there
            bool flag = true;

            //string choice to ask the user to add the new or not
            string choice = "";
            do
            {
                //Show the foods of “available foods” by traversing the foods CustomList.
                Grid<FoodDetails>.PrintTables(foods);
                //Ask the customer to select a food by using “FoodID”.
                System.Console.WriteLine("Enter the FoodID to be Added");
                string fID = Console.ReadLine().ToUpper();

                foreach (FoodDetails fo in foods)
                {
                    //Validate if the entered “FoodID is valid” by traversing the food’s CustomList. If the FoodID is not valid, 
                    // then show “FoodID is Invalid. Please enter the FoodID again”.
                    if (fo.FoodID.Equals(fID))
                    {
                        flag = false;
                        //If the FoodID is valid, ask the customer to enter the quantity of 
                        // the food the customer wants to order.
                        System.Console.WriteLine("Enter the Food Count to be Added");
                        int quan = int.Parse(Console.ReadLine());

                        //Then create cart object (CartID should auto incremented) with CustomerID, FoodID, FoodCount 
                        // entered by the customer, PriceOfCart for the selected quantity, 
                        // then add the created cart object to the cartItemsList then show “Food Successfully added to Cart”.

                        CarDetails cart = new(CurrentLoggedInCustomer.CustomerID, fo.FoodID, quan, fo.PricePerQuantity * quan);
                        carts.Add(cart);
                        //fo.QuantityAvailable = fo.QuantityAvailable - quan;
                        System.Console.WriteLine("Food SuccessFully Added");

                    }
                }
                //ask the user to add new or not
                System.Console.WriteLine("Do you need to Add more items");
                choice = Console.ReadLine().ToLower();
            } while (choice == "yes");//only runs when user enters yes 

            if (flag)
            {
                //Display messge for the food id is wrong
                System.Console.WriteLine("FoodID id Invalid\nPlease Enter the FoodID again");
            }
        }

        //temp CustomList for store the food of the current user
        static CustomList<CarDetails> foodCart = new CustomList<CarDetails>();
        //string CustomList to store the cart id belongs to the user
        static CustomList<String> cartIDS = new CustomList<string>();


        public static void FoodOrder()
        {
            //creates a temp CustomList for storing to validate the count
            CustomList<CarDetails> crt = new CustomList<CarDetails>();
            foreach (CarDetails cart in carts)
            {
                if (cart.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID))
                {
                    //adds the cart in crt only for the user
                    crt.Add(cart);
                }
            }
            //it stores the cart id for removal in future
            foreach (CarDetails car in crt)
            {
                //adds the cart ids to the string CustomList
                cartIDS.Add(car.CartID);
            }

            foreach (CarDetails cart in crt)
            {
                //bool flag for the food in out of stock
                bool flag = true;
                foreach (FoodDetails fo in foods)
                {
                    //checks the condition if the cart belongs to the current user and if the available count
                    if (fo.FoodID.Equals(cart.FoodID) && fo.QuantityAvailable >= cart.PurchaseCount)
                    {
                        flag = false;//set flase for the instock
                        System.Console.WriteLine($"Food Name : {cart.CartID} , Status : Instock");
                        //adds the valid cart to the foodCart CustomList foreasy tracking
                        foodCart.Add(cart);
                        //add the total amount if the valid foods only
                        total += cart.PriceOfCart;
                    }

                }
                if (flag)
                {
                    //food that are out of stock
                    System.Console.WriteLine($"Food Name : {cart.CartID} , Status : OutOfstock");
                }
            }
            //calls the food menu for furuther options
            FoodMenu();
        }


        public static void PrintCustomerValidCart()
        {
            //print the customers valid carts
            Grid<CarDetails>.PrintTables(foodCart);
        }


        public static void FoodMenu()
        {
            //flag for the exit 
            bool flag = true;
            do
            {
                //Food menu 
                System.Console.WriteLine("Food Menu");
                //ask and get the info from user to perform the action 
                System.Console.WriteLine("Press for\n1.Confirm Order\n2.Modify Cart Item\n3.Delete Cart Item\n4.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            //confirm the order in the foodCart CustomList
                            ConfirmOrder();
                            break;
                        }
                    case 2:
                        {
                            //Modify the CustomList before the cart
                            ModifyCart();
                            break;
                        }
                    case 3:
                        {
                            //delete the cart as getting the cart ID
                            DeleteCart();
                            break;
                        }
                    case 4:
                        {
                            //Condition for the flase for exit the loop ie sub menu
                            flag = false;
                            break;
                        }
                    case 5:
                        {
                            //this for my tracking
                            PrintCustomerValidCart();
                            break;
                        }
                }

            } while (flag);//looping condition
        }

        public static void ConfirmOrder()

        {
            //flag for the balance 
            bool flag = true;
            //flag for booking
            bool bookFlag = false;
            //check the is there any valid cart
            if (foodCart.Count > 0)
            {
                do
                {
                    //check the condition for the balance avail in balance ir not
                    if (CurrentLoggedInCustomer.WalletBalance >= total)
                    {
                        //if avail it deduct the balance
                        CurrentLoggedInCustomer.DeductBalance(total);
                        //converts it to false
                        flag = false;
                        bookFlag = true;

                    }
                    else
                    {
                        //asking the user to get recharge or not
                        System.Console.WriteLine("Do you wish to Recharge");
                        string choice = Console.ReadLine().ToLower();
                        //if user enters yes it will ask for the amount
                        if (choice == "yes")
                        {
                            //calling the walletReacharge
                            WalletRecharge();
                        }
                        else
                        {
                            //break the loop if the user say other than yes
                            break;
                        }

                    }

                } while (flag);
                //checks and enters if and only 
                if (bookFlag)
                {
                    //creating an new booking
                    BookingDetails book = new(CurrentLoggedInCustomer.CustomerID, total, "17/02/20", BookingInfo.Booked);
                    //adding to the booking CustomList
                    bookings.Add(book);
                    //print the booking id
                    System.Console.WriteLine($"Your Booking is successfull {book.BookingID}");
                    //deduct the food count as per the purchase count
                    foreach(CarDetails fc in foodCart)
                    {
                      foreach (FoodDetails food in foods)
                        {
                            if (food.FoodID.Equals(fc.FoodID))
                            {
                                //minus the food count
                                food.QuantityAvailable -= fc.PurchaseCount;
                            }
                        }
                    }
                    //for loop for removing all the cart 
                    for (int i = 0; i < carts.Count - 1; i++)
                    {
                        foreach (string id in cartIDS)
                        {
                            if (carts[i].CartID.Equals(id))
                            {
                                //removing akk the instock and outofstock cart in the cart CustomList
                                carts.Remove(carts[i]);
                            }
                        }

                    }
                    //removint the foodcart once the booking is placed
                    for (int i = 0; i < foodCart.Count; i++)
                    {
                        foreach (string cID in cartIDS)
                        {
                            if (foodCart[i].CartID.Equals(cID))
                            {
                                //clearing the CustomList for the foodcart
                                foodCart.Remove(foodCart[i]);
                            }

                        }

                    }


                }
            }

            else
            {
                System.Console.WriteLine("No Pending Order");
            }

        }

        public static void ModifyCart()
        {
            //bool for invalid id
            bool flag = true;
            if (foodCart.Count > 0)
            {
                //shows the cart and modify the count
                Grid<CarDetails>.PrintTables(foodCart);
                //asking and getting the user for cart id to modify
                System.Console.WriteLine("Enter the cart id to modify ");
                string cID = Console.ReadLine().ToUpper();



                foreach (CarDetails ct in carts)
                {
                    if (ct.CartID.Equals(cID))
                    {
                        //asking the amount from the user
                        System.Console.WriteLine("Enter the Count");
                        int amount = int.Parse(Console.ReadLine());
                        //change the amount
                        ct.PurchaseCount = amount;
                        //changing the bool
                        flag = false;
                    }
                }
            }
            else
            {
                //cart to if no carts are available
                System.Console.WriteLine("No cart to be modified");
            }
            if (flag)
            {
                //printing for theinvalid flag
                System.Console.WriteLine("Invlaid Flag");
            }
            

        }

        public static void DeleteCart()

        {
            if (foodCart.Count > 0)
            {
                Grid<CarDetails>.PrintTables(foodCart);

                System.Console.WriteLine("Enter Cart Id to be removed");
                string cID = Console.ReadLine().ToUpper();

                foreach (CarDetails cat in carts)
                {
                    if (cat.CartID.Equals(cID))
                    {
                        carts.Remove(cat);
                        break;
                    }
                }
                System.Console.WriteLine("Cart was deleted");
            }
            else
            {
                System.Console.WriteLine("No Carts are there to be deleted");
            }
        }


        public static void CancelBooking()
        {
            bool flag = true;
            //Show the current customer’s order details by traversing the bookings CustomList whose OrderStatus is ordered.
            CustomList<BookingDetails> bk = new CustomList<BookingDetails>();
            foreach (BookingDetails b in bookings)
            {
                if (b.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID) && b.BookingStatus == BookingInfo.Booked)
                {
                    bk.Add(b);
                }
            }
            string bID = "";
            if (bk.Count > 0)
            {
                Grid<BookingDetails>.PrintTables(bk);
                System.Console.WriteLine("Enter the bookingID to be cancelled");
                bID = Console.ReadLine().ToUpper();
            }

            //Ask the customer to choose one BookingID to cancel, then 
            // validate if the chosen BookingID is present and its status is ordered.



            foreach (BookingDetails b in bookings)
            {
                if (b.BookingID.Equals(bID) && b.BookingStatus == BookingInfo.Booked)
                {
                    flag = false;
                    b.BookingStatus = BookingInfo.Cancelled;
                    CurrentLoggedInCustomer.WalletRecharge(b.TotalPrice);
                    //food return
                    foreach (PurchasedItems pi in purchases)
                    {
                        foreach (FoodDetails fd in foods)
                        {
                            if (b.BookingID.Equals(pi.BookingID) && fd.FoodID.Equals(pi.FoodID))
                            {
                                //If the OrderID is valid, then update the current chosen order’s 
                                // booking status as cancelled and return the TotalPrice for the 
                                // order to the customer’s wallet balance. Also, return the ordered item’s FoodCount 
                                // to food details quantity. 
                                fd.QuantityAvailable += pi.PurchaseCount;
                            }
                        }
                    }
                    //Then, show “Order Cancelled Successfully”.

                }
            }
            if (flag)
            {
                //If the BookingID is not valid, then show “Invalid BookingID” and show the Sub Menu options.
                System.Console.WriteLine("No Bookings \n     Or      \n Invalid BookingID");
            }
            else
            {
                //cancelled successfully
                System.Console.WriteLine("Order Cancelled Successfully");
            }

        }
    }

}






