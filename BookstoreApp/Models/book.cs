using System;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApp.Models
{
    public class BookModel
    {
        public int Id {get; set;}

        public String bookName {get; set;}

        public String authorName {get; set;}

        public String description { get; set;}

        public String totalPages { get; set; }

        public String language { get; set; }

        public String category { get; set; }
    }
}