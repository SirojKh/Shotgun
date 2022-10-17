namespace Shotgun
{
    partial class Shotgun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerShellScore = new System.Windows.Forms.Label();
            this.cpuShellScore = new System.Windows.Forms.Label();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 38;
            this.listBox1.Location = new System.Drawing.Point(264, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 194);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 38;
            this.listBox2.Location = new System.Drawing.Point(609, 169);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(260, 194);
            this.listBox2.TabIndex = 1;
            // 
            // lblComputer
            // 
            this.lblComputer.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComputer.Location = new System.Drawing.Point(264, 94);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(260, 52);
            this.lblComputer.TabIndex = 2;
            this.lblComputer.Text = "Computer";
            this.lblComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer
            // 
            this.lblPlayer.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer.Location = new System.Drawing.Point(609, 94);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(260, 52);
            this.lblPlayer.TabIndex = 3;
            this.lblPlayer.Text = "Player";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(264, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shell:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(609, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shell:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerShellScore
            // 
            this.playerShellScore.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerShellScore.Location = new System.Drawing.Point(760, 426);
            this.playerShellScore.Name = "playerShellScore";
            this.playerShellScore.Size = new System.Drawing.Size(69, 48);
            this.playerShellScore.TabIndex = 7;
            this.playerShellScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuShellScore
            // 
            this.cpuShellScore.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpuShellScore.Location = new System.Drawing.Point(403, 426);
            this.cpuShellScore.Name = "cpuShellScore";
            this.cpuShellScore.Size = new System.Drawing.Size(69, 48);
            this.cpuShellScore.TabIndex = 8;
            this.cpuShellScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(1021, 169);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(112, 34);
            this.btnShoot.TabIndex = 9;
            this.btnShoot.Text = "Skjuta";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click_1);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(1021, 219);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(112, 34);
            this.btnReload.TabIndex = 10;
            this.btnReload.Text = "Ladda";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click_1);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(1021, 268);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(112, 34);
            this.btnBlock.TabIndex = 11;
            this.btnBlock.Text = "Blocka";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click_1);
            // 
            // btnShotgun
            // 
            this.btnShotgun.Location = new System.Drawing.Point(1021, 320);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(112, 34);
            this.btnShotgun.TabIndex = 12;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1021, 373);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 34);
            this.button5.TabIndex = 13;
            this.button5.Text = "Starta om";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Shotgun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 608);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.cpuShellScore);
            this.Controls.Add(this.playerShellScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Shotgun";
            this.Text = "Shotgun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Label lblComputer;
        private Label lblPlayer;
        private Label label1;
        private Label label2;
        private Label playerShellScore;
        private Label cpuShellScore;
        private Button btnShoot;
        private Button btnReload;
        private Button btnBlock;
        private Button btnShotgun;
        private Button button5;
    }
}