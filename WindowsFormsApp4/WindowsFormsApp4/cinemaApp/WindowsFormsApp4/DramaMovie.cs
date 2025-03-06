using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class DramaMovie : Movie
    {
        public string EmotionalConflict { get; set; }

        public override void ShowDetails()
        {
            base.ShowDetails();
            MessageBox.Show($"Emotional Conflict: {EmotionalConflict}", "Drama Movie Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
