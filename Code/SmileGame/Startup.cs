using SmileGame.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmileGame
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private async void NewGame_Click(object sender, EventArgs e)
        {
            GameApiEntity game = await SmileGameApi.GetDataAsync();
            imgResult.Image = Image.FromFile(game.Question.Substring(game.Question.LastIndexOf("/") + 1));
        }
    }
}
