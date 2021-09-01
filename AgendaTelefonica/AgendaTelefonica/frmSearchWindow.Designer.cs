
namespace AgendaTelefonica
{
    partial class frmSearchWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchWindow));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAdresă = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clrMain = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 46);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Căutare";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(109, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(447, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtNume,
            this.txtPrenume,
            this.txtContact,
            this.txtAdresă});
            this.dgvSearch.Location = new System.Drawing.Point(12, 64);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowTemplate.Height = 25;
            this.dgvSearch.Size = new System.Drawing.Size(544, 308);
            this.dgvSearch.TabIndex = 5;
            this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick);
            // 
            // txtID
            // 
            this.txtID.DataPropertyName = "ID";
            this.txtID.HeaderText = "ID";
            this.txtID.MaxInputLength = 1;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Visible = false;
            this.txtID.Width = 30;
            // 
            // txtNume
            // 
            this.txtNume.DataPropertyName = "Nume";
            this.txtNume.HeaderText = "Nume";
            this.txtNume.Name = "txtNume";
            this.txtNume.ReadOnly = true;
            // 
            // txtPrenume
            // 
            this.txtPrenume.DataPropertyName = "Prenume";
            this.txtPrenume.HeaderText = "Prenume";
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.ReadOnly = true;
            // 
            // txtContact
            // 
            this.txtContact.DataPropertyName = "Contact";
            this.txtContact.HeaderText = "Contact";
            this.txtContact.MaxInputLength = 10;
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Width = 136;
            // 
            // txtAdresă
            // 
            this.txtAdresă.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtAdresă.DataPropertyName = "Adresă";
            this.txtAdresă.HeaderText = "Adresă";
            this.txtAdresă.Name = "txtAdresă";
            this.txtAdresă.ReadOnly = true;
            // 
            // frmSearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 387);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cautare Persoana";
            this.Load += new System.EventHandler(this.frmSearchWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAdresă;
        private System.Windows.Forms.ColorDialog clrMain;
    }
}