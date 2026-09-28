using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace SyncHospital
{
    public static class Operations
    {
        public static CustomList<DoctorDetails> doctors = new CustomList<DoctorDetails>();

        public static CustomList<AvailableSlotDetails> slots = new CustomList<AvailableSlotDetails>();

        public static CustomList<PatientDetails> patients = new CustomList<PatientDetails>();

        public static CustomList<AppointmentDetails> appoints = new CustomList<AppointmentDetails>();

        static PatientDetails currentLoggedInUser;

        public static void DefaultData()
        {
            //Enetring the docotrs data
            DoctorDetails doc1 = new("John", "Joe", Genders.Male, "89877", 33, "B+ve", 20, "General", 200);
            DoctorDetails doc2 = new("Saravanan", "Mani", Genders.Male, "98776", 39, "O+ve", 30, "Heart", 500);
            DoctorDetails doc3 = new("Kavi", "Karthi", Genders.Male, "77886", 34, "AB-ve", 40, "Ortho", 100);
            doctors.AddRange(new CustomList<DoctorDetails>() { doc1, doc2, doc3 });
            //Grid<DoctorDetails>.PrintTables(doctors);
            //System.Console.WriteLine("\n\n");

            AvailableSlotDetails als1 = new("DID301", "6.00-6.30");
            AvailableSlotDetails als2 = new("DID301", "6.30-7.00");
            AvailableSlotDetails als3 = new("DID301", "7.00-7.30");
            AvailableSlotDetails als4 = new("DID301", "7.30-8.00");
            AvailableSlotDetails als5 = new("DID301", "8.00-8.30");
            AvailableSlotDetails als6 = new("DID301", "8.30-9.00");
            AvailableSlotDetails als7 = new("DID302", "6.00-6.30");
            AvailableSlotDetails als8 = new("DID302", "6.30-7.00");
            AvailableSlotDetails als9 = new("DID302", "7.00-7.30");
            AvailableSlotDetails als10 = new("DID302", "7.30-8.00");
            AvailableSlotDetails als11 = new("DID303", "7.30-8.00");
            AvailableSlotDetails als12 = new("DID303", "8.00-8.30");
            AvailableSlotDetails als13 = new("DID303", "8.30-9.00");

            slots.AddRange(new CustomList<AvailableSlotDetails>() { als1, als2, als3, als4, als5, als6, als7, als8, als9, als10, als11, als12, als13 });
            //Grid<AvailableSlotDetails>.PrintTables(slots);
            //System.Console.WriteLine("\n\n");

            PatientDetails pat1 = new("Arun", "Mani", "75757", 45, Genders.Male, "O+ve", 1000);
            PatientDetails pat2 = new("Malar", "Ganesh", "58855", 30, Genders.Female, "B-ve", 100);
            PatientDetails pat3 = new("Kumar", "Suresh", "57755", 50, Genders.Male, "A+ve", 500);
            PatientDetails pat4 = new("Selvi", "Pandi", "58858", 20, Genders.Female, "O+ve", 50);
            patients.AddRange(new CustomList<PatientDetails>() { pat1, pat2, pat3, pat4 });
            //Grid<PatientDetails>.PrintTables(patients);
            //System.Console.WriteLine("\n\n");

            AppointmentDetails appoint1 = new("PID1001", "DID301", new DateTime(2022, 04, 27), "SL101", AppointmentStatus.Booked, 200);
            AppointmentDetails appoint2 = new("PID1002", "DID302", new DateTime(2022, 04, 27), "SL102", AppointmentStatus.Booked, 500);
            AppointmentDetails appoint3 = new("PID1003", "DID303", new DateTime(2022, 04, 27), "SL104", AppointmentStatus.Booked, 100);
            AppointmentDetails appoint4 = new("PID1001", "DID303", new DateTime(2022, 04, 27), "SL106", AppointmentStatus.Cancelled, 100);
            appoints.AddRange(new CustomList<AppointmentDetails>() { appoint1, appoint2, appoint3, appoint4 });
            //Grid<AppointmentDetails>.PrintTables(appoints);
            //System.Console.WriteLine("\n\n");
        }

        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("Main Menu");
                System.Console.WriteLine("Press\n1.Patient Registration\n2.Login\n3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            PatientRegistration();
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

        public static void PatientRegistration()
        {
            System.Console.WriteLine("Enter Your Details\n");
            System.Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your FatherName");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter your Gender");
            Genders gender = Enum.Parse<Genders>(Console.ReadLine(), true);
            System.Console.WriteLine("Enter your PhoneNumber");
            string phone = Console.ReadLine();
            System.Console.WriteLine("Enter your Age");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your BloodGroup");
            string blood = Console.ReadLine();
            System.Console.WriteLine("Enter your Wallet balance");
            double balance = double.Parse(Console.ReadLine());

            PatientDetails pat = new(name, fatherName, phone, age, gender, blood, balance);
            patients.Add(pat);
            System.Console.WriteLine("Registration successfull");
            System.Console.WriteLine($"\nYour PatientID is \n{pat.PatientID}");



        }

        public static void Login()
        {
            System.Console.WriteLine("Login Page");
            System.Console.WriteLine("Enter your Patient ID");
            string pID = Console.ReadLine().ToUpper();
            int n = SearchUtility<PatientDetails>.BinarySearch(patients, pID, "PatientID", out currentLoggedInUser);
            if (n >= 0)
            {
                System.Console.WriteLine("LogIn successfull");
                SubMenu();

            }
            else
            {
                System.Console.WriteLine("Wrong PatientID");
            }


        }

        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("SubMenu");
                System.Console.WriteLine("Press to Do\n1.Book Appointment\n2.Appointment History\n3.Cancel Appointment\n4.Wallet Recharge\n5.Show Balance\n6.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            BookAppointMent();
                            break;
                        }
                    case 2:
                        {
                            AppointmentHistory();
                            break;
                        }
                    case 3:
                        {
                            CancelApointment();
                            break;

                        }
                    case 4:
                        {
                            Recharge();
                            break;
                        }
                    case 5:
                        {
                            ShowBalance();
                            break;
                        }
                    case 6:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);

        }

        public static void BookAppointMent()
        {

            bool doctorFlag = true;
            bool dateFlag = true;
            bool countFlag = true;
            bool slotFlag = true;
            //Show the doctors details list by traversing the doctor details class. 
            Grid<DoctorDetails>.PrintTables(doctors);
            //Then ask and get the doctorID from user “Enter a doctor ID _____”. 
            System.Console.WriteLine("Enter Doctor for appointment");
            string doctorID = Console.ReadLine().ToUpper();

            foreach (DoctorDetails doc in doctors)
            {
                if (doc.DoctorID.Equals(doctorID))
                {
                    //Check whether “DoctorID” is available or not. 
                    doctorFlag = false;
                    //If available, Ask and get the appointment date “Enter an appointment date _______”.
                    System.Console.WriteLine("Enter the Appointment Date");
                    DateTime AppointDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    //If the given appointment date is today or greater than today,
                    if (AppointDate >= DateTime.Now)
                    {
                        dateFlag = false;
                        //Traversing the appointment history, if doctor already have three slots 
                        // in the given date, display “All the appointments are booked for selected DoctorID”.
                        int count = 0;
                        foreach (AppointmentDetails ap in appoints)
                        {
                            if (ap.DoctorID.Equals(doc.DoctorID) && AppointDate == ap.AppointmentDate)
                            {
                                count++;
                            }
                        }
                        if (count < 3)
                        {
                            //If doctor has less than three slots in the given date, 
                            // Display the slot details list for the user selected doctorID.
                            countFlag = false;
                            CustomList<AvailableSlotDetails> slots1 = new CustomList<AvailableSlotDetails>();
                            foreach (AvailableSlotDetails sl in slots)
                            {
                                if (sl.DoctorID.Equals(doc.DoctorID))
                                {
                                    slots1.Add(sl);
                                }
                            }
                            Grid<AvailableSlotDetails>.PrintTables(slots1);
                            //Ask and get the slotID from user “Enter the slotID ______”.
                            System.Console.WriteLine("Enter the slot id to be appointed");
                            string sID = Console.ReadLine().ToUpper();

                            //Check the given slotID is available
                            foreach (AvailableSlotDetails slot in slots)
                            {
                                if (slot.SlotID.Equals(sID))
                                {
                                    slotFlag = false;
                                    bool fl = true;
                                    foreach (AppointmentDetails ap in appoints)
                                    {
                                        if (ap.DoctorID.Equals(doc.DoctorID) && ap.AppointmentSlot.Equals(slot.SlotID)/*&&ap.AppointmentDate==AppointDate*/)
                                        {
                                            fl = false;
                                            System.Console.WriteLine("No appointments are available that day da seriya");
                                        }
                                    }
                                    if (fl)
                                    {
                                        currentLoggedInUser.DeductBalance(doc.Fees);
                                        AppointmentDetails appoint1 = new(currentLoggedInUser.PatientID, doc.DoctorID, AppointDate, slot.SlotID, AppointmentStatus.Booked, doc.Fees);
                                        appoints.Add(appoint1);
                                        System.Console.WriteLine($"Appointment Successful\nAppointment ID : {appoint1.AppointMantID} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (slotFlag || countFlag || doctorFlag || dateFlag)
            {
                if (slotFlag)
                {
                    System.Console.WriteLine("No Slot Available");
                }
                if (countFlag)
                {
                    System.Console.WriteLine("Appointment is not available on that Date");
                }
                if (doctorFlag)
                {
                    //If the doctorID is not available, display “Invalid doctor ID. Please enter the valid one”.
                    System.Console.WriteLine("Wrong DoctorID");
                }
                if (dateFlag)
                {
                    //check if the given appointment date is less than today display, “you’re not able to 
                    // book the appointment in the given date”.
                    System.Console.WriteLine("Youre not able to book the appointment in the given date");
                }


            }

        }

        public static void CancelApointment()
        {
            //Show the current user’s appointment details by traversing the appointment list whose BookingStatus is booked. 
            System.Console.WriteLine("Displaying the Appointment History\n\n");
            CustomList<AppointmentDetails> appointment1 = new CustomList<AppointmentDetails>();
            bool apFlag = true;

            foreach (AppointmentDetails ap in appoints)
            {
                if (currentLoggedInUser.PatientID.Equals(ap.PatientID) && ap.AppointmentState.Equals(AppointmentStatus.Booked))
                {
                    apFlag = false;
                    appointment1.Add(ap);
                }
            }
            Grid<AppointmentDetails>.PrintTables(appointment1);
            //If user has appointment history then, Ask the customer to choose one AppointmentID to cancel, 
            //then validate if the chosen AppointmentID is present for the user and its status is booked.
            if (apFlag)
            {
                //If there is no appointment history is present for the user means then show “No appointment history found”.
                System.Console.WriteLine("There is no Appointment History");
            }
            else
            {
                System.Console.WriteLine("\nEnter the AppointMentID to cancel");
                string aID = Console.ReadLine().ToUpper();
                bool pFlag = true;

                foreach (AppointmentDetails ap in appoints)
                {
                    if (ap.AppointMantID.Equals(aID) && ap.AppointmentState.Equals(AppointmentStatus.Booked))
                    {
                        pFlag = false;
                        ap.AppointmentState = AppointmentStatus.Cancelled;
                        //If the AppointmentID is valid, then update the current chosen appointment’s booking status as Cancelled 
                        // and return the fees amount for the appointment to customer’s wallet balance. 
                        currentLoggedInUser.Recharge(ap.Fees);
                        //Then, show “Appointment Cancelled Successfully”. 
                        System.Console.WriteLine("\nAppointment Cancelled SucessFully");

                    }
                }
                if (pFlag)
                {
                    //If the AppointmentID is not valid/already cancelled, then show “Invalid AppointmentID” 
                    // and show the Sub Menu options.
                    System.Console.WriteLine("Not Valid or Cancelled");
                }
            }
        }

        public static void AppointmentHistory()
        {
            System.Console.WriteLine("Displaying the Appointment History");
            CustomList<AppointmentDetails> appointment = new CustomList<AppointmentDetails>();
            bool flag = true;

            foreach (AppointmentDetails ap in appoints)
            {
                if (currentLoggedInUser.PatientID.Equals(ap.PatientID))
                {
                    flag = false;
                    appointment.Add(ap);
                }
            }

            if (appointment.Count > 0)
            {
                Grid<AppointmentDetails>.PrintTables(appointment);
            }
            else
            {
                System.Console.WriteLine(flag ? "No Appointments" : "");
            }
            //Show the current logged-In patient appointment history by traversing the appointment list. 
            //If found show all the appointments details made by the currently logged-In patient.
            //If not found, display “Details not found. You haven’t enrolled any appointments yet !.”

        }

        public static void Recharge()
        {
            System.Console.WriteLine("WalletRecharge");
            System.Console.WriteLine("Enter the amount to be recharged");
            double amount = double.Parse(Console.ReadLine());
            if (amount > 0)
            {
                currentLoggedInUser.Recharge(amount);

            }
            else { System.Console.WriteLine("Enter valid Recharge"); }
        }

        public static void ShowBalance()
        {
            System.Console.WriteLine($"Your Current Balance is {currentLoggedInUser.WalletBalance}");

        }





        /*1.	Book Appointment:
        1.	
        2.	
        3.	 
        4.	 
        5.	
        6.	
        7.	
        a.	
        b.	
        8.	
        9.	
        a.	Traversing appointment details and checking at the user given date for the selected doctor has an appointment with status Cancelled or no appointment entry.
        b.	Deduct the wallet balance of current logged-In patient and then create object for appointment details and add the details to appointment details list.
        10.	If slotID not available, that is in Booked state, then display “The slot is already booked. Kindly select different date/slot”.
        11.	Finally show “Your appointment is booked, and your Appointment ID is:_______”.
        */


    }
}



/*
        1.	Book Appointment - 
        2.	Appointment History - done
        3.	Cancel Appointment - done
        4.	Wallet Recharge - done
        5.	Show Balance - done
        6.	Exit - done

*/
