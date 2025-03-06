using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class SciFiMovie : Movie
    {
        public string FuturisticTechnology { get; set; }

        public override void ShowDetails()
        {
            base.ShowDetails();
            MessageBox.Show($"Futuristic Technology: {FuturisticTechnology}", "Sci-Fi Movie Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
