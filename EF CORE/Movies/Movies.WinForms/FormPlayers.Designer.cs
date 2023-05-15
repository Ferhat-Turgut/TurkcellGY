namespace Movies.WinForms
{
    partial class FormPlayers
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
            this.buttonUpdatePlayer = new System.Windows.Forms.Button();
            this.groupBoxDirectors = new System.Windows.Forms.GroupBox();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlayerInfo = new System.Windows.Forms.TextBox();
            this.textBoxPlayerLastname = new System.Windows.Forms.TextBox();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.groupBoxDirectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdatePlayer
            // 
            this.buttonUpdatePlayer.Enabled = false;
            this.buttonUpdatePlayer.Location = new System.Drawing.Point(56, 166);
            this.buttonUpdatePlayer.Name = "buttonUpdatePlayer";
            this.buttonUpdatePlayer.Size = new System.Drawing.Size(122, 23);
            this.buttonUpdatePlayer.TabIndex = 17;
            this.buttonUpdatePlayer.Text = "Oyuncu Güncelle";
            this.buttonUpdatePlayer.UseVisualStyleBackColor = true;
            this.buttonUpdatePlayer.Click += new System.EventHandler(this.buttonUpdatePlayer_Click);
            // 
            // groupBoxDirectors
            // 
            this.groupBoxDirectors.Controls.Add(this.dataGridViewPlayers);
            this.groupBoxDirectors.Location = new System.Drawing.Point(194, 12);
            this.groupBoxDirectors.Name = "groupBoxDirectors";
            this.groupBoxDirectors.Size = new System.Drawing.Size(377, 177);
            this.groupBoxDirectors.TabIndex = 16;
            this.groupBoxDirectors.TabStop = false;
            this.groupBoxDirectors.Text = "Oyuncular";
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowTemplate.Height = 25;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(371, 155);
            this.dataGridViewPlayers.TabIndex = 0;
            this.dataGridViewPlayers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlayers_CellDoubleClick);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(56, 137);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(122, 23);
            this.buttonAddPlayer.TabIndex = 15;
            this.buttonAddPlayer.Text = "Oyuncu Ekle";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "İnfo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad:";
            // 
            // textBoxPlayerInfo
            // 
            this.textBoxPlayerInfo.Location = new System.Drawing.Point(56, 108);
            this.textBoxPlayerInfo.Name = "textBoxPlayerInfo";
            this.textBoxPlayerInfo.Size = new System.Drawing.Size(122, 23);
            this.textBoxPlayerInfo.TabIndex = 11;
            // 
            // textBoxPlayerLastname
            // 
            this.textBoxPlayerLastname.Location = new System.Drawing.Point(56, 72);
            this.textBoxPlayerLastname.Name = "textBoxPlayerLastname";
            this.textBoxPlayerLastname.Size = new System.Drawing.Size(122, 23);
            this.textBoxPlayerLastname.TabIndex = 10;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(56, 34);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(122, 23);
            this.textBoxPlayerName.TabIndex = 9;
            // 
            // FormPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 199);
            this.Controls.Add(this.buttonUpdatePlayer);
            this.Controls.Add(this.groupBoxDirectors);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlayerInfo);
            this.Controls.Add(this.textBoxPlayerLastname);
            this.Controls.Add(this.textBoxPlayerName);
            this.Name = "FormPlayers";
            this.Text = "FormPlayers";
            this.Load += new System.EventHandler(this.FormPlayers_Load);
            this.groupBoxDirectors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonUpdatePlayer;
        private GroupBox groupBoxDirectors;
        private DataGridView dataGridViewPlayers;
        private Button buttonAddPlayer;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxPlayerInfo;
        private TextBox textBoxPlayerLastname;
        private TextBox textBoxPlayerName;
    }
}