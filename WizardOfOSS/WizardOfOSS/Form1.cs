using System.Windows.Forms;
using System.IO;
using System.Media;

namespace WizardOfOSS
{
    public partial class Form1 : Form
    {
        int score = 0;
        int seconds = 0;
        List<PictureBox> ballImages;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            score = 0;
            seconds = 0;
            lblTimer.Text = "00:00";

            foreach (var pic in ballImages)
            {
                pic.Visible = true;
            }

            gameTimer.Stop();
            gameTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add all PictureBoxes to a list
            ballImages = new List<PictureBox>
            {
                pbOrb1, pbOrb2, pbOrb3, pbOrb4,
                pbOrb5, pbOrb6, pbOrb7, pbOrb8,
                pbOrb9, pbOrb10, pbOrb11, pbOrb12
            };

            // Add click event for all
            foreach (var pic in ballImages)
            {
                pic.Click += Ball_Click;
            }

            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;

        }

        private void Ball_Click(object sender, EventArgs e)
        {
            PictureBox clicked = sender as PictureBox;
            if (clicked.Visible)
            {
                clicked.Visible = false;
                score++;

                if (score == 12)
                {
                    gameTimer.Stop();
                    MessageBox.Show($"You finished in {seconds} seconds");
                }
            }
        }



        private void GameTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTimer.Text = TimeSpan.FromSeconds(seconds).ToString(@"mm\:ss");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click Reset to start the game. Timer starts, score resets.\nClick all 12 orbs as quick as you can.\nGame ends and timer stops when all orbs are clicked.\nClick Reset to play again!");

        }

        private void pbWizard_Click(object sender, EventArgs e)
        {
            // Create a semi-transparent red color
            pbWizard.BackColor = Color.FromArgb(100, Color.Red);


            using (var stream = new MemoryStream(Properties.Resources.MinecraftDmgSfx))
            {
                SoundPlayer player = new SoundPlayer(stream);
                player.Play();
            }
        }
    }
}
