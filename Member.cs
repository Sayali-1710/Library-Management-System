using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class Member
    {
     public int MemberId { get; set; }
     public string Name { get; set; }

        public List<Book>IssuedBooks { get; set; } = new List<Book>();

      public void DisplayMemberDetails()
        {
            Console.WriteLine($"Member ID: {MemberId}, Name: {Name},IssuedBooks: {IssuedBooks.Count}");

        }
    }
}
