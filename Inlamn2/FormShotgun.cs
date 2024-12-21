using Inlamn2.Classes;

namespace Inlamn2
{
    public partial class FormShotgun : Form
    {
        Actions actions = new();

        public FormShotgun()
        {
            InitializeComponent();

            Pictures("Hide");
            Update();
            GameOver();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            string outcome = actions.CompareActions("Shoot");
            lblOutcome.Text = outcome;

            Pictures(outcome);

            Update();
            GameOver();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string outcome = actions.CompareActions("Load");
            lblOutcome.Text = outcome;

            Pictures(outcome);

            Update();
            GameOver();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            string outcome = actions.CompareActions("Block");

            lblOutcome.Text = outcome;

            Pictures(outcome);

            Update();
            GameOver();
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            string outcome = actions.CompareActions("Shotgun");
            lblOutcome.Text = outcome;

            Pictures(outcome);

            Update();
            GameOver();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            actions.NewGame();
            Pictures("Hide");
            GameOver();
            Update();
            lblOutcome.Text = "ITS TIME TO DUEL";
        }

        private void GameOver()
        {
            if (Actions.Running == false)
            {
                btnShoot.Visible = false;
                btnLoad.Visible = false;
                btnBlock.Visible = false;
                btnShotgun.Visible = false;
                btnNewGame.Visible = true;
            }
            else if (Actions.PlayerAmmo == 3)
            {
                btnShoot.Visible = true;
                btnLoad.Visible = true;
                btnBlock.Visible = true;
                btnShotgun.Visible = true;
                btnNewGame.Visible = false;
            }
            else if (Actions.PlayerAmmo == 0)
            {
                btnShoot.Visible = false;
                btnLoad.Visible = true;
                btnBlock.Visible = true;
                btnShotgun.Visible = false;
                btnNewGame.Visible = false;
            }
            else
            {
                btnShoot.Visible = true;
                btnLoad.Visible = true;
                btnBlock.Visible = true;
                btnShotgun.Visible = false;
                btnNewGame.Visible = false;
            }

        }

        private void Update()
        {
            lblPlayerAmmo.Text = "Ammo: " + Actions.PlayerAmmo.ToString();
            lblPcAmmo.Text = "Computer Ammo: " + Actions.PcAmmo.ToString();
        }

        private void Pictures(string choice)
        {
            switch (choice)
            {
                case "Hide":
                    pictureBoxReload.Visible = false;
                    pictureBoxShoot.Visible = false;
                    pictureBoxBlock.Visible = false;
                    pictureBoxWin.Visible = false;
                    pictureBoxLose.Visible = false;
                    break;

                case "Win":
                    pictureBoxReload.Visible = false;
                    pictureBoxShoot.Visible = false;
                    pictureBoxBlock.Visible = false;
                    pictureBoxWin.Visible = true;
                    pictureBoxLose.Visible = false;
                    break;

                case "Lose":
                    pictureBoxReload.Visible = false;
                    pictureBoxShoot.Visible = false;
                    pictureBoxBlock.Visible = false;
                    pictureBoxWin.Visible = false;
                    pictureBoxLose.Visible = true;
                    break;

                case "Pc Shot":
                    pictureBoxReload.Visible = false;
                    pictureBoxShoot.Visible = true;
                    pictureBoxBlock.Visible = false;
                    pictureBoxWin.Visible = false;
                    pictureBoxLose.Visible = false;
                    break;

                case "Pc used Shotgun":
                    pictureBoxReload.Visible = false;
                    pictureBoxShoot.Visible = true;
                    pictureBoxBlock.Visible = false;
                    pictureBoxWin.Visible = false;
                    pictureBoxLose.Visible = false;
                    break;

                case "Pc Loaded":
                    pictureBoxReload.Visible = true;
                    pictureBoxShoot.Visible = false;
                    pictureBoxBlock.Visible = false;
                    pictureBoxWin.Visible = false;
                    pictureBoxLose.Visible = false;
                    break;

                case "Pc Blocked":
                    pictureBoxReload.Visible = false;
                    pictureBoxShoot.Visible = false;
                    pictureBoxBlock.Visible = true;
                    pictureBoxWin.Visible = false;
                    pictureBoxLose.Visible = false;
                    break;
            }

        }
    }
}
