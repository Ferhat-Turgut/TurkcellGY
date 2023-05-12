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
            this.buttonGetMovies = new System.Windows.Forms.Button();
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonGetMovies
            // 
            this.buttonGetMovies.Location = new System.Drawing.Point(97, 12);
            this.buttonGetMovies.Name = "buttonGetMovies";
            this.buttonGetMovies.Size = new System.Drawing.Size(75, 23);
            this.buttonGetMovies.TabIndex = 0;
            this.buttonGetMovies.Text = "Getir";
            this.buttonGetMovies.UseVisualStyleBackColor = true;
            this.buttonGetMovies.Click += new System.EventHandler(this.buttonGetMovies_Click);
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.ItemHeight = 15;
            this.listBoxMovies.Location = new System.Drawing.Point(7, 56);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(243, 94);
            this.listBoxMovies.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 170);
            this.Controls.Add(this.listBoxMovies);
            this.Controls.Add(this.buttonGetMovies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonGetMovies;
        private ListBox listBoxMovies;
    }
}