
namespace AgendaTelefonica
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferințeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontButoaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDataGridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culoareFereastraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareInformatiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAdresă = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clrMain = new System.Windows.Forms.ColorDialog();
            this.mnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // mnMain
            // 
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serializareInformatiiToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(857, 24);
            this.mnMain.TabIndex = 1;
            this.mnMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferințeToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferințeToolStripMenuItem
            // 
            this.preferințeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontButoaneToolStripMenuItem,
            this.fontDataGridViewToolStripMenuItem,
            this.culoareFereastraToolStripMenuItem});
            this.preferințeToolStripMenuItem.Name = "preferințeToolStripMenuItem";
            this.preferințeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preferințeToolStripMenuItem.Text = "Preferințe";
            this.preferințeToolStripMenuItem.Click += new System.EventHandler(this.preferințeToolStripMenuItem_Click);
            // 
            // fontButoaneToolStripMenuItem
            // 
            this.fontButoaneToolStripMenuItem.Name = "fontButoaneToolStripMenuItem";
            this.fontButoaneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontButoaneToolStripMenuItem.Text = "Font Butoane";
            this.fontButoaneToolStripMenuItem.Click += new System.EventHandler(this.fontButoaneToolStripMenuItem_Click);
            // 
            // fontDataGridViewToolStripMenuItem
            // 
            this.fontDataGridViewToolStripMenuItem.Name = "fontDataGridViewToolStripMenuItem";
            this.fontDataGridViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontDataGridViewToolStripMenuItem.Text = "Font DataGridView";
            this.fontDataGridViewToolStripMenuItem.Click += new System.EventHandler(this.fontDataGridViewToolStripMenuItem_Click);
            // 
            // culoareFereastraToolStripMenuItem
            // 
            this.culoareFereastraToolStripMenuItem.Name = "culoareFereastraToolStripMenuItem";
            this.culoareFereastraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.culoareFereastraToolStripMenuItem.Text = "Culoare Fereastra";
            this.culoareFereastraToolStripMenuItem.Click += new System.EventHandler(this.culoareFereastraToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // serializareInformatiiToolStripMenuItem
            // 
            this.serializareInformatiiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferinteToolStripMenuItem});
            this.serializareInformatiiToolStripMenuItem.Name = "serializareInformatiiToolStripMenuItem";
            this.serializareInformatiiToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.serializareInformatiiToolStripMenuItem.Text = "Edit";
            this.serializareInformatiiToolStripMenuItem.Click += new System.EventHandler(this.serializareInformatiiToolStripMenuItem_Click);
            // 
            // preferinteToolStripMenuItem
            // 
            this.preferinteToolStripMenuItem.Name = "preferinteToolStripMenuItem";
            this.preferinteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.preferinteToolStripMenuItem.Text = "Caută persoană";
            this.preferinteToolStripMenuItem.Click += new System.EventHandler(this.preferinteToolStripMenuItem_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(691, 211);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(98, 55);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtNume,
            this.txtPrenume,
            this.txtContact,
            this.txtAdresă});
            this.dgvMain.Location = new System.Drawing.Point(12, 27);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 25;
            this.dgvMain.Size = new System.Drawing.Size(618, 308);
            this.dgvMain.TabIndex = 4;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            this.dgvMain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMain_EditingControlShowing);
            this.dgvMain.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvMain_UserDeletingRow);
            // 
            // txtID
            // 
            this.txtID.DataPropertyName = "ID";
            this.txtID.HeaderText = "ID";
            this.txtID.MaxInputLength = 1;
            this.txtID.Name = "txtID";
            this.txtID.Visible = false;
            this.txtID.Width = 30;
            // 
            // txtNume
            // 
            this.txtNume.DataPropertyName = "Nume";
            this.txtNume.HeaderText = "Nume";
            this.txtNume.Name = "txtNume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.DataPropertyName = "Prenume";
            this.txtPrenume.HeaderText = "Prenume";
            this.txtPrenume.Name = "txtPrenume";
            // 
            // txtContact
            // 
            this.txtContact.DataPropertyName = "Contact";
            this.txtContact.HeaderText = "Contact";
            this.txtContact.MaxInputLength = 10;
            this.txtContact.Name = "txtContact";
            this.txtContact.Width = 136;
            // 
            // txtAdresă
            // 
            this.txtAdresă.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtAdresă.DataPropertyName = "Adresă";
            this.txtAdresă.HeaderText = "Adresă";
            this.txtAdresă.Name = "txtAdresă";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(691, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 55);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            // 
            // Prenume
            // 
            this.Prenume.HeaderText = "Prenume";
            this.Prenume.Name = "Prenume";
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 367);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.mnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnMain;
            this.Name = "frmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda telefonică";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareInformatiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferinteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferințeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAdresă;
        private System.Windows.Forms.ToolStripMenuItem fontButoaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontDataGridViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culoareFereastraToolStripMenuItem;
        private System.Windows.Forms.ColorDialog clrMain;
    }
}

