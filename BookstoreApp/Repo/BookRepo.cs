using System;
using System.Linq;
using System.Collections.Generic;
using BookstoreApp.Models;

namespace BookstoreApp.BookRepo{
    public class BookRepository{
        public List<BookModel> getAllBooks(){
            return dataSource();
        }

        public BookModel getBookById(int id){
            return dataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> searchBook(String bookName, String authorName){
            return dataSource().Where(x => x.bookName.Contains(bookName) || x.authorName.Contains(authorName)).ToList();
        }

        private List<BookModel> dataSource(){
            return new List<BookModel>(){
                new BookModel(){Id = 1, bookName = "java", authorName = "Vithu"},
                new BookModel(){Id = 2, bookName = "Cotlin", authorName = "Kavio"},
                new BookModel(){Id = 3, bookName = "Dart", authorName = "Neha"},
                new BookModel(){Id = 4, bookName = "C++", authorName = "Mithila"},
                new BookModel(){Id = 5, bookName = ".NET", authorName = "John"}
            };
        }
    }
}