namespace Movies.WinForms
{
    partial class FormDirectors
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
            this.textBoxDirectorName = new System.Windows.Forms.TextBox();
            this.textBoxDirectorLastname = new System.Windows.Forms.TextBox();
            this.textBoxDirectorInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddDirector = new System.Windows.Forms.Button();
            this.groupBoxDirectors = new System.Windows.Forms.GroupBox();
            this.dataGridViewDirectors = new System.Windows.Forms.DataGridView();
            this.buttonUpdateDirector = new System.Windows.Forms.Button();
            this.groupBoxDirectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectors)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDirectorName
            // 
            this.textBoxDirectorName.Location = new System.Drawing.Point(50, 34);
            this.textBoxDirectorName.Name = "textBoxDirectorName";
            this.textBoxDirectorName.Size = new System.Drawing.Size(122, 23);
            this.textBoxDirectorName.TabIndex = 0;
            // 
            // textBoxDirectorLastname
            // 
            this.textBoxDirectorLastname.Location = new System.Drawing.Point(50, 72);
            this.textBoxDirectorLastname.Name = "textBoxDirectorLastname";
            this.textBoxDirectorLastname.Size = new System.Drawing.Size(122, 23);
            this.textBoxDirectorLastname.TabIndex = 1;
            // 
            // textBoxDirectorInfo
            // 
            this.textBoxDirectorInfo.Location = new System.Drawing.Point(50, 108);
            this.textBoxDirectorInfo.Name = "textBoxDirectorInfo";
            this.textBoxDirectorInfo.Size = new System.Drawing.Size(122, 23);
            this.textBoxDirectorInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "İnfo:";
            // 
            // buttonAddDirector
            // 
            this.buttonAddDirector.Location = new System.Drawing.Point(50, 137);
            this.buttonAddDirector.Name = "buttonAddDirector";
            this.buttonAddDirector.Size = new System.Drawing.Size(122, 23);
            this.buttonAddDirector.TabIndex = 6;
            this.buttonAddDirector.Text = "Yönetmen Ekle";
            this.buttonAddDirector.UseVisualStyleBackColor = true;
            this.buttonAddDirector.Click += new System.EventHandler(this.buttonAddDirector_Click);
            // 
            // groupBoxDirectors
            // 
            this.groupBoxDirectors.Controls.Add(this.dataGridViewDirectors);
            this.groupBoxDirectors.Location = new System.Drawing.Point(188, 12);
            this.groupBoxDirectors.Name = "groupBoxDirectors";
            this.groupBoxDirectors.Size = new System.Drawing.Size(377, 177);
            this.groupBoxDirectors.TabIndex = 7;
            this.groupBoxDirectors.TabStop = false;
            this.groupBoxDirectors.Text = "Yönetmenler";
            // 
            // dataGridViewDirectors
            // 
            this.dataGridViewDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDirectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDirectors.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewDirectors.Name = "dataGridViewDirectors";
            this.dataGridViewDirectors.RowTemplate.Height = 25;
            this.dataGridViewDirectors.Size = new System.Drawing.Size(371, 155);
            this.dataGridViewDirectors.TabIndex = 0;
            this.dataGridViewDirectors.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDirectors_CellContentDoubleClick);
            // 
            // buttonUpdateDirector
            // 
            this.buttonUpdateDirector.Enabled = false;
            this.buttonUpdateDirector.Location = new System.Drawing.Point(50, 166);
            this.buttonUpdateDirector.Name = "buttonUpdateDirector";
            this.buttonUpdateDirector.Size = new System.Drawing.Size(122, 23);
            this.buttonUpdateDirector.TabIndex = 8;
            this.buttonUpdateDirector.Text = "Yönetmen Güncelle";
            this.buttonUpdateDirector.UseVisualStyleBackColor = true;
            this.buttonUpdateDirector.Click += new System.EventHandler(this.buttonUpdateDirector_Click);
            // 
            // FormDirectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 191);
            this.Controls.Add(this.buttonUpdateDirector);
            this.Controls.Add(this.groupBoxDirectors);
            this.Controls.Add(this.buttonAddDirector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDirectorInfo);
            this.Controls.Add(this.textBoxDirectorLastname);
            this.Controls.Add(this.textBoxDirectorName);
            this.Name = "FormDirectors";
            this.Text = "FormDirectors";
            this.Load += new System.EventHandler(this.FormDirectors_Load);
            this.groupBoxDirectors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxDirectorName;
        private TextBox textBoxDirectorLastname;
        private TextBox textBoxDirectorInfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAddDirector;
        private GroupBox groupBoxDirectors;
        private DataGridView dataGridViewDirectors;
        private Button buttonUpdateDirector;
    }
}