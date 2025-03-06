using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp4;

public partial class MovieForm : Form
{
    List<Movie> movies = new List<Movie>
    {
        new Movie { Name = "The Dark Knight", Genre = "Action", SessionTime = DateTime.Now.AddHours(2), Price = 12.99m, ShortDescription = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", Rating = 9.0 },
        new Movie { Name = "Inception", Genre = "Sci-Fi", SessionTime = DateTime.Now.AddHours(3), Price = 11.49m, ShortDescription = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", Rating = 8.8 },
        new Movie { Name = "Forrest Gump", Genre = "Drama", SessionTime = DateTime.Now.AddHours(4), Price = 9.99m, ShortDescription = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75.", Rating = 8.8 },
        new Movie { Name = "The Matrix", Genre = "Sci-Fi", SessionTime = DateTime.Now.AddHours(5), Price = 13.49m, ShortDescription = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", Rating = 8.7 },
        new Movie { Name = "Gladiator", Genre = "Action", SessionTime = DateTime.Now.AddHours(6), Price = 14.99m, ShortDescription = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.", Rating = 8.5 },
        new Movie { Name = "The Godfather", Genre = "Drama", SessionTime = DateTime.Now.AddHours(7), Price = 15.49m, ShortDescription = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", Rating = 9.2 },
        new Movie { Name = "Avatar", Genre = "Sci-Fi", SessionTime = DateTime.Now.AddHours(8), Price = 16.99m, ShortDescription = "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.", Rating = 7.8 },
        new Movie { Name = "The Lion King", Genre = "Animation", SessionTime = DateTime.Now.AddHours(9), Price = 7.99m, ShortDescription = "Lion prince Simba and his father are targeted by his bitter uncle, who wants to ascend the throne himself.", Rating = 8.5 },
        new Movie { Name = "Jurassic Park", Genre = "Action", SessionTime = DateTime.Now.AddHours(10), Price = 9.49m, ShortDescription = "During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run amok.", Rating = 8.1 }
    };

    private bool isSorted = false;

    public MovieForm()
    {
        InitializeComponent();
    }

    private void MovieForm_Load(object sender, EventArgs e)
    {
        comboBoxGenre.Items.Add("Action");
        comboBoxGenre.Items.Add("Drama");
        comboBoxGenre.Items.Add("Sci-Fi");
        comboBoxGenre.Items.Add("Crime");
        comboBoxGenre.Items.Add("Fantasy");

        LoadMoviesList();
    }

    private void LoadMoviesList(List<Movie> movieList = null)
    {
        listBoxMovies.Items.Clear();
        var moviesToDisplay = movieList ?? movies;

        foreach (var movie in moviesToDisplay)
        {
            listBoxMovies.Items.Add($"{movie.Name} (Rating: {movie.Rating})");
        }
    }

    private void buttonSortByRating_Click(object sender, EventArgs e)
    {
        if (isSorted)
        {
            LoadMoviesList();
            isSorted = false;
        }
        else
        {
            var sortedMovies = movies.OrderByDescending(m => m.Rating).ToList();
            LoadMoviesList(sortedMovies);
            isSorted = true;
        }
    }

    private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedGenre = comboBoxGenre.SelectedItem.ToString();
        var filteredMovies = movies.Where(m => m.Genre == selectedGenre).ToList();
        LoadMoviesList(filteredMovies);
    }

    private void buttonPlaceOrder_Click(object sender, EventArgs e)
    {
        if (listBoxMovies.SelectedItem == null)
        {
            MessageBox.Show("Please select a movie first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var selectedMovieName = listBoxMovies.SelectedItem.ToString().Split('(')[0].Trim();
        var selectedMovie = movies.FirstOrDefault(m => m.Name == selectedMovieName);

        if (selectedMovie != null)
        {
            CheckoutForm checkoutForm = new CheckoutForm(selectedMovie);
            checkoutForm.Show();
            this.Hide();
        }
    }

    private void listBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxMovies.SelectedItem != null)
        {
            var selectedMovieName = listBoxMovies.SelectedItem.ToString().Split('(')[0].Trim();
            var selectedMovie = movies.FirstOrDefault(m => m.Name == selectedMovieName);

            if (selectedMovie != null)
            {
                selectedMovie.ShowDetails();
            }
        }
    }
}
