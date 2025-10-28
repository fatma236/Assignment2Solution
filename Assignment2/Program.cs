using System.Reflection.Metadata;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////-------1------------------------------
            //string[] userName = { "Fatma", "Younis", "Leema", "Salim" };
            //string[] password = { "555a", "444b", "666c", "999d" };
            //double[] Balance = { 555.0, 680.25, 850.0, 1000.0 };
            //Console.WriteLine("----Welcome to Bank Muscat-----");
            //Console.WriteLine("Write your user Name please?");
            //string us = Console.ReadLine();
            //Console.WriteLine("Write Your passward please?");
            //string ps = Console.ReadLine();
            //int x = 0;




            //for (int i = 0; i < userName.Length; i++)
            //{
            //    if ((userName[i] == us) && (password[i] == ps))
            //    {
            //        do
            //        {
            //            Console.WriteLine("Choose An Operation");
            //            Console.WriteLine("1 - Check balance");
            //            Console.WriteLine("2 - Deposite");
            //            Console.WriteLine("3 - Withdraw");
            //            Console.WriteLine("4 - Transfer");
            //            Console.WriteLine("5 - Exit");

            //            x = int.Parse(Console.ReadLine());


            //            switch (x)
            //            {
            //                case 1:
            //                    //-----------Check Balance                            
            //                    if (x == 1)
            //                    {
            //                        Console.WriteLine($"You have {Balance[i]} OMR ");
            //                    }
            //                    break;
            //                case 2:

            //                    //------------Deposite

            //                    if (x == 2)
            //                    {


            //                        Console.WriteLine("Enter The Amount That You Want To Depsite :");
            //                        double depos = double.Parse(Console.ReadLine());




            //                        double z = Balance[i] + depos;
            //                        Console.WriteLine($"Done.. Now Your Balance is {z}");


            //                    }
            //                    break;

            //                case 3:

            //                    //------------WithDraw

            //                    if (x == 3)
            //                    {


            //                        Console.WriteLine("Enter The Amount That You Want To WithDraw :");
            //                        double withd = double.Parse(Console.ReadLine());



            //                        if (withd > Balance[i])
            //                        {
            //                            Console.WriteLine("Invalid");
            //                        }
            //                        else
            //                        {
            //                            double z = Balance[i] - withd;
            //                            Console.WriteLine($"Done.. Now Your Balance is {z}");

            //                        }
            //                    }
            //                    break;

            //                case 4:
            //                    //----------------Exit
            //                    if (x == 4)
            //                    {
            //                        Console.WriteLine("Write the user name that you want to transfer to ?");
            //                        string us1 = Console.ReadLine();
            //                        Console.WriteLine("Enter the amount that you want to transfer ?");
            //                        double amount = double.Parse(Console.ReadLine());
            //                        for (int j = 0; j < userName.Length; j++)
            //                        {
            //                            if (userName[j] == us1)
            //                            {
            //                                if (amount < Balance[i])
            //                                {
            //                                    Balance[i] = amount - Balance[i];
            //                                    Balance[j] = Balance[j] + amount;
            //                                    Console.WriteLine($" Transfer Done Your Balance Now is {Balance[i]}");
            //                                }


            //                            }

            //                        }

            //                    }
            //                    break;
            //                case 5:
            //                    Console.WriteLine("Thank You");
            //                    break;

            //                default:

            //                    Console.WriteLine();
            //                    break;

            //            }
            //        }
            //        while (x != 5);
            //    }
            //}


            //-----2------------------------
            // Arrays for questions, options, and correct answers
            //    string[] questions = {
            //    "What is the capital of France?",
            //    "Which planet is known as the Red Planet?",
            //    "What is 5 + 7?",
            //    "Who painted the Mona Lisa?",
            //    "What is the largest ocean on Earth?"
            //};

            //    string[,] options = {
            //    {"A) London", "B) Berlin", "C) Paris", "D) Madrid"},
            //    {"A) Venus", "B) Mars", "C) Jupiter", "D) Saturn"},
            //    {"A) 10", "B) 11", "C) 12", "D) 13"},
            //    {"A) Van Gogh", "B) Picasso", "C) Da Vinci", "D) Monet"},
            //    {"A) Atlantic", "B) Indian", "C) Arctic", "D) Pacific"}
            //};

            //    char[] correctAnswers = { 'C', 'B', 'C', 'C', 'D' };

            //    int score = 0;
            //    char userAnswer;

            //    Console.WriteLine("========================================");
            //    Console.WriteLine("       Welcome to the Quiz Game!       ");
            //    Console.WriteLine("========================================");
            //    Console.WriteLine();

            //    // Loop through each question
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine($"Question {i + 1}: {questions[i]}");

            //        // Display options
            //        for (int j = 0; j < 4; j++)
            //        {
            //            Console.WriteLine(options[i, j]);
            //        }

            //        // Get user input
            //        Console.Write("\nYour answer (A/B/C/D): ");
            //        string input = Console.ReadLine();

            //        // Validate input
            //        if (string.IsNullOrEmpty(input))
            //        {
            //            userAnswer = ' ';
            //        }
            //        else
            //        {
            //            userAnswer = char.ToUpper(input[0]);
            //        }

            //        // Check if answer is correct
            //        if (userAnswer == correctAnswers[i])
            //        {
            //            Console.WriteLine("✓ Correct!");
            //            score++;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"✗ Wrong! The correct answer is {correctAnswers[i]}");
            //        }

            //        Console.WriteLine($"Current Score: {score}/5");
            //        Console.WriteLine("----------------------------------------");
            //        Console.WriteLine();
            //    }

            //    // Display final score
            //    Console.WriteLine("========================================");
            //    Console.WriteLine("           Quiz Completed!              ");
            //    Console.WriteLine("========================================");
            //    Console.WriteLine($"Your Final Score: {score}/5");
            //    Console.WriteLine();

            //    // Use switch to display feedback based on score
            //    switch (score)
            //    {
            //        case 5:
            //        case 4:
            //            Console.WriteLine("Feedback: Excellent! 🌟");
            //            break;
            //        case 3:
            //        case 2:
            //            Console.WriteLine("Feedback: Good! Keep practicing! 👍");
            //            break;
            //        case 1:
            //        case 0:
            //            Console.WriteLine("Feedback: Try Again! Don't give up! 💪");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid score!");
            //            break;
            //    }

            //    Console.WriteLine("========================================");
            //}

            //--------3----------------------------

            // Arrays for products and quantities
            //string[] products = { "Apple", "Orange", "Milk", "Bread", "Eggs" };
            //int[] quantities = { 50, 30, 20, 15, 40 };

            //int choice;
            //bool exit = false;

            //Console.WriteLine("Welcome to Inventory System!");

            //// Main loop
            //while (!exit)
            //{
            //    // Display menu
            //    Console.WriteLine("\n--- MENU ---");
            //    Console.WriteLine("1 → View All Products");
            //    Console.WriteLine("2 → Add Stock");
            //    Console.WriteLine("3 → Sell Product");
            //    Console.WriteLine("4 → Check Product Quantity");
            //    Console.WriteLine("5 → Exit");
            //    Console.Write("\nEnter your choice: ");

            //    choice = int.Parse(Console.ReadLine());

            //    // Switch menu
            //    switch (choice)
            //    {
            //        case 1: // View All Products
            //            Console.WriteLine("\nAvailable Products:");
            //            for (int i = 0; i < products.Length; i++)
            //            {
            //                Console.WriteLine(products[i] + " - Quantity: " + quantities[i]);
            //            }
            //            break;

            //        case 2: // Add Stock
            //            Console.Write("\nEnter product name: ");
            //            string addProduct = Console.ReadLine();

            //            // Find product
            //            for (int i = 0; i < products.Length; i++)
            //            {
            //                if (products[i] == addProduct)
            //                {
            //                    Console.Write("Enter quantity to add: ");
            //                    int addQty = int.Parse(Console.ReadLine());
            //                    quantities[i] = quantities[i] + addQty;
            //                    Console.WriteLine("Stock added successfully!");
            //                    Console.WriteLine("New quantity: " + quantities[i]);
            //                    break;
            //                }
            //            }
            //            break;


            //        case 3: // Sell Product
            //            Console.Write("\nEnter product name: ");
            //            string sellProduct = Console.ReadLine();

            //            // Find product
            //            for (int i = 0; i < products.Length; i++)
            //            {
            //                if (products[i] == sellProduct)
            //                {
            //                    Console.Write("Enter quantity to sell: ");
            //                    int sellQty = int.Parse(Console.ReadLine());

            //                    if (quantities[i] >= sellQty)
            //                    {
            //                        quantities[i] = quantities[i] - sellQty;
            //                        Console.WriteLine("Product sold successfully!");
            //                        Console.WriteLine("Remaining quantity: " + quantities[i]);
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Not enough stock!");
            //                    }
            //                    break;
            //                }
            //            }
            //            break;

            //        case 4: // Check Product Quantity
            //            Console.Write("\nEnter product name: ");
            //            string checkProduct = Console.ReadLine();

            //            // Find product
            //            for (int i = 0; i < products.Length; i++)
            //            {
            //                if (products[i] == checkProduct)
            //                {
            //                    Console.WriteLine("Product: " + products[i]);
            //                    Console.WriteLine("Current Stock: " + quantities[i]);
            //                    break;
            //                }
            //            }
            //            break;

            //        case 5: // Exit
            //            Console.WriteLine("Thank you!");
            //            exit = true;
            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice!");
            //            break;
            //}




            //}
            //-------------------------4---------------------------
            //string[] students = new string[50];
            //int[] grades = new int[50];
            //int count = 0;

            //int choice;

            //while (true)
            //{
            //    Console.WriteLine("\n--- MENU ---");
            //    Console.WriteLine("1 → Add Student");
            //    Console.WriteLine("2 → Update Grade");
            //    Console.WriteLine("3 → View All Students and Grades");
            //    Console.WriteLine("4 → Show Average, Highest, and Lowest Grades");
            //    Console.WriteLine("5 → Exit");
            //    Console.Write("\nEnter your choice: ");

            //    choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("Enter student name: ");
            //            string name = Console.ReadLine();

            //            Console.Write("Enter grade: ");
            //            int grade = int.Parse(Console.ReadLine());

            //            if (grade >= 0 && grade <= 100)
            //            {
            //                students[count] = name;
            //                grades[count] = grade;
            //                count++;
            //                Console.WriteLine("Student added!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Grade must be between 0 and 100!");
            //            }
            //            break;

            //        case 2:
            //            Console.Write("Enter student name: ");
            //            string updateName = Console.ReadLine();

            //            for (int i = 0; i < count; i++)
            //            {
            //                if (students[i] == updateName)
            //                {
            //                    Console.Write("Enter new grade: ");
            //                    int newGrade = int.Parse(Console.ReadLine());

            //                    if (newGrade >= 0 && newGrade <= 100)
            //                    {
            //                        grades[i] = newGrade;
            //                        Console.WriteLine("Grade updated!");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Grade must be between 0 and 100!");
            //                    }
            //                    break;
            //                }
            //            }
            //            break;

            //        case 3:
            //            Console.WriteLine("\nStudents and Grades:");
            //            for (int i = 0; i < count; i++)
            //            {
            //                Console.WriteLine(students[i] + " - " + grades[i]);
            //            }
            //            break;

            //        case 4:
            //            if (count > 0)
            //            {
            //                int sum = 0;
            //                int highest = grades[0];
            //                int lowest = grades[0];

            //                for (int i = 0; i < count; i++)
            //                {
            //                    sum = sum + grades[i];

            //                    if (grades[i] > highest)
            //                    {
            //                        highest = grades[i];
            //                    }

            //                    if (grades[i] < lowest)
            //                    {
            //                        lowest = grades[i];
            //                    }
            //                }

            //                double average = (double)sum / count;

            //                Console.WriteLine("\nAverage: " + average);
            //                Console.WriteLine("Highest: " + highest);
            //                Console.WriteLine("Lowest: " + lowest);
            //            }
            //            break;

            //        case 5:
            //            return;

            //        default:
            //            Console.WriteLine("Invalid choice!");
            //            break;
            //    }
            //}

            //-------------------------5----------------------------
            ////5----------------------------------------------------

            //string[] slots = new string[5]; // 10 مواقف
            //int choice;

            //do
            //{
            //    Console.WriteLine("Parking Lot System");
            //    Console.WriteLine("1 Park a Car");
            //    Console.WriteLine("2 Remove a Car");
            //    Console.WriteLine("3 View All Slots");
            //    Console.WriteLine("4 Search for a Car");
            //    Console.WriteLine("5 Exit");
            //    Console.Write("Enter your choice: ");
            //    choice = int.Parse(Console.ReadLine());

            //    if (choice == 1) // إضافة سيارة
            //    {
            //        int emptyIndex = -1;
            //        for (int i = 0; i < slots.Length; i++)
            //        {
            //            if (slots[i] == null)
            //            {
            //                emptyIndex = i;
            //                break;
            //            }
            //        }

            //        if (emptyIndex == -1)
            //        {
            //            Console.WriteLine("Parking lot is full!");
            //        }
            //        else
            //        {
            //            Console.Write("Enter car license number: ");
            //            string carNumber = Console.ReadLine();

            //            bool exists = false;
            //            for (int i = 0; i < slots.Length; i++)
            //            {
            //                if (slots[i] == carNumber)
            //                {
            //                    exists = true;
            //                    break;
            //                }
            //            }

            //            if (exists)
            //                Console.WriteLine("Car already parked!");
            //            else
            //            {
            //                slots[emptyIndex] = carNumber;
            //                Console.WriteLine("Car parked at slot " + (emptyIndex + 1));
            //            }
            //        }
            //    }
            //    else if (choice == 2) // إزالة سيارة
            //    {
            //        Console.Write("Enter car license number to remove: ");
            //        string carNumber = Console.ReadLine();
            //        bool found = false;

            //        for (int i = 0; i < slots.Length; i++)
            //        {
            //            if (slots[i] == carNumber)
            //            {
            //                slots[i] = null;
            //                Console.WriteLine("Car removed from slot " + (i + 1));
            //                found = true;
            //                break;
            //            }
            //        }

            //        if (!found)
            //            Console.WriteLine("Car not found!");
            //    }
            //    else if (choice == 3) // عرض جميع المواقف
            //    {
            //        for (int i = 0; i < slots.Length; i++)
            //        {
            //            if (slots[i] == null)
            //                Console.WriteLine("Slot " + (i + 1) + ": Empty");
            //            else
            //                Console.WriteLine("Slot " + (i + 1) + ": " + slots[i]);
            //        }
            //    }
            //    else if (choice == 4) // البحث عن سيارة
            //    {
            //        Console.Write("Enter car license number to search: ");
            //        string carNumber = Console.ReadLine();
            //        bool found = false;

            //        for (int i = 0; i < slots.Length; i++)
            //        {
            //            if (slots[i] == carNumber)
            //            {
            //                Console.WriteLine("Car found at slot " + (i + 1));
            //                found = true;
            //                break;
            //            }
            //        }

            //        if (!found)
            //            Console.WriteLine("Car not found!");
            //    }
            //    else if (choice == 5)
            //    {
            //        Console.WriteLine("Exiting...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid choice, try again!");
            //    }

            //} while (choice != 5);


            //6----------------------------------------------------

            //string[] tasks = new string[5];     // فقط 5 مهام
            //bool[] isCompleted = new bool[5];   // حالة كل مهمة (منجزة أو لا)
            //int taskCount = 0;                  // عدد المهام الحالية
            //int choice;

            //do
            //{
            //    Console.WriteLine(" List Application ");
            //    Console.WriteLine("1 Add Task");
            //    Console.WriteLine("2 Delete Task");
            //    Console.WriteLine("3 Mark Task as Completed");
            //    Console.WriteLine("4 View Tasks");
            //    Console.WriteLine("5 Clear Completed Tasks");
            //    Console.WriteLine("6 Exit");
            //    Console.Write("Enter your choice: ");
            //    choice = int.Parse(Console.ReadLine());

            //    if (choice == 1) // إضافة مهمة
            //    {
            //        if (taskCount < tasks.Length)
            //        {
            //            Console.Write("Enter task description: ");
            //            string task = Console.ReadLine();
            //            tasks[taskCount] = task;
            //            isCompleted[taskCount] = false; // المهمة جديدة = Pending
            //            taskCount++;
            //            Console.WriteLine("Task added successfully!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Task list is full!");
            //        }
            //    }
            //    else if (choice == 2) // حذف مهمة
            //    {
            //        Console.Write("Enter task number to delete: ");
            //        int num = int.Parse(Console.ReadLine());

            //        if (num > 0 && num <= taskCount)
            //        {
            //            for (int i = num - 1; i < taskCount - 1; i++)
            //            {
            //                tasks[i] = tasks[i + 1];
            //                isCompleted[i] = isCompleted[i + 1];
            //            }
            //            taskCount--;
            //            Console.WriteLine("Task deleted successfully!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid task number!");
            //        }
            //    }
            //    else if (choice == 3) // وضع المهمة كمكتملة
            //    {
            //        Console.Write("Enter task number to mark as completed: ");
            //        int num = int.Parse(Console.ReadLine());

            //        if (num > 0 && num <= taskCount)
            //        {
            //            isCompleted[num - 1] = true;
            //            Console.WriteLine("Task marked as completed!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid task number!");
            //        }
            //    }
            //    else if (choice == 4) // عرض جميع المهام
            //    {
            //        if (taskCount == 0)
            //        {
            //            Console.WriteLine("No tasks found!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nYour Tasks:");
            //            for (int i = 0; i < taskCount; i++)
            //            {
            //                string status = isCompleted[i] ? "Done" : "Pending";
            //                Console.WriteLine((i + 1) + ". " + tasks[i] + " [" + status + "]");
            //            }
            //        }
            //    }
            //    else if (choice == 5) // حذف المهام المكتملة
            //    {
            //        int i = 0;
            //        while (i < taskCount)
            //        {
            //            if (isCompleted[i])
            //            {
            //                for (int j = i; j < taskCount - 1; j++)
            //                {
            //                    tasks[j] = tasks[j + 1];
            //                    isCompleted[j] = isCompleted[j + 1];
            //                }
            //                taskCount--;
            //            }
            //            else
            //            {
            //                i++;
            //            }
            //        }
            //        Console.WriteLine("Completed tasks cleared!");
            //    }
            //    else if (choice == 6)
            //    {
            //        Console.WriteLine("Exiting program...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid choice, try again!");
            //    }

            //} while (choice != 6);







            //7-------------------------------------------------------------


            //string[] books = { "C#", "math ", " database", "web", "english" };
            //bool[] isBorrowed = new bool[5]; 
            //int choice;

            //do
            //{
            //    Console.WriteLine("Library Book Borrowing System ");
            //    Console.WriteLine("1 View Books");
            //    Console.WriteLine("2 Borrow Book");
            //    Console.WriteLine("3 Return Book");
            //    Console.WriteLine("4 Check Availability");
            //    Console.WriteLine("5 Exit");
            //    Console.Write("Enter your choice: ");
            //    choice = int.Parse(Console.ReadLine());

            //    if (choice == 1) //    نشوف كل الكتب
            //    {
            //        Console.WriteLine("\nBooks List:");
            //        for (int i = 0; i < books.Length; i++)
            //        {
            //            string status = isBorrowed[i] ? "Borrowed" : "Available";
            //            Console.WriteLine((i + 1) + ". " + books[i] + " [" + status + "]");
            //        }
            //    }
            //    else if (choice == 2) // نستعير كتاب
            //    {
            //        Console.Write("Enter book number to borrow: ");
            //        int num = int.Parse(Console.ReadLine());

            //        if (num > 0 && num <= books.Length)
            //        {
            //            if (isBorrowed[num - 1])
            //            {
            //                Console.WriteLine("Sorry, this book is already borrowed!");
            //            }
            //            else
            //            {
            //                isBorrowed[num - 1] = true;
            //                Console.WriteLine("You borrowed \"" + books[num - 1] + "\" successfully!");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid book number!");
            //        }
            //    }
            //    else if (choice == 3) // اذا بنرجع كتاب
            //    {
            //        Console.Write("Enter book number to return: ");
            //        int num = int.Parse(Console.ReadLine());

            //        if (num > 0 && num <= books.Length)
            //        {
            //            if (isBorrowed[num - 1])
            //            {
            //                isBorrowed[num - 1] = false;
            //                Console.WriteLine("You returned \"" + books[num - 1] + "\" successfully!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("This book was not borrowed!");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid book number!");
            //        }
            //    }
            //    else if (choice == 4) // نشوف الكتاب متوفر او لا
            //    {
            //        Console.Write("Enter book number to check availability: ");
            //        int num = int.Parse(Console.ReadLine());

            //        if (num > 0 && num <= books.Length)
            //        {
            //            if (isBorrowed[num - 1])
            //                Console.WriteLine("The book \"" + books[num - 1] + "\" is currently borrowed.");
            //            else
            //                Console.WriteLine("The book \"" + books[num - 1] + "\" is available.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid book number!");
            //        }
            //    }
            //    else if (choice == 5)
            //    {
            //        Console.WriteLine("Exiting program...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid choice, try again!");
            //    }

            //} while (choice != 5);

            //------------------------------------------------------------------------------------------
            //8-----------------------------------------------------------------------------------------------

            //    char[,] seats = new char[5, 5];
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            seats[i, j] = 'A';
            //        }
            //    }

            //    bool running = true;

            //    while (running)
            //    {
            //        Console.WriteLine("\n--- Movie Theatre Seat Booking System ---");
            //        Console.WriteLine("1 → View Seats");
            //        Console.WriteLine("2 → Book Seat");
            //        Console.WriteLine("3 → Cancel Booking");
            //        Console.WriteLine("4 → Show Available Seat Count");
            //        Console.WriteLine("5 → Exit");
            //        Console.Write("Enter your choice: ");

            //        string choice = Console.ReadLine();

            //        switch (choice)
            //        {
            //            case "1":
            //                ViewSeats(seats);
            //                break;
            //            case "2":
            //                BookSeat(seats);
            //                break;
            //            case "3":
            //                CancelBooking(seats);
            //                break;
            //            case "4":
            //                ShowAvailableSeats(seats);
            //                break;
            //            case "5":
            //                running = false;
            //                Console.WriteLine("Exiting the system. Goodbye!");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid choice. Please enter 1-5.");
            //                break;
            //        }
            //    }
            //}

            //static void ViewSeats(char[,] seats)
            //{
            //    Console.WriteLine("\nSeats Layout (A = Available, X = Booked):");
            //    Console.WriteLine("   1 2 3 4 5");
            //    for (int i = 0; i < seats.GetLength(0); i++)
            //    {
            //        Console.Write((i + 1) + "  ");
            //        for (int j = 0; j < seats.GetLength(1); j++)
            //        {
            //            Console.Write(seats[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //static void BookSeat(char[,] seats)
            //{
            //    Console.Write("Enter row number (1-5): ");
            //    int row = GetValidNumber() - 1;

            //    Console.Write("Enter column number (1-5): ");
            //    int col = GetValidNumber() - 1;

            //    if (seats[row, col] == 'A')
            //    {
            //        seats[row, col] = 'X';
            //        Console.WriteLine("Seat booked successfully!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Seat already booked! Please choose another seat.");
            //    }
            //}

            //static void CancelBooking(char[,] seats)
            //{
            //    Console.Write("Enter row number (1-5) to cancel: ");
            //    int row = GetValidNumber() - 1;

            //    Console.Write("Enter column number (1-5) to cancel: ");
            //    int col = GetValidNumber() - 1;

            //    if (seats[row, col] == 'X')
            //    {
            //        seats[row, col] = 'A';
            //        Console.WriteLine("Booking cancelled successfully!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Seat is not booked yet.");
            //    }
            //}

            //static void ShowAvailableSeats(char[,] seats)
            //{
            //    int count = 0;
            //    for (int i = 0; i < seats.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < seats.GetLength(1); j++)
            //        {
            //            if (seat[i, j] == 'A')
            //                count++;
            //        }
            //    }
            //    Console.WriteLine($"Available seats: {count}");
            //}

            //static int GetValidNumber()
            //{
            //    while (true)
            //    {
            //        string input = Console.ReadLine();
            //        if (int.TryParse(input, out int number) && number >= 1 && number <= 5)
            //        {
            //            return number;
            //        }
            //        Console.Write("Invalid .. Enter a number between 1 and 5: ");
    //    }
    //}





        }
    }
  }












                 






