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
    public partial class FormDirectors : Form
    {
        public FormDirectors()
        {
            InitializeComponent();
        }
        DirectorService directorService = null;
         
        private async void FormDirectors_Load(object sender, EventArgs e)
        {
            var context = new MoviesDbContext();
            var repo = new EFDirectorRepository(context);
            directorService = new DirectorService(repo);

            await fillDirectorGrid();

        }

        private async Task fillDirectorGrid()
        {
            var directors = await directorService.GetDirectorsAsync();
            dataGridViewDirectors.DataSource = directors.ToList();
        }

        private async void buttonAddDirector_Click(object sender, EventArgs e)
        {
            var request = new CreateNewDirectorRequest 
            {
                Name=textBoxDirectorName.Text,
                LastName=textBoxDirectorLastname.Text,
                Info=textBoxDirectorInfo.Text
            };
            var directorId=await directorService.CreateNewDirectorAsync(request);

            var message = directorId != 0 ? "Ok" : "Failed";
            MessageBox.Show(message);

            await fillDirectorGrid();

        }

        int selectedDirectorId = 0;
        private async void dataGridViewDirectors_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDirectorId = (int)dataGridViewDirectors.Rows[e.RowIndex].Cells[0].Value;
            var director=await directorService.GetDirectorAsync(selectedDirectorId);

            textBoxDirectorName.Text=director.Name;
            textBoxDirectorLastname.Text = director.LastName;
            textBoxDirectorInfo.Text=director.Info;

            buttonUpdateDirector.Enabled = selectedDirectorId != 0;
        }

        private async void buttonUpdateDirector_Click(object sender, EventArgs e)
        {
          
                var request = new UpdateDirectorRequest 
                {
                    Id=selectedDirectorId,
                    Name=textBoxDirectorName.Text,
                    LastName=textBoxDirectorLastname.Text,
                    Info=textBoxDirectorInfo.Text
                };
                await directorService.UpdateDirectorAsync(request);
                
                await fillDirectorGrid();
            
        }
    }
}
