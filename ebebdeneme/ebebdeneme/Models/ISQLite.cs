using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ebebdeneme.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
            

    }
}
