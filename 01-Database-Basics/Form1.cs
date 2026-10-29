using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AccessDB_CRUD
{
    public partial class Form1 : Form
    {
        // Access database connection string
        string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\BookCSharp.accdb;Persist Security Info=False;";

        public Form1()
        {
            InitializeComponent();

            // Load existing books when the application starts
            LoadBooks();

            // Button events
            btnCreate.Click += btnCreate_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;

            // DataGridView event
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        // READ - Display books from Access database
        private void LoadBooks()
        {
            try
            {
                using (OleDbConnection connection =
                    new OleDbConnection(connectionString))
                {
                    string query = "SELECT * FROM Books";

                    OleDbDataAdapter adapter =
                        new OleDbDataAdapter(query, connection);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading books:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // CREATE - Add a new book
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection =
                    new OleDbConnection(connectionString))
                {
                    string query =
                        "INSERT INTO Books (BookKey, Title, Pages, Publisher) " +
                        "VALUES (?, ?, ?, ?)";

                    using (OleDbCommand command =
                        new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@BookKey", txtBookkey.Text);

                        command.Parameters.AddWithValue(
                            "@Title", txtTitle.Text);

                        command.Parameters.AddWithValue(
                            "@Pages", txtPage.Text);

                        command.Parameters.AddWithValue(
                            "@Publisher", txtPublisher.Text);

                        connection.Open();

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book created successfully!");

                LoadBooks();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error creating book:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // UPDATE - Update an existing book
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection =
                    new OleDbConnection(connectionString))
                {
                    string query =
                        "UPDATE Books " +
                        "SET Title = ?, Pages = ?, Publisher = ? " +
                        "WHERE BookKey = ?";

                    using (OleDbCommand command =
                        new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Title", txtTitle.Text);

                        command.Parameters.AddWithValue(
                            "@Pages", txtPage.Text);

                        command.Parameters.AddWithValue(
                            "@Publisher", txtPublisher.Text);

                        command.Parameters.AddWithValue(
                            "@BookKey", txtBookkey.Text);

                        connection.Open();

                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Book updated successfully!");

                            LoadBooks();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show(
                                "BookKey not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating book:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // DELETE - Delete a book
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection =
                    new OleDbConnection(connectionString))
                {
                    string query =
                        "DELETE FROM Books WHERE BookKey = ?";

                    using (OleDbCommand command =
                        new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@BookKey", txtBookkey.Text);

                        connection.Open();

                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Book deleted successfully!");

                            LoadBooks();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show(
                                "BookKey not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error deleting book:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Select a book from the DataGridView
        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dataGridView1.Rows[e.RowIndex];

                txtBookkey.Text =
                    row.Cells["BookKey"].Value?.ToString() ?? "";

                txtTitle.Text =
                    row.Cells["Title"].Value?.ToString() ?? "";

                txtPage.Text =
                    row.Cells["Pages"].Value?.ToString() ?? "";

                txtPublisher.Text =
                    row.Cells["Publisher"].Value?.ToString() ?? "";
            }
        }

        // Clear all input fields
        private void ClearFields()
        {
            txtBookkey.Clear();
            txtTitle.Clear();
            txtPage.Clear();
            txtPublisher.Clear();

            txtBookkey.Focus();
        }
    }
}