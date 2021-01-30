using DataAccesLayer;
using System.Data;

namespace Domain
{
    public class CaracteristicsModel
    {
        private readonly Books booksnew = new Books();

        public DataTable ShowBooksDataTableUsingAcces(string title)
        { 
            DataTable table = new DataTable();
            table = booksnew.ShowBooksDataTableProp(title);
            return table;
        }
    }
}
