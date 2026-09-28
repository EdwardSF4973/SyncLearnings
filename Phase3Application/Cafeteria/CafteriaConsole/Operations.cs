using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CafteriaConsole
{
    public class Operations
    {
        static List<CustomerDetails> customers = new List<CustomerDetails>();

        static List<FoodDetails> foods = new List<FoodDetails>();

        static List<BookingDetails> bookings = new List<BookingDetails>();

        static List<CarDetails> carts = new List<CarDetails>();

        static List<PurchasedItems> purchases = new List<PurchasedItems>();
        static CustomerDetails CurrentLoggedInCustomer;

        public static void DefaultData()
        {
            //customer  Details
            CustomerDetails customer1 = new(10000, "Ravi", "Ettapparajan", GenderDetails.Male, "974774646", "11/11/1999", "ravi@gmail.com");
            CustomerDetails customer2 = new(0, "Baskaran", "Sethurajan", GenderDetails.Male, "847575775", "11/11/1999", "baskaran@gmail.com");
            //Adding to the lsit
            customers.AddRange(new List<CustomerDetails>() { customer1, customer2 });


            //Food Data
            FoodDetails food1 = new("Coffee", 20, 40);
            FoodDetails food2 = new("Tea", 10, 50);
            FoodDetails food3 = new("Milk", 10, 4);
            FoodDetails food4 = new("Juice", 10, 10);
            FoodDetails food5 = new("Puff", 10, 10);
            FoodDetails food6 = new("Popcorn", 10, 20);
            FoodDetails food7 = new("Samosa", 10, 10);
            FoodDetails food8 = new("Sandwich", 10, 25);
            FoodDetails food9 = new("Pizza", 10, 20);
            FoodDetails food10 = new("Burger", 10, 140);
            //Adding to the list
            foods.AddRange(new List<FoodDetails>() { food1, food2, food3, food4, food5, food6, food7, food8, food9, food10 });
            //Grid<FoodDetails>.PrintTables(foods);

            //Booking Data
            BookingDetails book1 = new("CID1001", 220, "26/09/2024", BookingInfo.Booked);
            BookingDetails book2 = new("CID1002", 400, "24/09/2024", BookingInfo.Booked);
            BookingDetails book3 = new("CID1001", 280, "20/09/2024", BookingInfo.Cancelled);
            bookings.AddRange(new List<BookingDetails>() { book1, book2, book3 });
            //Grid<BookingDetails>.PrintTables(bookings);

            //CartItem Data
            CarDetails cart1 = new("CID1002", "FID2002", 4, 200);
            CarDetails cart2 = new("CID1001", "FID2001", 2, 80);
            CarDetails cart3 = new("CID1002", "FID2003", 1, 40);
            carts.AddRange(new List<CarDetails>() { cart1, cart2, cart3 });
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
            purchases.AddRange(new List<PurchasedItems>() { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 });
            //Grid<PurchasedItems>.PrintTables(purchases);



        }

        public static void MainMenu()
        {
            bool flag = true;

            do
            {
                System.Console.WriteLine("Welcome to Cafetaria");
                System.Console.WriteLine("Enter \n1.Registration\n2.Login\n3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Login();
                            break;
                        }
                    case 3:
                        {
                            flag = false;
                            break;
                        }
                }

            } while (flag);
        }


        public static void Registration()
        {
            System.Console.WriteLine("Registration\n");

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

            CustomerDetails cust = new(walletBalance, name, fatherName, gender, mobile, dob, mailID);
            customers.Add(cust);

            System.Console.WriteLine($"Registratiomn is Successfull \n Your CustomerID : {cust.CustomerID}");
        }

        public static void Login()
        {
            bool flag = true;
            System.Console.WriteLine("Login Page\n");

            System.Console.WriteLine("Enter Your CustomerID");
            string cID = Console.ReadLine().ToUpper();

            foreach (CustomerDetails cust in customers)
            {
                if (cust.CustomerID.Equals(cID))
                {
                    flag = false;
                    CurrentLoggedInCustomer = cust;
                    SubMenu();

                    break;
                }
            }
            if (flag)
            {
                System.Console.WriteLine("Wrong CustomerID");
            }


        }

        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("Sub Menu");
                System.Console.WriteLine("Enter The Option\n1.Show Customer Details\n2.Show Food Details\n3.Wallet Recharge\n4.Add To Cart\n5.Purchase\n6.Cancel Booking\n7.Booking History\n8.Show Balance\n9.Exit");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            ShowCustomerDetails();
                            break;
                        }
                    case 2:
                        {
                            ShowFoodDetails();
                            break;
                        }
                    case 3:
                        {
                            WalletRecharge();
                            break;
                        }
                    case 4:
                        {
                            AddToCart();
                            break;
                        }
                    case 5:
                        {
                            FoodOrder();
                            break;
                        }
                    case 6:
                        {
                            CancelBooking();
                            break;
                        }
                    case 7:
                        {
                            BookingHistory();
                            break;
                        }
                    case 8:
                        {
                            ShowBalance();
                            break;
                        }
                    case 9:
                        {
                            flag = false;
                            break;
                        }
                    case 10:
                        {
                            CustomerListDetails();
                            break;
                        }
                    case 11:
                        {
                            Discart();
                            break;
                        }

                }
            } while (flag);
        }

        public static void ShowCustomerDetails()
        {
            List<CustomerDetails> cu = new List<CustomerDetails>();
            foreach (CustomerDetails cus in customers)
            {
                if (cus.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID))
                {
                    cu.Add(cus);
                    break;
                }
            }
            Grid<CustomerDetails>.PrintTables(cu);
        }
        public static void ShowFoodDetails()
        {
            Grid<FoodDetails>.PrintTables(foods);
        }
        public static void ShowBalance()
        {
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

        public static void BookingHistory()
        {
            bool flag = true;
            List<BookingDetails> userB = new List<BookingDetails>();

            foreach (BookingDetails bo in bookings)
            {
                if (bo.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID))
                {
                    userB.Add(bo);
                }
            }
            if (userB.Count > 0)
            {
                Grid<BookingDetails>.PrintTables(userB);
            }
            else
            {
                System.Console.WriteLine("\n\nNo History");
            }


        }
        /*10*/
        public static void CustomerListDetails()
        {
            Grid<CustomerDetails>.PrintTables(customers);
        }

        public static List<CarDetails> foodCart = new List<CarDetails>();
        public static void FoodOrder()
        {
            List<CarDetails> crt = new List<CarDetails>();
            bool flag = true;
            string name = "";
            //int total = 0;
            foreach (CarDetails cart in carts)
            {
                if (cart.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID))
                {
                    crt.Add(cart);
                }

            }
            Grid<CarDetails>.PrintTables(crt);
            foreach (CarDetails cart in crt)
            {
                foreach (FoodDetails fo in foods)
                {
                    if (fo.FoodID.Equals(cart.FoodID) && fo.QuantityAvailable >= cart.PurchaseCount && cart.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID))
                    {
                        flag = false;
                        System.Console.WriteLine($"Food Name : {fo.FoodName} , Status : Instock");
                        foodCart.Add(cart);
                        name = fo.FoodName;

                    }
                }
            }
            if (flag)
            {
                System.Console.WriteLine($"Food Name : {name} , Status : out of stock ");
            }
            else
            {
                System.Console.WriteLine("No");
            }

            FoodMenu();


        }
        public static void CusCarPri()
        {
            Grid<CarDetails>.PrintTables(carts);
        }

        public static void DeleteCart()
        {
            List<CarDetails> ct = new List<CarDetails>();
            foreach (CarDetails car in carts)
            {
                if (car.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID))
                {
                    ct.Add(car);
                }
            }
            Grid<CarDetails>.PrintTables(ct);

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

        public static void ModifyCart()
        {
            CusCarPri();

            System.Console.WriteLine("Enter the cart id to modify ");
            string cID = Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter the amount");
            int amount = int.Parse(Console.ReadLine());

            foreach (CarDetails ct in carts)
            {
                if (ct.CartID.Equals(cID))
                {
                    ct.PurchaseCount = amount;

                }
            }
        }

        public static void CancelBooking()
        {
            bool flag = true;
            //Show the current customer’s order details by traversing the bookings list whose OrderStatus is ordered.
            List<BookingDetails> bk = new List<BookingDetails>();
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
                System.Console.WriteLine("Order Cancelled Successfully");
            }

        }

        /*4*/
        public static void AddToCart()
        {
            bool flag = true;
            double total = 0;
            string choice = "";
            do
            {
                //Show the foods of “available foods” by traversing the foods list.
                Grid<FoodDetails>.PrintTables(foods);
                //Ask the customer to select a food by using “FoodID”.
                System.Console.WriteLine("Enter the FoodID to be Added");
                string fID = Console.ReadLine().ToUpper();

                foreach (FoodDetails fo in foods)
                {
                    //Validate if the entered “FoodID is valid” by traversing the food’s list. If the FoodID is not valid, 
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
                System.Console.WriteLine("Do you need to Add more items");
                choice = Console.ReadLine().ToLower();
            } while (choice == "yes");

            if (flag)
            {
                System.Console.WriteLine("FoodID id Invalid\nPlease Enter the FoodID again");
            }
        }

        public static void Discart()
        {
            Grid<CarDetails>.PrintTables(carts);
        }

        /*public static void Purchase()
        {


            foreach (CarDetails cart in carts)
            {
                if (cart.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID))
                {
                    crt.Add(cart);
                }

            }
            System.Console.WriteLine("Hi");
            Grid<CarDetails>.PrintTables(crt);
            foreach (CarDetails ct in crt)
            {
                
                foreach (FoodDetails fo in foods)
                {
                    
                        if(fo.FoodID.Equals(ct.FoodID) && fo.QuantityAvailable>=ct.PurchaseCount)
                        {
                            System.Console.WriteLine($"{fo.FoodName}  Instoock");
                        }
                        

                    
                    
                    

                }
            }





            /*bool flag = false;
            foreach (CarDetails cart in crt)
            {
                if (CurrentLoggedInCustomer.CustomerID.Equals(cart.CustomerID))
                {
                    flag = true;
                    foreach (FoodDetails fo in foods)

                    {
                        //1
                        // flag = false;
                        if (fo.QuantityAvailable >= cart.PurchaseCount && fo.FoodID.Equals(cart.FoodID))
                        {

                            //System.Console.WriteLine($"   CartID      | FoodName       |       Staus ");
                            //System.Console.WriteLine($"{cart.CartID}  | {fo.FoodName}  |  Staus : INstock");

                            System.Console.WriteLine($"Food Name : {fo.FoodName} , Status : Instock");

                        }
                        else
                        {
                            //System.Console.WriteLine($"   CartID      | FoodName       |       Staus ");
                            //System.Console.WriteLine($"{cart.CartID}  | {fo.FoodName}  |  Staus : OutOfStock");
                            System.Console.WriteLine($"Food Name : {fo.FoodName} , Status : OutofStock");
                        }
                    }


                }

            }

            FoodMenu();
        }*/
        public static void FoodMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("Food Menu");
                System.Console.WriteLine("Press for\n1.Confirm Order\n2.Modify Cart Item\n3.Delete Cart Item\n4.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            ConfirmOrder();
                            break;
                        }
                    case 2:
                        {
                            ModifyCart();
                            break;
                        }
                    case 3:
                        {
                            DeleteCart();
                            break;
                        }
                    case 4:
                        {
                            flag = false;
                            break;
                        }
                    case 5:
                        {

                            break;
                        }
                }

            } while (flag);
        }

        /*public static void C1onfirmorder()
        {
            string id = "";
            //bool printflag = false;
            bool flag = true;
            double totalPrice = 0;

            foreach (CarDetails cart in carts)
            {

                if (cart.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID) && book.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID))
                {
                    totalPrice += cart.PriceOfCart;

                    do
                    {
                        if (CurrentLoggedInCustomer.WalletBalance >= totalPrice)
                        {
                            flag = false;
                            CurrentLoggedInCustomer.DeductBalance(totalPrice);
                            PurchasedItems pur = new(cart.CartID, cart.FoodID, book.BookingID, cart.PurchaseCount, totalPrice);
                            purchases.Add(pur);

                            id = pur.PurchaseID;
                            System.Console.WriteLine($"Purchase is added to the list {id}");

                        }
                        else
                        {
                            System.Console.WriteLine("Insufficient balance do a recharge");
                            WalletRecharge();
                        }

                    } while (flag);


                }
            }
        }*/

        public static void ConfirmOrder()
        {
            bool quantityFlag = true;
            bool balanceFlag = true;


            foreach (CarDetails cart in carts)
            {
                foreach (FoodDetails food in foods)
                {
                    if (cart.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID))
                        if (cart.PurchaseCount <= food.QuantityAvailable)
                        {
                            quantityFlag = false;
                            if (cart.PriceOfCart <= CurrentLoggedInCustomer.WalletBalance)
                            {
                                balanceFlag = true;


                            }

                        }
                }
            }

        }
        /*5*/
        public static void purchase1()
        {
            foreach (CarDetails cart in carts)
            {
                if (cart.CustomerID.Equals(CurrentLoggedInCustomer.CustomerID))
                {
                    foreach (FoodDetails food in foods)
                    {
                        if (cart.FoodID.Equals(food.FoodID))
                        {
                            if (food.QuantityAvailable >= cart.PurchaseCount)
                            {
                                System.Console.WriteLine($"FoodName : {food.FoodName}  --- InStock");
                            }
                            else
                            {
                                System.Console.WriteLine($"FoodName : {food.FoodName}  --- OutOfStock");
                            }
                        }
                    }
                }
            }
            FoodMenu();
        }


    }
}

