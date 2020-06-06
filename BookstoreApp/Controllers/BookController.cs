using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using BookstoreApp.BookRepo;
using BookstoreApp.Models;

namespace BookstoreApp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepo = null;
        
        public BookController(){
            _bookRepo = new BookRepository();
        
        }

        public ViewResult getAllBooks(){
            var book = _bookRepo.getAllBooks();
            return View(book);
        }

        public ViewResult getBook(int id){
            var bookInfo = _bookRepo.getBookById(id);
            return View(bookInfo);
        }

        public List<BookModel> searchBook(String bookName, String authorName, String description){
            return _bookRepo.searchBook(bookName,authorName,description);
        }
    }
}