using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class Library
    {
    public List<Book> Books {  get; set; } = new List<Book>();
    public List<Member> Members { get; set; } = new List<Member>();

        public void AddBook (Book book)
        {
            Books.Add(book);
            Console.WriteLine("Book added Successfully.");
        }


        public void RemoveBook (int bookId)
        {
         var book = Books.FirstOrDefault(b => b.BookId == bookId);
            if (book != null)
            {
                Books.Remove(book);
                Console.WriteLine("Book removed Successfully.");
            }
            else
            {
                Console.WriteLine("Error: Book not found.");
            }
        }


        public void AddMember (Member member)
        {
            Members.Add(member);
            Console.WriteLine("Member added Successfully.");
        }


        public void RemoveMember (int memberId)
        {
            var member = Members.FirstOrDefault(m => m.MemberId == memberId);
            if(member != null)
            {
                Members.Remove(member);
                Console.WriteLine("Member removed Successfully.");
            }
            else
            {
                Console.WriteLine("Error: Member not found.");
            }
        }


        public void IssueBook (int bookId,int memberId)
        {
            var book = Books.FirstOrDefault(b => b.BookId == bookId);
            var member = Members.FirstOrDefault(m => m.MemberId == memberId);
          
            if (book == null)
            {
                Console.WriteLine("Error: Book not found.");
                return;
            }
            if (member == null)
            {
                Console.WriteLine("Error: Member not found.");
                return ;
            }
            if (book.IsIssued)
            {
                Console.WriteLine("Error: Book already issued.");
                return ;
            }
            book.IsIssued = true;
            member.IssuedBooks.Add(book);
            Console.WriteLine("Book issued Successfully.");

        }


        public void ReturnBook (int bookId,int memberId)
        {
            var book = Books.FirstOrDefault(b => b.BookId == bookId);
            var member = Members.FirstOrDefault(m => m.MemberId == memberId);

            if (book == null)
            {
                Console.WriteLine("Error: Book not found.");
                return;
            }
            if (member == null)
            {
                Console.WriteLine("Error: Member not found.");
                return ;
            }
            if(!book.IsIssued)
            {
                Console.WriteLine("Error: Book is not currently issued. ");
                return ;
            }
            book.IsIssued = false;
            member.IssuedBooks.Remove(book);
            Console.WriteLine("Book returned Successfully.");
        }


        public void ListAllBooks()
        {
            Console.WriteLine("Books in the Library.");
            foreach(var book in Books)
            {
                book.DisplayBookDetails();
            }
        }


        public void ListAllMembers()
        {
            Console.WriteLine("Library Members: ");
            foreach(var member in Members)
            {
                member.DisplayMemberDetails();
            }
        }

    }

}
