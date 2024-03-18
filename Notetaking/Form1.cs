using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Notetaking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListView(); // Ensure this method sets up your DataGridView correctly
            LoadNotes();
        }

        private void InitializeListView()
        {
            // Assuming columns are set up in the Designer, but if not:
            listView.Columns.Add("NoteID", "NoteID");
            listView.Columns.Add("Title", "Title");
            listView.Columns.Add("Content", "Content");
            listView.Columns.Add("Timestamp", "Timestamp");


            listView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonNewNote_Click(object sender, EventArgs e)
        {
            noteTitle.Clear();
            noteNote.Clear();
            LoadNotes();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-D8B5B6O\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "INSERT INTO Notes (Title, Content, Timestamp) VALUES (@Title, @Content, @Timestamp); SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.Parameters.AddWithValue("@Title", noteTitle.Text);
                cmd.Parameters.AddWithValue("@Content", noteNote.Text);
                cmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);

                int newNoteID = Convert.ToInt32(cmd.ExecuteScalar()); // Retrieve the newly inserted NoteID

                LoadNotes();

                MessageBox.Show("Note saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a note to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedNoteID = Convert.ToInt32(listView.SelectedRows[0].Cells["NoteID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this note?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteNoteFromDatabase(selectedNoteID);
                MessageBox.Show("Note deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNotes();
            }
        }

        private void LoadNotes()
        {
            listView.Rows.Clear();
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-D8B5B6O\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT NoteID, Title, Content, Timestamp FROM Notes";
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = listView.Rows.Add();
                            DataGridViewRow row = listView.Rows[rowIndex];
                            row.Cells["NoteID"].Value = reader["NoteID"].ToString();
                            row.Cells["Title"].Value = reader["Title"].ToString();
                            row.Cells["Content"].Value = reader["Content"].ToString();
                            row.Cells["Timestamp"].Value = ((DateTime)reader["Timestamp"]).ToString();
                            /* row.Cells["NoteID"].Value = reader["NoteID"].ToString(); */// Assuming you add a hidden NoteID column
                        }
                    }
                }
            }
        }

        private void DeleteNoteFromDatabase(int noteID)
        {
            using  (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-D8B5B6O\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "DELETE FROM Notes WHERE NoteID = @NoteID";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@NoteID", noteID);
                cmd.ExecuteNonQuery();
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedRows.Count > 0)
            {
                var selectedRow = listView.SelectedRows[0];
                noteNote.Text = selectedRow.Cells["Content"].Value.ToString();
                noteTitle.Text = selectedRow.Cells["Title"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
