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
        int answer = 0;
        int remainingSeconds = 10;

        public Startup()
        {
            InitializeComponent();
        }

        private async void NewGame_Click(object sender, EventArgs e)
        {
            GameApiEntity game = await SmileGameApi.GetDataAsync();
            imgResult.Image = Image.FromFile(game.Question.Substring(game.Question.LastIndexOf("/") + 1));
            answer = game.Solution;
            answerTimer.Start();
        }

        private void CheckAnswer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnswer.Text) == false)
            {
                if (txtAnswer.Text == answer.ToString())
                {
                    MessageBox.Show("Correct!");
                    answerTimer.Stop();
                    remainingSeconds = 10;
                }
                else
                    MessageBox.Show("Inccorect!");
            }
            else
                MessageBox.Show("Answer cannot be empty!");
        }
       
        private void AnswerTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 1)
            {
                remainingSeconds = remainingSeconds - 1;
                Text = remainingSeconds.ToString();
            }
            else
            {
                answerTimer.Stop();
                remainingSeconds = 10;
                MessageBox.Show("Time's up! Correct answer was " + answer);
            }
        }
    }
}
