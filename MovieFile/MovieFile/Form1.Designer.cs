namespace MovieFile
{
    partial class Form1
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
            this.btnInsertMovieView = new System.Windows.Forms.Button();
            this.btnUpdateMovieView = new System.Windows.Forms.Button();
            this.btnDeleteMovieView = new System.Windows.Forms.Button();
            this.pnlInsertMovie = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpMovieReleasedInsert = new System.Windows.Forms.DateTimePicker();
            this.btnInsertMovie = new System.Windows.Forms.Button();
            this.cbCategoryInsert = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMovieTitleInsert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMovieIdInsert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.pnlUpdateMovie = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpMovieReleasedUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.cbCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMovieTitleUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMovieIdUpdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlDeleteMovie = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpMovieReleasedDelete = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.cbCategoryDelete = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMovieTitleDelete = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMovieIdDelete = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlInsertMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.pnlUpdateMovie.SuspendLayout();
            this.pnlDeleteMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertMovieView
            // 
            this.btnInsertMovieView.Location = new System.Drawing.Point(16, 11);
            this.btnInsertMovieView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertMovieView.Name = "btnInsertMovieView";
            this.btnInsertMovieView.Size = new System.Drawing.Size(160, 28);
            this.btnInsertMovieView.TabIndex = 0;
            this.btnInsertMovieView.Text = "Insert movie view";
            this.btnInsertMovieView.UseVisualStyleBackColor = true;
            this.btnInsertMovieView.Click += new System.EventHandler(this.btnInsertMovieView_Click);
            // 
            // btnUpdateMovieView
            // 
            this.btnUpdateMovieView.Location = new System.Drawing.Point(181, 11);
            this.btnUpdateMovieView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateMovieView.Name = "btnUpdateMovieView";
            this.btnUpdateMovieView.Size = new System.Drawing.Size(160, 28);
            this.btnUpdateMovieView.TabIndex = 1;
            this.btnUpdateMovieView.Text = "Update movie view";
            this.btnUpdateMovieView.UseVisualStyleBackColor = true;
            this.btnUpdateMovieView.Click += new System.EventHandler(this.btnUpdateMovieView_Click);
            // 
            // btnDeleteMovieView
            // 
            this.btnDeleteMovieView.Location = new System.Drawing.Point(347, 11);
            this.btnDeleteMovieView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteMovieView.Name = "btnDeleteMovieView";
            this.btnDeleteMovieView.Size = new System.Drawing.Size(160, 28);
            this.btnDeleteMovieView.TabIndex = 2;
            this.btnDeleteMovieView.Text = "Delete movie view";
            this.btnDeleteMovieView.UseVisualStyleBackColor = true;
            this.btnDeleteMovieView.Click += new System.EventHandler(this.btnDeleteMovieView_Click);
            // 
            // pnlInsertMovie
            // 
            this.pnlInsertMovie.Controls.Add(this.label5);
            this.pnlInsertMovie.Controls.Add(this.dtpMovieReleasedInsert);
            this.pnlInsertMovie.Controls.Add(this.btnInsertMovie);
            this.pnlInsertMovie.Controls.Add(this.cbCategoryInsert);
            this.pnlInsertMovie.Controls.Add(this.label4);
            this.pnlInsertMovie.Controls.Add(this.txtMovieTitleInsert);
            this.pnlInsertMovie.Controls.Add(this.label3);
            this.pnlInsertMovie.Controls.Add(this.txtMovieIdInsert);
            this.pnlInsertMovie.Controls.Add(this.label2);
            this.pnlInsertMovie.Controls.Add(this.label1);
            this.pnlInsertMovie.Location = new System.Drawing.Point(16, 71);
            this.pnlInsertMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInsertMovie.Name = "pnlInsertMovie";
            this.pnlInsertMovie.Size = new System.Drawing.Size(416, 448);
            this.pnlInsertMovie.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Movie released day:";
            // 
            // dtpMovieReleasedInsert
            // 
            this.dtpMovieReleasedInsert.Location = new System.Drawing.Point(36, 332);
            this.dtpMovieReleasedInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpMovieReleasedInsert.Name = "dtpMovieReleasedInsert";
            this.dtpMovieReleasedInsert.Size = new System.Drawing.Size(265, 22);
            this.dtpMovieReleasedInsert.TabIndex = 8;
            // 
            // btnInsertMovie
            // 
            this.btnInsertMovie.Location = new System.Drawing.Point(37, 399);
            this.btnInsertMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertMovie.Name = "btnInsertMovie";
            this.btnInsertMovie.Size = new System.Drawing.Size(132, 28);
            this.btnInsertMovie.TabIndex = 7;
            this.btnInsertMovie.Text = "Insert the movie";
            this.btnInsertMovie.UseVisualStyleBackColor = true;
            this.btnInsertMovie.Click += new System.EventHandler(this.btnInsertMovie_Click);
            // 
            // cbCategoryInsert
            // 
            this.cbCategoryInsert.FormattingEnabled = true;
            this.cbCategoryInsert.Items.AddRange(new object[] {
            "Comedy",
            "Action",
            "Horror"});
            this.cbCategoryInsert.Location = new System.Drawing.Point(36, 260);
            this.cbCategoryInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategoryInsert.Name = "cbCategoryInsert";
            this.cbCategoryInsert.Size = new System.Drawing.Size(160, 24);
            this.cbCategoryInsert.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Movie category:";
            // 
            // txtMovieTitleInsert
            // 
            this.txtMovieTitleInsert.Location = new System.Drawing.Point(36, 183);
            this.txtMovieTitleInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieTitleInsert.Name = "txtMovieTitleInsert";
            this.txtMovieTitleInsert.Size = new System.Drawing.Size(132, 22);
            this.txtMovieTitleInsert.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Movie Title:";
            // 
            // txtMovieIdInsert
            // 
            this.txtMovieIdInsert.Location = new System.Drawing.Point(36, 110);
            this.txtMovieIdInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieIdInsert.Name = "txtMovieIdInsert";
            this.txtMovieIdInsert.Size = new System.Drawing.Size(132, 22);
            this.txtMovieIdInsert.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Movie";
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AllowUserToResizeColumns = false;
            this.dgvMovies.AllowUserToResizeRows = false;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(457, 71);
            this.dgvMovies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMovies.MultiSelect = false;
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.Size = new System.Drawing.Size(593, 448);
            this.dgvMovies.TabIndex = 4;
            this.dgvMovies.SelectionChanged += new System.EventHandler(this.dgvMovies_SelectionChanged);
            // 
            // pnlUpdateMovie
            // 
            this.pnlUpdateMovie.Controls.Add(this.label6);
            this.pnlUpdateMovie.Controls.Add(this.dtpMovieReleasedUpdate);
            this.pnlUpdateMovie.Controls.Add(this.btnUpdateMovie);
            this.pnlUpdateMovie.Controls.Add(this.cbCategoryUpdate);
            this.pnlUpdateMovie.Controls.Add(this.label7);
            this.pnlUpdateMovie.Controls.Add(this.txtMovieTitleUpdate);
            this.pnlUpdateMovie.Controls.Add(this.label8);
            this.pnlUpdateMovie.Controls.Add(this.txtMovieIdUpdate);
            this.pnlUpdateMovie.Controls.Add(this.label9);
            this.pnlUpdateMovie.Controls.Add(this.label10);
            this.pnlUpdateMovie.Location = new System.Drawing.Point(16, 71);
            this.pnlUpdateMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUpdateMovie.Name = "pnlUpdateMovie";
            this.pnlUpdateMovie.Size = new System.Drawing.Size(416, 448);
            this.pnlUpdateMovie.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Movie released day:";
            // 
            // dtpMovieReleasedUpdate
            // 
            this.dtpMovieReleasedUpdate.Location = new System.Drawing.Point(36, 332);
            this.dtpMovieReleasedUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpMovieReleasedUpdate.Name = "dtpMovieReleasedUpdate";
            this.dtpMovieReleasedUpdate.Size = new System.Drawing.Size(265, 22);
            this.dtpMovieReleasedUpdate.TabIndex = 8;
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(37, 399);
            this.btnUpdateMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(132, 28);
            this.btnUpdateMovie.TabIndex = 7;
            this.btnUpdateMovie.Text = "Update the movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // cbCategoryUpdate
            // 
            this.cbCategoryUpdate.FormattingEnabled = true;
            this.cbCategoryUpdate.Items.AddRange(new object[] {
            "Comedy",
            "Action",
            "Horror"});
            this.cbCategoryUpdate.Location = new System.Drawing.Point(36, 260);
            this.cbCategoryUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategoryUpdate.Name = "cbCategoryUpdate";
            this.cbCategoryUpdate.Size = new System.Drawing.Size(160, 24);
            this.cbCategoryUpdate.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Movie category:";
            // 
            // txtMovieTitleUpdate
            // 
            this.txtMovieTitleUpdate.Location = new System.Drawing.Point(36, 183);
            this.txtMovieTitleUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieTitleUpdate.Name = "txtMovieTitleUpdate";
            this.txtMovieTitleUpdate.Size = new System.Drawing.Size(132, 22);
            this.txtMovieTitleUpdate.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Movie Title:";
            // 
            // txtMovieIdUpdate
            // 
            this.txtMovieIdUpdate.Location = new System.Drawing.Point(36, 110);
            this.txtMovieIdUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieIdUpdate.Name = "txtMovieIdUpdate";
            this.txtMovieIdUpdate.ReadOnly = true;
            this.txtMovieIdUpdate.Size = new System.Drawing.Size(132, 22);
            this.txtMovieIdUpdate.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Movie id:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(23, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 48);
            this.label10.TabIndex = 0;
            this.label10.Text = "Update Movie";
            // 
            // pnlDeleteMovie
            // 
            this.pnlDeleteMovie.Controls.Add(this.label11);
            this.pnlDeleteMovie.Controls.Add(this.dtpMovieReleasedDelete);
            this.pnlDeleteMovie.Controls.Add(this.btnDeleteMovie);
            this.pnlDeleteMovie.Controls.Add(this.cbCategoryDelete);
            this.pnlDeleteMovie.Controls.Add(this.label12);
            this.pnlDeleteMovie.Controls.Add(this.txtMovieTitleDelete);
            this.pnlDeleteMovie.Controls.Add(this.label13);
            this.pnlDeleteMovie.Controls.Add(this.txtMovieIdDelete);
            this.pnlDeleteMovie.Controls.Add(this.label14);
            this.pnlDeleteMovie.Controls.Add(this.label15);
            this.pnlDeleteMovie.Location = new System.Drawing.Point(16, 71);
            this.pnlDeleteMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDeleteMovie.Name = "pnlDeleteMovie";
            this.pnlDeleteMovie.Size = new System.Drawing.Size(416, 448);
            this.pnlDeleteMovie.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 302);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Movie released day:";
            // 
            // dtpMovieReleasedDelete
            // 
            this.dtpMovieReleasedDelete.Enabled = false;
            this.dtpMovieReleasedDelete.Location = new System.Drawing.Point(36, 332);
            this.dtpMovieReleasedDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpMovieReleasedDelete.Name = "dtpMovieReleasedDelete";
            this.dtpMovieReleasedDelete.Size = new System.Drawing.Size(265, 22);
            this.dtpMovieReleasedDelete.TabIndex = 8;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(37, 399);
            this.btnDeleteMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(132, 28);
            this.btnDeleteMovie.TabIndex = 7;
            this.btnDeleteMovie.Text = "Delete the movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // cbCategoryDelete
            // 
            this.cbCategoryDelete.Enabled = false;
            this.cbCategoryDelete.FormattingEnabled = true;
            this.cbCategoryDelete.Items.AddRange(new object[] {
            "Comedy",
            "Action",
            "Horror"});
            this.cbCategoryDelete.Location = new System.Drawing.Point(36, 260);
            this.cbCategoryDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategoryDelete.Name = "cbCategoryDelete";
            this.cbCategoryDelete.Size = new System.Drawing.Size(160, 24);
            this.cbCategoryDelete.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 229);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Movie category:";
            // 
            // txtMovieTitleDelete
            // 
            this.txtMovieTitleDelete.Location = new System.Drawing.Point(36, 183);
            this.txtMovieTitleDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieTitleDelete.Name = "txtMovieTitleDelete";
            this.txtMovieTitleDelete.ReadOnly = true;
            this.txtMovieTitleDelete.Size = new System.Drawing.Size(132, 22);
            this.txtMovieTitleDelete.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 151);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Movie Title:";
            // 
            // txtMovieIdDelete
            // 
            this.txtMovieIdDelete.Location = new System.Drawing.Point(36, 110);
            this.txtMovieIdDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieIdDelete.Name = "txtMovieIdDelete";
            this.txtMovieIdDelete.ReadOnly = true;
            this.txtMovieIdDelete.Size = new System.Drawing.Size(132, 22);
            this.txtMovieIdDelete.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 81);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Movie id:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(23, 12);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 48);
            this.label15.TabIndex = 0;
            this.label15.Text = "Delete Movie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlDeleteMovie);
            this.Controls.Add(this.pnlUpdateMovie);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.pnlInsertMovie);
            this.Controls.Add(this.btnDeleteMovieView);
            this.Controls.Add(this.btnUpdateMovieView);
            this.Controls.Add(this.btnInsertMovieView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Text File Update by Aviv laron and Tal griman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlInsertMovie.ResumeLayout(false);
            this.pnlInsertMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.pnlUpdateMovie.ResumeLayout(false);
            this.pnlUpdateMovie.PerformLayout();
            this.pnlDeleteMovie.ResumeLayout(false);
            this.pnlDeleteMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertMovieView;
        private System.Windows.Forms.Button btnUpdateMovieView;
        private System.Windows.Forms.Button btnDeleteMovieView;
        private System.Windows.Forms.Panel pnlInsertMovie;
        private System.Windows.Forms.ComboBox cbCategoryInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMovieTitleInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMovieIdInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpMovieReleasedInsert;
        private System.Windows.Forms.Button btnInsertMovie;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Panel pnlUpdateMovie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpMovieReleasedUpdate;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.ComboBox cbCategoryUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMovieTitleUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMovieIdUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlDeleteMovie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpMovieReleasedDelete;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.ComboBox cbCategoryDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMovieTitleDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMovieIdDelete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

