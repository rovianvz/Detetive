using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Detetive
{
    public partial class Default : System.Web.UI.Page
    {
        private static string RESULTADO = "<h2>Solução:</h2> "+
                                             "<h3 id=\"resposta\">{0}</h3> "+
                                             "<h2>Transcrição do depoimento:</h2> "+
                                             "{1}";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            //Ititialize the listboxes
            lbSuspects.Items.AddRange(Data.DefaultSuspects.Cast<ListItem>().ToArray());
            lbGuns.Items.AddRange(Data.DefaultGuns.Cast<ListItem>().ToArray());
            lbPlaces.Items.AddRange(Data.DefaultPlaces.Cast<ListItem>().ToArray());
  
        }

        private string printCurrentGuess(Dictionary<string, int> guess)
        {
            string suspect = lbSuspects.Items[guess[Constants.KEY_SUSPECT]].Value;
            string place = lbPlaces.Items[guess[Constants.KEY_PLACE]].Value;
            string gun = lbGuns.Items[guess[Constants.KEY_GUN]].Value;

            return string.Format("{0}, em {1}, com a {2}", suspect, place, gun);
        }

        public void btnSolucionar_Click(Object sender,
                           EventArgs e)
        {
            //Initialize the witness
            Testemunha testemunha = new Testemunha(lbSuspects.SelectedIndex,
                                                   lbPlaces.SelectedIndex,
                                                   lbGuns.SelectedIndex);

            //Ititialize the detective
            LinUstOrvalds detective = new LinUstOrvalds(lbSuspects.Items.Count,
                                                        lbGuns.Items.Count,
                                                        lbPlaces.Items.Count);

            int nextTip = 0;
            Dictionary<string, int> guess = null;
            StringBuilder sb = new StringBuilder();
            int counter = 1;
            string solution = "";
            do
            {
                guess = detective.nextGuess(nextTip);
                
                nextTip = testemunha.nextTip(guess);
                switch (nextTip)
                {
                    case 1:
                        sb.Append(string.Format("<strong>#{0}: Lin Ust Orvalds:</strong> {1} <br>", counter, printCurrentGuess(guess)));
                        counter++;
                        sb.Append(string.Format("<strong>#{0}: Testemunha:</strong> Não, não foi este cara. <br>", counter));
                        break;
                    case 2:
                        sb.Append(string.Format("<strong>#{0}: Lin Ust Orvalds:</strong> {1} <br>", counter, printCurrentGuess(guess)));
                        counter++;
                        sb.Append(string.Format("<strong>#{0}: Testemunha:</strong> O lugar está errado. <br>", counter));
                        break;
                    case 3:
                        sb.Append(string.Format("<strong>#{0}: Lin Ust Orvalds:</strong> {1} <br>", counter, printCurrentGuess(guess)));
                        counter++;
                        sb.Append(string.Format("<strong>#{0}: Testemunha:</strong> Foi outro arma. <br>", counter));
                        break;
                    default:
                        sb.Append(string.Format("<strong>#{0}: Lin Ust Orvalds:</strong> {1} <br>", counter, printCurrentGuess(guess)));
                        counter++;
                        sb.Append(string.Format("<strong>#{0}: Testemunha:</strong> Isso! <br>", counter));
                        solution = printCurrentGuess(guess);
                        break;
                }
                counter++;
            } while (nextTip != 0);

            result.Text = string.Format(RESULTADO, solution, sb.ToString());
            upResults.Update();
        }
    }
}