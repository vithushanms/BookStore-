using System;
using System.Linq;
using System.Collections.Generic;
using BookstoreApp.Models;
using System.Security.Cryptography.X509Certificates;

namespace BookstoreApp.BookRepo{
    public class BookRepository{
        public List<BookModel> getAllBooks(){
            return dataSource();
        }

        public BookModel getBookById(int id){
            return dataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> searchBook(String bookName, String authorName, String description)
        {
            return dataSource().Where(x => x.bookName.Contains(bookName) || x.authorName.Contains(authorName) || x.description.Contains(description)).ToList();
        }

        private List<BookModel> dataSource(){
            return new List<BookModel>(){
                new BookModel(){Id = 1, bookName = "java", authorName = "Vithu", description = "Learn Java from the scratch", totalPages = "155", language = "English", category = "Programming languages"},
                new BookModel(){Id = 2, bookName = "Cotlin", authorName = "Kavio", description = "Cotlin for android development", totalPages = "222", language = "English", category = "Mobile Development"},
                new BookModel(){Id = 3, bookName = "Flutter", authorName = "Neha", description = "Flutter for beginners", totalPages = "201", language = "English", category = "Mobile Development"},
                new BookModel(){Id = 4, bookName = "C++", authorName = "Mithila", description = "Advance C++ for embedded systems", totalPages = "390", language = "English", category = "Electronics"},
                new BookModel(){Id = 5, bookName = ".NET", authorName = "John", description = "Start your programming journy with .NET", totalPages = "530", language = "English", category = "Framework"}
            };
        }
    }
}