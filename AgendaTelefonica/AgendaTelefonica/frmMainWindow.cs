using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.IO;

namespace AgendaTelefonica
{
    public partial class frmMainWindow : Form
    {
        string connectionString = @"Server=DESKTOP-JUTKUL7\SQLEXPRESS01;Database=Abonați;Trusted_Connection=True;";
        SqlConnection conn = new SqlConnection (@"Server=DESKTOP-JUTKUL7\SQLEXPRESS01;Database=Abonați;Trusted_Connection=True;");

        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void serializareInformatiiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Abonați",conn);
                    DataTable dt = new DataTable();
                    data.Fill(dt);

                    dgvMain.DataSource = dt;

                    if (dgvMain.RowCount == 0)
                    {
                        MessageBox.Show("Nici un abonat găsit în bază.");
                    }
                }
                MessageBox.Show("Date incarcate cu succes!", "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        public void PopulateDataGridView()
        {
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Abonați", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMain.DataSource = dt;
            }
        }

        public void Culoare()
        {
            ColorDialog clrMain = new ColorDialog();
            if (clrMain.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FormBackground = clrMain.Color;
                Properties.Settings.Default.Save();
                this.BackColor = clrMain.Color;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMain.CurrentRow != null)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        DataGridViewRow dgvRow = dgvMain.CurrentRow;
                        SqlCommand sqlCmd = new SqlCommand("AbonatiAddOrEdit", conn);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        if (dgvRow.Cells["txtID"].Value == DBNull.Value)
                            sqlCmd.Parameters.AddWithValue("@ID", 0);
                        else
                            sqlCmd.Parameters.AddWithValue("@ID", Convert.ToInt32(dgvRow.Cells["txtID"].Value));
                        sqlCmd.Parameters.AddWithValue("@Nume", dgvRow.Cells["txtNume"].Value == DBNull.Value ? "" : dgvRow.Cells["txtNume"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Prenume", dgvRow.Cells["txtPrenume"].Value == DBNull.Value ? "" : dgvRow.Cells["txtPrenume"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Contact", dgvRow.Cells["txtContact"].Value == DBNull.Value ? "" : dgvRow.Cells["txtContact"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Adresă", dgvRow.Cells["txtAdresă"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAdresă"].Value.ToString());
                        sqlCmd.ExecuteNonQuery();
                        PopulateDataGridView();
                    }
                }
                MessageBox.Show("Date salvate cu succes!" , "Saved" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitPress()
        {
            DialogResult exit;
            exit = MessageBox.Show("Sunteti sigur ca doriti sa iesiti ? (Yes / No)", "Save dgvMain", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exitPress();
        }

        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void dgvMain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= AllowNumbersOnly;
            if (dgvMain.CurrentCell.ColumnIndex == 0)
            {
                e.Control.KeyPress += AllowNumbersOnly;
            }
            if (dgvMain.CurrentCell.ColumnIndex == 3)
            {
                e.Control.KeyPress += AllowNumbersOnly;
            }
        }

        private void dgvMain_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvMain.CurrentRow.Cells["txtID"].Value != DBNull.Value)
            {
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand sqlCmd = new SqlCommand("AbonatiDeleteByID", conn);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ID", Convert.ToInt32(dgvMain.CurrentRow.Cells["txtID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
            }
            else
                e.Cancel = true;
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)                 // Serializare info - neterminat
        {
            try
            {
                DataTable dt = GetDataTableFromDGV(dgvMain);
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                ds.WriteXml(File.OpenWrite(@"C:\Abonati_"+ DateTime.Now.ToFileTime() +".xml"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }
            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;

        }
       

        private void preferințeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fontButoaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                btnSave.Font = fontDialog.Font;
                btnLoad.Font = fontDialog.Font;
            }
        }

        private void fontDataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                dgvMain.Font = fontDialog.Font;
            }
        }

        private void culoareFereastraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Culoare();
        }

        private void preferinteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearchWindow search = new frmSearchWindow();
            search.ShowDialog();
            search.Close();
            this.Show();
        }
    }
     
}
    

