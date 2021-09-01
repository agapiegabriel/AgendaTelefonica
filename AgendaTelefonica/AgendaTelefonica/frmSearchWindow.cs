using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class frmSearchWindow : Form
    {
        string connectionString = @"Server=DESKTOP-JUTKUL7\SQLEXPRESS01;Database=Abonați;Trusted_Connection=True;";
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-JUTKUL7\SQLEXPRESS01;Database=Abonați;Trusted_Connection=True;");
        public frmSearchWindow()
        {
            InitializeComponent();
        }
        void PopulateDataGridView()
        {
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Abonați", conn);
                    DataTable dt = new DataTable();
                    data.Fill(dt);

                    dgvSearch.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Search()
        {
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    if (String.IsNullOrEmpty(txtSearch.Text))
                    {
                        conn.Open();
                        SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Abonați", conn);
                        DataTable dt = new DataTable();
                        data.Fill(dt);

                        dgvSearch.DataSource = dt;
                    }

                    else
                    {
                        conn.Open();
                        string query = "SELECT ID, Nume, Prenume, Contact, Adresă FROM Abonați";
                        query += " WHERE ID LIKE '%' + @SearchTerm + '%'";
                        query += " OR Nume LIKE '%' + @SearchTerm + '%'";
                        query += " OR Prenume LIKE '%' + @SearchTerm + '%'";
                        query += " OR Contact LIKE '%' + @SearchTerm + '%'";
                        query += " OR Adresă LIKE '%' + @SearchTerm + '%'";
                        query += " OR @SearchTerm = ''";
                        using (SqlCommand sqlcmd = new SqlCommand(query, conn))
                        {
                            SqlDataAdapter data = new SqlDataAdapter(sqlcmd);
                            sqlcmd.Parameters.AddWithValue("@SearchTerm", txtSearch.Text.Trim());
                            DataTable dt = new DataTable();
                            data.Fill(dt);
                            dgvSearch.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void frmSearchWindow_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }
    }
}
