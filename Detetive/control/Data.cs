using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Detetive
{
    public static class Data
    {
        public static ListItemCollection DefaultSuspects = new ListItemCollection 
        {
            new ListItem("Charles B. Abbage"),
		    new ListItem("Donald Duck Knuth"),
		    new ListItem("Ada L. Ovelace"),
		    new ListItem("Alan T. Uring"),
		    new ListItem("Ivar J. Acobson"),
		    new ListItem("Ras Mus Ler Dorf")
        };

        public static ListItemCollection DefaultPlaces = new ListItemCollection 
        {
            new ListItem("Redmond"),
            new ListItem("Palo Alto"),
            new ListItem("San Francisco"),
            new ListItem("Tokio"),
            new ListItem("Restaurante no Fim do Universo"),
            new ListItem("São Paulo"),
            new ListItem("Cupertino"),
            new ListItem("Helsinki"),
            new ListItem("Maida Vale"),
            new ListItem("Toronto")
        };

        public static ListItemCollection DefaultGuns = new ListItemCollection 
        {
            new ListItem("Peixeira"),
		    new ListItem("DynaTAC 8000X"),
		    new ListItem("Trezoitão"),
		    new ListItem("Trebuchet"),
		    new ListItem("Maça"),
		    new ListItem("Gládio")
        };
    }
}