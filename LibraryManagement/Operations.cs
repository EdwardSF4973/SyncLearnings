using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Operations
    {
        //creating the list
        List<UserDetails> Users = new List<UserDetails>();
        List<BookDetails> Books = new List<BookDetails> { };
        List<BorrowDetails> BorrowBooks = new List<BorrowDetails>();
        //CurrentLoggedInUser for storing the current instances
        UserDetails currentUser;
        public void DefaultData()
        {
            //creating the user data and adding to list.
            UserDetails user1 = new UserDetails("Ravichandran", GenderClassification.male, DepartmentClassification.EEE, 9938388333, "ravi@gmail.com", 100);
            UserDetails user2 = new UserDetails("Priyadharshini", GenderClassification.female, DepartmentClassification.CSE, 9944444455, "priya@gmail.com", 150);
            Users.AddRange(new List<UserDetails>() { user1, user2 });
            //creating book list and inserting it.
            BookDetails book1 = new("C#", "Author1", BookAvailabilityStatus.issued);
            BookDetails book2 = new("C#", "Author1", BookAvailabilityStatus.issued);
            BookDetails book3 = new("C#", "Author1", BookAvailabilityStatus.issued);
            BookDetails book4 = new("HTML", "Author2", BookAvailabilityStatus.available);
            BookDetails book5 = new("HTML", "Author2", BookAvailabilityStatus.damaged);
            BookDetails book6 = new("CSS", "Author1", BookAvailabilityStatus.available);
            BookDetails book7 = new("CSS", "Author1", BookAvailabilityStatus.available);
            BookDetails book8 = new("JS", "Author1", BookAvailabilityStatus.available);
            BookDetails book9 = new("JS", "Author1", BookAvailabilityStatus.available);
            BookDetails book10 = new("JS", "Author1", BookAvailabilityStatus.available);
            BookDetails book11 = new("TS", "Author2", BookAvailabilityStatus.available);
            BookDetails book12 = new("TS", "Author2", BookAvailabilityStatus.damaged);
            BookDetails book13 = new("TS", "Author2", BookAvailabilityStatus.available);
            Books.AddRange(new List<BookDetails>() { book1, book2, book3, book4, book5, book6, book7, book8, book9, book10, book11, book12, book13 });
            //Creating Boorow list and adding it to the list
            //defalut 
            BorrowDetails borrow1 = new("BID1001", "SF3001", new DateTime(2024, 09, 10), BookReturnedStatus.Borrowed, 0);
            BorrowDetails borrow2 = new("BID1003", "SF3001", new DateTime(2024, 09, 12), BookReturnedStatus.Borrowed, 0);
            BorrowDetails borrow3 = new("BID1004", "SF3001", new DateTime(2024, 08, 14), BookReturnedStatus.Returned, 16);
            BorrowDetails borrow4 = new("BID1002", "SF3002", new DateTime(2024, 09, 11), BookReturnedStatus.Borrowed, 0);
            BorrowDetails borrow5 = new("BID1005", "SF3002", new DateTime(2024, 07, 07), BookReturnedStatus.Returned, 20);
            BorrowBooks.AddRange(new List<BorrowDetails>() { borrow1, borrow2, borrow3, borrow4, borrow5 });
        }
        public void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("1.Registration\n2.Login\n3.Exit");
                Console.WriteLine("Which operation do you want to perform:");
                switch (int.Parse(Console.ReadLine()))
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
                            Console.WriteLine("Exit");
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public void Registration()
        {
            // Ask and get user details
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your gender:");
            GenderClassification gender = Enum.Parse<GenderClassification>(Console.ReadLine().ToLower());
            Console.WriteLine("Enter your Department:");
            DepartmentClassification department = Enum.Parse<DepartmentClassification>(Console.ReadLine().ToUpper());
            Console.WriteLine("Enter Your mobile number:");
            long mobile = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your mailID:");
            string mailID = Console.ReadLine();
            Console.WriteLine("Enter your WalletBalnce:");
            double walletbalance = double.Parse(Console.ReadLine());
            UserDetails user = new UserDetails(name, gender, department, mobile, mailID, walletbalance);
            Users.Add(user);
            Console.WriteLine("Your Registration was successful.... and your registration ID is:" + user.UserID);
        }
        //Login() method is used to login into the application using userID, if the user is valid then,it shows the submenu as Borrowbook,Show Borrowed History,Return Books,Wallet Recharge and Exit
        public void Login()
        {
            Console.WriteLine("Enter your UserID:");
            string ID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (UserDetails user in Users)
            {
                bool flag1 = true;
                if (ID == user.UserID)
                {
                    currentUser = user;
                    flag = false;
                    do
                    {
                        Console.WriteLine("***SubMenu***");
                        Console.WriteLine("1.BorrowBook\n2.ShowBorrowedHistory\n3.ReturnBooks\n4.WalletRecharge\n5.Exit");
                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1:
                                {
                                    BorrowBook();
                                    break;
                                }
                            case 2:
                                {
                                    ShowBorrowedHistory();
                                    break;
                                }
                            case 3:
                                {
                                    ReturnBooks();
                                    break;
                                }
                            case 4:
                                {
                                    WalletRecharge();
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Exit");
                                    flag1 = false;
                                    break;
                                }
                        }
                    } while (flag1);
                }
            }
            Console.WriteLine(flag ? "Invalid user ID. Please enter a valid one" : "");
        }
        //BorrowBook() method is used to borrow the book
        public void BorrowBook()
        {
            foreach (BookDetails book in Books)
            {
                Console.WriteLine($"{book.BookID,-15}|{book.BookName,-15}|{book.AuthorName,-15}|{book.BookStatus}");
            }
            Console.WriteLine("Enter a Book ID to borrow:");
            string bookID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (BookDetails book in Books)
            {
                if (bookID.Equals(book.BookID))
                {
                    flag = false;
                    int count = 0;
                    bool flag1 = true;
                    foreach (BorrowDetails borrowbook in BorrowBooks)
                    {
                        if (borrowbook.UserID.Equals(currentUser.UserID))
                        {
                            count++;
                        }
                    }
                    if (count > 3)
                    {
                        Console.WriteLine("You have borrowed 3 books already");
                        flag1 = false;
                    }
                    if (flag1)
                    {
                        if (book.BookStatus.Equals(BookAvailabilityStatus.damaged))
                        {
                            Console.WriteLine("Book is in damaged condition");
                            break;

                        }
                        else if (book.BookStatus.Equals(BookAvailabilityStatus.available))
                        {
                            book.BookStatus = BookAvailabilityStatus.issued;
                            BorrowDetails borrowBook = new(book.BookID, currentUser.UserID, DateTime.Now.Date, BookReturnedStatus.Borrowed, 0);
                            BorrowBooks.Add(borrowBook);
                            Console.WriteLine("Book Borrowed successfully.Borrow ID :" + borrowBook.BorrowID);
                            break;
                        }
                        else
                        {
                            foreach (BorrowDetails borrowbook in BorrowBooks)
                            {
                                if (bookID.Equals(borrowbook.BookID))
                                {
                                    Console.WriteLine("The Book is available on " + (borrowbook.BorrowedDate.AddDays(15)).ToString("dd/MM/yyyy"));
                                    break;
                                }

                            }
                        }
                    }
                }
            }
            Console.WriteLine(flag ? "Invalid Book ID. Please Enter a valid one" : " ");
        }
        //ShowBorrowedHistory() method shows the history of Borrowed Books
        public void ShowBorrowedHistory()
        {
            bool flag = true;
            foreach (BorrowDetails userborrowbook in BorrowBooks)
            {
                if (userborrowbook.UserID == currentUser.UserID)
                {
                    Console.WriteLine($"{userborrowbook.BorrowID,-15}|{userborrowbook.BookID,-15}|{userborrowbook.UserID,-15}|{userborrowbook.BorrowedDate,-15}|{userborrowbook.BookReturnedStatus,-15}|{userborrowbook.PaidFineAmount,-15}");
                    flag = false;
                }
            }
            Console.WriteLine(flag ? "There is no book taken by  you!....." : "");
        }
        public void ReturnBooks()
        {
            bool flag = true;
            foreach (BorrowDetails userborrowbook in BorrowBooks)
            {
                if (userborrowbook.UserID == currentUser.UserID && userborrowbook.BookReturnedStatus.Equals(BookReturnedStatus.Borrowed))
                {
                    Console.WriteLine($"{userborrowbook.BorrowID,-15}|{userborrowbook.BookID,-15}|{userborrowbook.UserID,-15}|{userborrowbook.BorrowedDate,-15}|{userborrowbook.BookReturnedStatus,-15}|{userborrowbook.PaidFineAmount,-15}");
                    flag = false;
                }
            }
            Console.WriteLine(flag ? "There is no book taken by  you!....." : "");
            Console.WriteLine("Enter the BorrowID which you want to return:");
            string borrowID = Console.ReadLine().ToUpper();
            bool flag1 = true;
            foreach (BorrowDetails userborrowbook in BorrowBooks)
            {
                if (userborrowbook.BorrowID.Equals(borrowID))
                {
                    int daysexcited = userborrowbook.BorrowedDate.Subtract(DateTime.Now).Days;
                    flag1 = false;
                    double TotalFineAmount = 0;
                    if (daysexcited > 15)
                    {
                        double LateFine = (daysexcited - 15) * 1;
                        TotalFineAmount += LateFine;
                    }
                    Console.WriteLine("Book is damaged or not:");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                    {
                        TotalFineAmount += 300;
                        foreach (BookDetails book in Books)
                        {
                            if (userborrowbook.BookID.Equals(book.BookID))
                            {
                                book.BookStatus = BookAvailabilityStatus.damaged;
                                //Console.WriteLine("Book returned sucessfully!..");
                                break;
                            }
                        }
                    }
                    if (currentUser.WalletBalance >= TotalFineAmount)
                    {
                        currentUser.DeductBalance(TotalFineAmount);
                        userborrowbook.BookReturnedStatus = BookReturnedStatus.Returned;
                        userborrowbook.PaidFineAmount = TotalFineAmount;
                        foreach (BookDetails book in Books)
                        {
                            if (userborrowbook.BookID.Equals(book.BookID))
                            {
                                if (book.BookStatus.Equals(BookAvailabilityStatus.damaged))
                                {
                                    //book.BookStatus = BookAvailabilityStatus.damaged;
                                    Console.WriteLine("Book returned sucessfully!..");
                                    break;
                                }
                                else
                                {
                                    book.BookStatus = BookAvailabilityStatus.available;
                                    Console.WriteLine("Book returned sucessfully!..");
                                    break;

                                }


                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("You don't have  enough balance please recharge it");
                    }
                    break;
                }
            }
            Console.WriteLine(flag1 ? "Invalid BorrowID please enter the correct one" : "");
        }
        public void WalletRecharge()
        {
            Console.WriteLine("Enter the amount you want to recharge:");
            double amount = double.Parse(Console.ReadLine());
            currentUser.WalletBalance += amount;
            Console.WriteLine("Recharged successsfully");

        }
    }
}
