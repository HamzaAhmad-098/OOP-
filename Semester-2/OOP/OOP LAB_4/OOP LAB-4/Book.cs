using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_4
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;
        public List<string> chapters;
        public int bookMark;
        public int price;
        public bool isAvailable;
        public Book(string title, string author, int pages, int bookMark, int price, bool isAvailable, List<string> chapters)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.bookMark = bookMark;
            this.price = price;
            this.isAvailable = isAvailable;
            this.chapters = chapters;
        }
        public bool isBookAvailable()
        {
            return isAvailable;
        }
        public string getChapter(int chapterNumber )
        {
            return chapters[chapterNumber];
        }
        public int getBookMark()
        {
            return bookMark;
        } 
    }
}
