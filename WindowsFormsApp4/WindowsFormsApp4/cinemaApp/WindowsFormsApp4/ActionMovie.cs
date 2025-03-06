using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class ActionMovie : Movie
    {
        public string SpecialActionScene { get; set; }

        public override void ShowDetails()
        {
            base.ShowDetails();
            MessageBox.Show($"Special Action Scene: {SpecialActionScene}", "Action Movie Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
