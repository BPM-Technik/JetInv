using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace JetInv.Model
{
    class Query
    {
        WebBrowser web;
        String pw;

        public Query()
        {
            web = new WebBrowser();
            pw = "dbBpM#007007!";
        }

        public bool Anweisung(String query)
        {
            web.Navigate(query);

            return true;
        }

        public bool Select(String query)
        {
            web.Navigate(query);

            return true;
        }
    }
}
