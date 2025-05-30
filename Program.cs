using Library_Management_System;
using System;


class program
{
    static void Main()
    {
        Library library = new Library();

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("==*== WINGS TO FLY ABHYASIKA @SATARA ==*==");
        Console.WriteLine("----------------------------------------------");

        while (true)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1.Add Book");
            Console.WriteLine("2.Remove Book");
            Console.WriteLine("3.Add Member");
            Console.WriteLine("4.Remove Member");
            Console.WriteLine("5.Issue Book");
            Console.WriteLine("6.Return Book");
            Console.WriteLine("7.List All Books");
            Console.WriteLine("8.List All Members");
            Console.WriteLine("9.Exit");
            Console.WriteLine("Enter your Choice:  ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Book ID: ");
                    int addBookId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Title:  ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Author:  ");
                    string author = Console.ReadLine();

                    library.AddBook(new Book { BookId = addBookId, Title = title, Author = author, IsIssued = false });
                    Console.WriteLine("Book added Successfully.");
                    break;

                case "2":
                    Console.Write("Enter Book ID to remove:  ");
                    int removeBookId = int.Parse(Console.ReadLine());

                    library.RemoveBook(removeBookId);
                    break;

                case "3":
                    Console.Write("Enter Member ID:  ");
                    int memberId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name:  ");
                    string name = Console.ReadLine();

                    library.AddMember(new Member { MemberId = memberId, Name = name });
                    Console.WriteLine("Member added Successfully.");
                    break;

                case "4":
                    Console.Write("Enter Member ID to remove:  ");
                    int removememberId = int.Parse(Console.ReadLine());

                    library.RemoveMember(removememberId);
                    break;

                case "5":
                    Console.Write("Enter Book ID to issue:  ");
                    int issueBookId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Member ID to issue to:  ");
                    int issueMemberId = int.Parse(Console.ReadLine());

                    library.IssueBook(issueBookId, issueMemberId);
                    break;

                case "6":
                    Console.Write("Enter Book ID to return:  ");
                    int returnBookId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Member ID returning the Book:  ");
                    int returnMemberId = int.Parse(Console.ReadLine());

                    library.ReturnBook(returnBookId, returnMemberId);
                    break;

                case "7":
                    library.ListAllBooks();
                    break;

                case "8":
                    library.ListAllMembers();
                    break;

                case "9":
                    Console.WriteLine("Exiting the system.GOODBYE!!!!");
                    return;

                default:
                    Console.WriteLine(" OOPS!! Invalid Choice.Please Try again");
                    break;







            }


        }






    }




}









    








