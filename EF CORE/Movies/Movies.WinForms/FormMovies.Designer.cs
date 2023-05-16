namespace Movies.WinForms
{
    partial class FormMovies
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
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.groupBoxPlayers = new System.Windows.Forms.GroupBox();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDirectors = new System.Windows.Forms.ComboBox();
            this.textBoxTittle = new System.Windows.Forms.TextBox();
            this.dateTimePickerPublishDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(316, 273);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(194, 23);
            this.buttonAddMovie.TabIndex = 0;
            this.buttonAddMovie.Text = "Film Kaydet";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // groupBoxPlayers
            // 
            this.groupBoxPlayers.Controls.Add(this.listBoxPlayers);
            this.groupBoxPlayers.Location = new System.Drawing.Point(13, 12);
            this.groupBoxPlayers.Name = "groupBoxPlayers";
            this.groupBoxPlayers.Size = new System.Drawing.Size(293, 292);
            this.groupBoxPlayers.TabIndex = 1;
            this.groupBoxPlayers.TabStop = false;
            this.groupBoxPlayers.Text = "Oyuncular";
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 15;
            this.listBoxPlayers.Location = new System.Drawing.Point(3, 19);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxPlayers.Size = new System.Drawing.Size(287, 270);
            this.listBoxPlayers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film Adı:";
            // 
            // comboBoxDirectors
            // 
            this.comboBoxDirectors.FormattingEnabled = true;
            this.comboBoxDirectors.Location = new System.Drawing.Point(387, 146);
            this.comboBoxDirectors.Name = "comboBoxDirectors";
            this.comboBoxDirectors.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDirectors.TabIndex = 3;
            // 
            // textBoxTittle
            // 
            this.textBoxTittle.Location = new System.Drawing.Point(387, 32);
            this.textBoxTittle.Name = "textBoxTittle";
            this.textBoxTittle.Size = new System.Drawing.Size(100, 23);
            this.textBoxTittle.TabIndex = 4;
            // 
            // dateTimePickerPublishDate
            // 
            this.dateTimePickerPublishDate.CustomFormat = "dd.MM.yyy";
            this.dateTimePickerPublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPublishDate.Location = new System.Drawing.Point(387, 67);
            this.dateTimePickerPublishDate.Name = "dateTimePickerPublishDate";
            this.dateTimePickerPublishDate.Size = new System.Drawing.Size(100, 23);
            this.dateTimePickerPublishDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yayın Tarihi:";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(387, 107);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 23);
            this.textBoxDuration.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Film Süresi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yönetmen:";
            // 
            // FormMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 308);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerPublishDate);
            this.Controls.Add(this.textBoxTittle);
            this.Controls.Add(this.comboBoxDirectors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxPlayers);
            this.Controls.Add(this.buttonAddMovie);
            this.Name = "FormMovies";
            this.Text = "FormMovies";
            this.Load += new System.EventHandler(this.FormMovies_Load);
            this.groupBoxPlayers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddMovie;
        private GroupBox groupBoxPlayers;
        private ListBox listBoxPlayers;
        private Label label1;
        private ComboBox comboBoxDirectors;
        private TextBox textBoxTittle;
        private DateTimePicker dateTimePickerPublishDate;
        private Label label2;
        private TextBox textBoxDuration;
        private Label label3;
        private Label label4;
    }
}