using Movies.Application;
using Movies.Application.DTOs.Requests;
using Movies.Data.Data;
using Movies.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies.WinForms
{
    public partial class FormMovies : Form
    {
        public FormMovies()
        {
            InitializeComponent();
            MoviesDbContext dbContext = new MoviesDbContext();
            EFPlayerRepository playerRepository = new EFPlayerRepository(dbContext);
            EFMovieRepository movieRepository = new EFMovieRepository(dbContext);
            EFDirectorRepository directorRepository = new EFDirectorRepository(dbContext);

            playerService = new PlayerService(playerRepository);
            movieService = new MovieService(movieRepository);
            directorService = new DirectorService(directorRepository);
        }

        private readonly IPlayerService playerService;
        private readonly IMovieService movieService;
        private readonly IDirectorService directorService;
        private async void FormMovies_Load(object sender, EventArgs e)
        {
           await fillDirectors();
           await fillPlayers();
           
        }

        private async Task fillPlayers()
        {
            var players=await playerService.GetPlayerLists();
            var playerFullName = players.Select(p => new
            {
                Id = p.Id,
                FullName = $"{p.Name} {p.LastName}"
            }) ;

            listBoxPlayers.DataSource = playerFullName.ToList();
            listBoxPlayers.DisplayMember= "FullName";
            listBoxPlayers.ValueMember = "Id";
        }

        private async Task fillDirectors()
        {
            var directors =await directorService.GetDirectorsAsync();
            var directorFullName = directors.Select(d=> new
            {
                Id = d.Id,
                FullName=$"{d.Name} {d.LastName}"
            });

            comboBoxDirectors.DataSource = directorFullName.ToList();
            comboBoxDirectors.DisplayMember= "FullName";
            comboBoxDirectors.ValueMember = "Id";
        }

        

        private async void buttonAddMovie_Click(object sender, EventArgs e)
        {

            //dynamic aValue = "Deneme";   // dynamic runtime da çalışır ve tipine runtime da karar verir.
            //MessageBox.Show(aValue);


            List<int> selectedPlayerIds = new List<int>();

            foreach (dynamic item in listBoxPlayers.SelectedItems)
            {
                selectedPlayerIds.Add(item.Id);
            }

            var CreateNewMovieRequest = new CreateNewMovieRequest
            {
                Name = textBoxTittle.Text,
                PublishDate = dateTimePickerPublishDate.Value,
                Duration = Convert.ToInt32(textBoxDuration.Text),
                DirectorId = (int)comboBoxDirectors.SelectedValue
            };

            var movieId =await movieService.CreateNewMovie(CreateNewMovieRequest);

            await movieService.AddPlayerToMovie(movieId, selectedPlayerIds);


        }
    }
}
