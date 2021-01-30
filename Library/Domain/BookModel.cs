using DataAccesLayer;
using System.Data;

namespace Domain
{
    public class BookModel
    {
        private readonly BooksOp books = new BooksOp();
       
        public DataTable ShowBooks()
        {
            DataTable table = new DataTable();
            table = books.ShowData();
            return table;
        }

        

        public void InsertBooks(string isbn, string datePublishing, string title, string bookPublishing)//toate de tipul string fiindca valoriledin text box sunt de tpul string
        {
             books.InsertBook(isbn, datePublishing,title, bookPublishing);

        }

        public void EditBooks(string isbn, string datePublishing, string title, string bookPublishing)
        {
            books.EditBook(isbn, datePublishing, title, bookPublishing);
        }

        public void DeleteBooksfromtable(string title)
        {
            books.DeleteBook(title);
        }
    }
}
