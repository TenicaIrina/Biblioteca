using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using System.Data;

namespace Domain
{
    public class CaracteristicsModel
    {
        private Books booksnew = new Books();

        public DataTable ShowBooksDataTableUsingAcces(string title)
        { 
            //booksnew.ShowBooksDataTableProp(title);
            DataTable table = new DataTable();
            table = booksnew.ShowBooksDataTableProp(title);
            return table;
        }
    }
}
