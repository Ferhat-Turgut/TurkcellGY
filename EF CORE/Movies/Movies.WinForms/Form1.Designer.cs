namespace Movies.WinForms
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.buttonPlayers = new System.Windows.Forms.Button();
            this.buttonDirectors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewMovies);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonPlayers);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDirectors);
            this.splitContainer1.Size = new System.Drawing.Size(715, 306);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMovies.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.RowTemplate.Height = 25;
            this.dataGridViewMovies.Size = new System.Drawing.Size(711, 189);
            this.dataGridViewMovies.TabIndex = 0;
            // 
            // buttonPlayers
            // 
            this.buttonPlayers.Location = new System.Drawing.Point(10, 56);
            this.buttonPlayers.Name = "buttonPlayers";
            this.buttonPlayers.Size = new System.Drawing.Size(137, 23);
            this.buttonPlayers.TabIndex = 1;
            this.buttonPlayers.Text = "Oyuncu İşlemleri";
            this.buttonPlayers.UseVisualStyleBackColor = true;
            this.buttonPlayers.Click += new System.EventHandler(this.buttonPlayers_Click);
            // 
            // buttonDirectors
            // 
            this.buttonDirectors.Location = new System.Drawing.Point(10, 27);
            this.buttonDirectors.Name = "buttonDirectors";
            this.buttonDirectors.Size = new System.Drawing.Size(137, 23);
            this.buttonDirectors.TabIndex = 0;
            this.buttonDirectors.Text = "Yönetmen İşlemleri";
            this.buttonDirectors.UseVisualStyleBackColor = true;
            this.buttonDirectors.Click += new System.EventHandler(this.buttonDirectors_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 306);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridViewMovies;
        private Button buttonPlayers;
        private Button buttonDirectors;
    }
}