using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Movie
{
    public string Name { get; set; }
    public string Genre { get; set; }
    public DateTime SessionTime { get; set; }
    public decimal Price { get; set; }
    public string ShortDescription { get; set; }
    public double Rating { get; set; }

    
    public virtual void ShowDetails()
    {
        
        MessageBox.Show($"Name: {Name}\nGenre: {Genre}\nSession Time: {SessionTime}\nPrice: {Price}\nRating: {Rating}\n\nDescription: {ShortDescription}");
    }
}
