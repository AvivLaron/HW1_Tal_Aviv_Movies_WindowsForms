using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieFile
{
    public partial class Form1 : Form
    {
        private string path = @"..\..\movies.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertMovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMovieIdInsert.Text.Equals("") || txtMovieTitleInsert.Text.Equals("") || cbCategoryInsert.Text.Equals(""))
                {
                    MessageBox.Show("All the fields must to be filled.");
                    return;
                }
                if (File.Exists(path) && CheckIfMovieInTheFile(txtMovieIdInsert.Text))
                {
                    MessageBox.Show("Error.. other movie is using this id!");
                    return;
                }
                string movie = $"Id: {txtMovieIdInsert.Text}, Ttitle: {txtMovieTitleInsert.Text}, Category: {cbCategoryInsert.Text}, Released date: {dtpMovieReleasedInsert.Value.ToShortDateString()}";
                File.AppendAllText(path, movie + "\n");
                txtMovieIdInsert.Clear();
                txtMovieTitleInsert.Clear();
                RenderGrid();
                MessageBox.Show("The movie as been added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckIfMovieInTheFile(string id)
        {
            string[] output = File.ReadAllLines(path);
            string[] obj = null;
            foreach (var line in output)
            {
                obj = line.Split(',');
                obj = obj[0].Split(':');
                if (obj[1].Trim().Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlInsertMovie.BringToFront();
            RenderGrid();
        }

        private void RenderGrid()
        {


            DataTable dt = new DataTable();
            DataColumn column;
            string[] topColumns = { "ID", "Title", "Category", "Release date" };
            for (int i = 0; i < topColumns.Length; i++) // add column header to data table in order to show in viewdatagrid
            {
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = topColumns[i];
                dt.Columns.Add(column);
            }
            if (File.Exists(path))
            {


                string[] output = File.ReadAllLines(path);
                string id, title, category, rDate;
                string[] obj = null;
                DataRow row;
                foreach (var line in output) // add row details to data table in order to show in viewdatagrid
                {
                    obj = line.Split(',');
                    id = obj[0].Split(':')[1].Trim();
                    title = obj[1].Split(':')[1].Trim();
                    category = obj[2].Split(':')[1].Trim();
                    rDate = obj[3].Split(':')[1].Trim();
                    row = dt.NewRow();
                    row["ID"] = id;
                    row["Title"] = title;
                    row["Category"] = category;
                    row["Release date"] = rDate;
                    dt.Rows.Add(row);

                }
            }
            dgvMovies.DataSource = dt;
            dgvMovies.Sort(dgvMovies.Columns["ID"], ListSortDirection.Ascending);
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMovieIdUpdate.Text.Equals("") || txtMovieTitleUpdate.Text.Equals("") || cbCategoryUpdate.Text.Equals(""))
                {
                    MessageBox.Show("All the fields must to be filled.");
                    return;
                }
                if (!File.Exists(path) || !CheckIfMovieInTheFile(txtMovieIdUpdate.Text))
                {
                    MessageBox.Show("Movie does not exist!");
                    return;
                }
                DeleteMovie(txtMovieIdUpdate.Text);
                string movie = $"Id: {txtMovieIdUpdate.Text}, Ttitle: {txtMovieTitleUpdate.Text}, Category: {cbCategoryUpdate.Text}, Released date: {dtpMovieReleasedUpdate.Value.ToShortDateString()}";
                File.AppendAllText(path, movie + "\n");
                txtMovieIdInsert.Clear();
                txtMovieTitleInsert.Clear();
                RenderGrid();
                MessageBox.Show("The movie as been updated!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteMovie(string id)
        {
            string[] output = File.ReadAllLines(path);
            string[] obj = null;
            StringBuilder str = new StringBuilder();
            foreach (var line in output)
            {
                obj = line.Split(',');
                obj = obj[0].Split(':');
                if (obj[1].Trim().Equals(id))
                {
                    continue;
                }
                str.Append(line + "\n");
            }
            File.WriteAllText(path, str.ToString());
        }

        private void btnInsertMovieView_Click(object sender, EventArgs e)
        {
            pnlInsertMovie.BringToFront();
        }

        private void btnUpdateMovieView_Click(object sender, EventArgs e)
        {
            pnlUpdateMovie.BringToFront();
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMovies.SelectedRows)
            {
                txtMovieIdUpdate.Text = row.Cells[0].Value.ToString();
                txtMovieTitleUpdate.Text = row.Cells[1].Value.ToString();
                txtMovieIdDelete.Text = row.Cells[0].Value.ToString();
                txtMovieTitleDelete.Text = row.Cells[1].Value.ToString();
                string category = row.Cells[2].Value.ToString();
                if (cbCategoryUpdate.Items[0].ToString().Equals(category))
                {
                    cbCategoryUpdate.SelectedItem = cbCategoryUpdate.Items[0];
                }
                if (cbCategoryUpdate.Items[1].ToString().Equals(category))
                {
                    cbCategoryUpdate.SelectedItem = cbCategoryUpdate.Items[1];
                }
                if (cbCategoryUpdate.Items[2].ToString().Equals(category))
                {
                    cbCategoryUpdate.SelectedItem = cbCategoryUpdate.Items[2];
                }

                if (cbCategoryDelete.Items[0].ToString().Equals(category))
                {
                    cbCategoryDelete.SelectedItem = cbCategoryUpdate.Items[0];
                }
                if (cbCategoryDelete.Items[1].ToString().Equals(category))
                {
                    cbCategoryDelete.SelectedItem = cbCategoryUpdate.Items[1];
                }
                if (cbCategoryDelete.Items[2].ToString().Equals(category))
                {
                    cbCategoryDelete.SelectedItem = cbCategoryUpdate.Items[2];
                }

                string date = row.Cells[3].Value.ToString();
                string[] dateArray = date.Split('/');
                dtpMovieReleasedUpdate.Value = new DateTime(int.Parse(dateArray[2]), int.Parse(dateArray[1]), int.Parse(dateArray[0]));
                dtpMovieReleasedDelete.Value = new DateTime(int.Parse(dateArray[2]), int.Parse(dateArray[1]), int.Parse(dateArray[0]));

            }
        }

        private void btnDeleteMovieView_Click(object sender, EventArgs e)
        {
            pnlDeleteMovie.BringToFront();
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMovieIdDelete.Text.Equals("") || txtMovieTitleDelete.Text.Equals("") || cbCategoryDelete.Text.Equals(""))
                {
                    MessageBox.Show("All the fields must to be filled.");
                    return;
                }
                if (File.Exists(path) && CheckIfMovieInTheFile(txtMovieIdUpdate.Text))
                {
                    //Message box with yes / no 
                    var result = MessageBox.Show($"Are you sure that you want to delete Movie ID: {txtMovieIdDelete.Text}", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DeleteMovie(txtMovieIdDelete.Text);
                        RenderGrid();
                        MessageBox.Show("The movie deleted!");
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                MessageBox.Show("No such a movie!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
