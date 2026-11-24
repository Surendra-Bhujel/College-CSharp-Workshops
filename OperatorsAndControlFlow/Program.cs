using System.Runtime.ConstrainedExecution;

namespace OperatorsAndControlFlow
{
    class Program
    {
        static void Main()
        {
            // Add Task 1 to Task 6 here, in this order.
            // Task 1: College Reward Points
            int points = 10;
            points += 5;
            points *= 2;
            Console.WriteLine("Total points:" + points);

            bool atLeast25 = points >= 25;
            Console.WriteLine($"At least 25 points: {atLeast25}");

            int afterPost = points++;
            Console.WriteLine($"Points after post-increment: {afterPost}, points is now {points}");

            int afterPre = ++points;
            Console.WriteLine($"Points after pre-increment: {afterPre}, points is now {points}");


            // Task 2 Student Exam Result 
            int marks = 72;
            int attendance = 80;

            string grade;
            if (marks >= 80)
            {
                grade = "A";
            }
            else if (marks >= 70)
            {
                grade = "B";
            }
            else if (marks >= 60)
            {
                grade = "C";
            }
            else
            {
                grade = "Fail";
            }
            bool isEligible = marks >= 50 && attendance >= 75;
            Console.WriteLine($"Marks: {marks}, Attendance: {attendance}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Eligible for exam: {isEligible}");

            Console.WriteLine();

            // ---- Task 3: Library Menu ----
            int choice = 2;
            Console.WriteLine("Library Menu");
            Console.WriteLine("1. Borrow   2. Return   3. Renew");
            Console.WriteLine($"Selected choice: {choice}");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You Selected Borrow");

                    break;
                case 2:
                    Console.WriteLine("You Selected Return");
                    break;
                case 3:
                    Console.WriteLine("You Selected Renew");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            string? userName = null;

            string displayName = userName ?? "Guest";
            Console.WriteLine($"Display name: {displayName}");

            userName ??= "Guest";
            Console.WriteLine($"userName after ??=: {userName}");

            // --- Task 4 Weekly Attendance ---
            int[] dailyAttendance = { 20, 22, 21, 24, 23};
            int total = 0;
            Console.WriteLine("Daily Attendance");
            foreach(int present in dailyAttendance)
            {
                Console.WriteLine($"{present}");
                total += present;
            } 
            Console.WriteLine($"Total Attendance: {total}");

            for(int i = 0; i < dailyAttendance.Length; i++)
            {
                Console.WriteLine($"Day {i+1}: {dailyAttendance[i]}");
            }
            int countdown = 3;
            while(countdown >= 1)
            {
                Console.WriteLine(countdown);
                countdown--;
            }
            bool runAgain = false;
            do
            {
                Console.WriteLine("Attendance recorded.");
            }while(runAgain);

            // ---- Task 5 Exam Hall Seat Labels ----
            int seatCount = 0;
            for(int row = 1; row <=3; row++)
            {
                for(int seat = 1; seat <= 5; seat++)
                {
                    Console.WriteLine($"Row {row} seat {seat}");
                    seatCount++;
                }
            }
                Console.WriteLine($"Total seats: {seatCount}");

                for(int i = 1; i <= 10; i++)
            {
                if(i == 5)
                {
                    continue;
                }if(i == 8)
                {
                    break;
                }
                Console.WriteLine($"Number: {i}");
            }
            Console.WriteLine();

        // ---- Task 6: Simple Division Calculator ----
        Console.Write("Enter the integer: ");
        string firstInput = Console.ReadLine() ?? "";
        Console.Write("Enter the divisor: ");
        string secondInput = Console.ReadLine() ?? "";

            try
            {
                int first = int.Parse(firstInput);
                int second = int.Parse(secondInput);
                int result = first/second;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format. Please enter valid integers.");
            }finally
            {
                Console.WriteLine("Calculation completed.");
            }

        }
    }
}