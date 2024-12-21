namespace Inlamn2
{
    partial class FormShotgun
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShotgun));
            btnShoot = new Button();
            btnBlock = new Button();
            lblOutcome = new Label();
            lblPlayerAmmo = new Label();
            lblPcAmmo = new Label();
            pictureBoxReload = new PictureBox();
            btnLoad = new Button();
            pictureBoxShoot = new PictureBox();
            pictureBoxBlock = new PictureBox();
            pictureBoxWin = new PictureBox();
            pictureBoxLose = new PictureBox();
            btnNewGame = new Button();
            btnShotgun = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxReload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShoot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLose).BeginInit();
            SuspendLayout();
            // 
            // btnShoot
            // 
            btnShoot.BackgroundImage = (Image)resources.GetObject("btnShoot.BackgroundImage");
            btnShoot.Location = new Point(28, 114);
            btnShoot.Name = "btnShoot";
            btnShoot.Size = new Size(96, 67);
            btnShoot.TabIndex = 0;
            btnShoot.Text = "Shoot";
            btnShoot.UseVisualStyleBackColor = true;
            btnShoot.Click += btnShoot_Click;
            // 
            // btnBlock
            // 
            btnBlock.BackgroundImage = (Image)resources.GetObject("btnBlock.BackgroundImage");
            btnBlock.Location = new Point(28, 187);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(96, 69);
            btnBlock.TabIndex = 2;
            btnBlock.Text = "Block";
            btnBlock.UseVisualStyleBackColor = true;
            btnBlock.Click += btnBlock_Click;
            // 
            // lblOutcome
            // 
            lblOutcome.AutoSize = true;
            lblOutcome.Location = new Point(225, 84);
            lblOutcome.Name = "lblOutcome";
            lblOutcome.Size = new Size(99, 15);
            lblOutcome.TabIndex = 3;
            lblOutcome.Text = "ITS TIME TO DUEL";
            // 
            // lblPlayerAmmo
            // 
            lblPlayerAmmo.AutoSize = true;
            lblPlayerAmmo.Location = new Point(78, 63);
            lblPlayerAmmo.Name = "lblPlayerAmmo";
            lblPlayerAmmo.Size = new Size(0, 15);
            lblPlayerAmmo.TabIndex = 4;
            // 
            // lblPcAmmo
            // 
            lblPcAmmo.AutoSize = true;
            lblPcAmmo.Location = new Point(427, 63);
            lblPcAmmo.Name = "lblPcAmmo";
            lblPcAmmo.Size = new Size(0, 15);
            lblPcAmmo.TabIndex = 5;
            // 
            // pictureBoxReload
            // 
            pictureBoxReload.Image = (Image)resources.GetObject("pictureBoxReload.Image");
            pictureBoxReload.Location = new Point(351, 140);
            pictureBoxReload.Name = "pictureBoxReload";
            pictureBoxReload.Size = new Size(256, 158);
            pictureBoxReload.TabIndex = 6;
            pictureBoxReload.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.BackgroundImage = (Image)resources.GetObject("btnLoad.BackgroundImage");
            btnLoad.Location = new Point(130, 114);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(102, 67);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // pictureBoxShoot
            // 
            pictureBoxShoot.Image = (Image)resources.GetObject("pictureBoxShoot.Image");
            pictureBoxShoot.Location = new Point(364, 98);
            pictureBoxShoot.Name = "pictureBoxShoot";
            pictureBoxShoot.Size = new Size(219, 214);
            pictureBoxShoot.TabIndex = 7;
            pictureBoxShoot.TabStop = false;
            // 
            // pictureBoxBlock
            // 
            pictureBoxBlock.Image = (Image)resources.GetObject("pictureBoxBlock.Image");
            pictureBoxBlock.Location = new Point(393, 158);
            pictureBoxBlock.Name = "pictureBoxBlock";
            pictureBoxBlock.Size = new Size(181, 140);
            pictureBoxBlock.TabIndex = 8;
            pictureBoxBlock.TabStop = false;
            // 
            // pictureBoxWin
            // 
            pictureBoxWin.Image = (Image)resources.GetObject("pictureBoxWin.Image");
            pictureBoxWin.Location = new Point(394, 98);
            pictureBoxWin.Name = "pictureBoxWin";
            pictureBoxWin.Size = new Size(180, 200);
            pictureBoxWin.TabIndex = 9;
            pictureBoxWin.TabStop = false;
            // 
            // pictureBoxLose
            // 
            pictureBoxLose.Image = (Image)resources.GetObject("pictureBoxLose.Image");
            pictureBoxLose.Location = new Point(404, 84);
            pictureBoxLose.Name = "pictureBoxLose";
            pictureBoxLose.Size = new Size(170, 228);
            pictureBoxLose.TabIndex = 10;
            pictureBoxLose.TabStop = false;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(49, 271);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(148, 62);
            btnNewGame.TabIndex = 11;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnShotgun
            // 
            btnShotgun.BackgroundImage = (Image)resources.GetObject("btnShotgun.BackgroundImage");
            btnShotgun.Location = new Point(130, 187);
            btnShotgun.Name = "btnShotgun";
            btnShotgun.Size = new Size(121, 69);
            btnShotgun.TabIndex = 12;
            btnShotgun.Text = "SHOTGUN";
            btnShotgun.UseVisualStyleBackColor = true;
            btnShotgun.Click += btnShotgun_Click;
            // 
            // FormShotgun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 358);
            Controls.Add(btnShotgun);
            Controls.Add(btnNewGame);
            Controls.Add(pictureBoxLose);
            Controls.Add(pictureBoxWin);
            Controls.Add(pictureBoxBlock);
            Controls.Add(pictureBoxShoot);
            Controls.Add(pictureBoxReload);
            Controls.Add(lblPcAmmo);
            Controls.Add(lblPlayerAmmo);
            Controls.Add(lblOutcome);
            Controls.Add(btnBlock);
            Controls.Add(btnLoad);
            Controls.Add(btnShoot);
            Name = "FormShotgun";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxReload).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShoot).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShoot;
        private Button btnBlock;
        private Label lblOutcome;
        private Label lblPlayerAmmo;
        private Label lblPcAmmo;
        private PictureBox pictureBoxReload;
        private Button btnLoad;
        private PictureBox pictureBoxShoot;
        private PictureBox pictureBoxBlock;
        private PictureBox pictureBoxWin;
        private PictureBox pictureBoxLose;
        private Button btnNewGame;
        private Button btnShotgun;
    }
}
