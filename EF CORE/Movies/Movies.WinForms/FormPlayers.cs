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
    public partial class FormPlayers : Form
    {
        PlayerService playerService = null;
        public FormPlayers()
        {
            InitializeComponent();
            
            MoviesDbContext dbContext=new MoviesDbContext();
            EFPlayerRepository eFPlayerRepository = new EFPlayerRepository(dbContext);
            playerService = new PlayerService(eFPlayerRepository);
        }
        
        private async void FormPlayers_Load(object sender, EventArgs e)
        {
            await FillPlayerGrid();
        }
        
        private async Task FillPlayerGrid()
        {
            var players = await playerService.GetPlayerLists();
            dataGridViewPlayers.DataSource = players.ToList();
        }
        private void cleanPage()
        {
            textBoxPlayerName.Clear();
            textBoxPlayerLastname.Clear();
            textBoxPlayerInfo.Clear();
        }

        private async void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            var playerDto =new CreateNewPlayerRequset
                {
                    Name=textBoxPlayerName.Text,
                    LastName=textBoxPlayerLastname.Text,
                    Info=textBoxPlayerInfo.Text
                };
            await playerService.CreateNewPlayer(playerDto);
            await FillPlayerGrid();
            cleanPage();
        }
        int selectedPlayerId = 0;
        private async void dataGridViewPlayers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPlayerId = (int)dataGridViewPlayers.Rows[e.RowIndex].Cells[0].Value;
            var player =await  playerService.GetPlayerAsync(selectedPlayerId);

            textBoxPlayerName.Text = player.Name;
            textBoxPlayerLastname.Text = player.LastName;
            textBoxPlayerInfo.Text = player.Info;

            buttonUpdatePlayer.Enabled = selectedPlayerId != 0;
        }

        private async void buttonUpdatePlayer_Click(object sender, EventArgs e)
        {
            var request = new UpdatePlayerRequest
            {
                Id = selectedPlayerId,
                Name = textBoxPlayerName.Text,
                LastName = textBoxPlayerLastname.Text,
                Info = textBoxPlayerInfo.Text
            };
            await playerService.UpdatePlayerAsync(request);

            await FillPlayerGrid();
            cleanPage();
        }

   
    }
}
