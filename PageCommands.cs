using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Projekt_OOP
{
    interface PageCommands
    {
        DataTable search(Dictionary<string, string> dict, string section);
        DataTable add(Dictionary<string, string> dict, string section);
        DataTable edit(Dictionary<string, string> dict, string section, string editionPosition, string idInSQL );

    }
}
