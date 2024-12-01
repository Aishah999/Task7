using System;
namespace ClassLibrary;
public class Helper
{
    public string CreateBookCode(string bookName,int number)
    {
        return bookName.Substring(0, 2).ToUpper() + number;
    } 
}
public class Book
{
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int PageCount { get; set; }
    public string Code { get; set; }

    public Book(string name,string authorName,int pageCount,int number)
    {
        Name = name;AuthorName = authorName;
        PageCount = pageCount;
    }
}
class Program
{
    static void Main(string[] args)
    {
        ClassLibrary.Book book = new ClassLibrary.Book("Programming", "John Doe", 300, 10);
        Console.WriteLine("Kitab adi:" + book.Name);
        Console.WriteLine("Muellif:" + book.AuthorName);
        Console.WriteLine("Sehife sayi:" + book.PageCount);
        Console.WriteLine("Kitab kodu:" + book.Code);
    }
}