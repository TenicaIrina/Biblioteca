using DataAccesLayer;
using System.Data;

namespace Domain
{
    public class BookModel
    {   
        //se face o instanta a clasei BooksOp pentru a avea acces la functiile din clasa respectiva
        private readonly BooksOp books = new BooksOp();
       
        //functie ce returneaza tabelul cu carti
        public DataTable ShowBooks()
        {
            DataTable table = new DataTable();
            table = books.ShowData();
            return table;
        } 

        //functie folosita pentru a insera un obiect de tipul carte, functie ce lucreaza cu textboxurile
        public void InsertBooks(string isbn, string datePublishing, string title, string bookPublishing)//toate de tipul string fiindca valoriledin text box sunt de tpul string
        {
             books.InsertBook(isbn, datePublishing,title, bookPublishing);

        }

        //functie folosita in editarea campurilor unei carti
        public void EditBooks(string isbn, string datePublishing, string title, string bookPublishing)
        {
            books.EditBook(isbn, datePublishing, title, bookPublishing);
        }

        //functie folosita pentru a sterge din tabel
        public void DeleteBooksfromtable(string title)
        {
            books.DeleteBook(title);
        }
    }
}
