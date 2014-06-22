namespace Forma
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobjektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza1DataSet = new WindowsFormsApplication1.Baza1DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorija1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namjestajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arhitekturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primitivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ostaloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadNaBazuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.teksturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._3D_objektTableAdapter = new WindowsFormsApplication1.Baza1DataSetTableAdapters._3D_objektTableAdapter();
            this.korisnikTableAdapter1 = new WindowsFormsApplication1.Baza1DataSetTableAdapters.korisnikTableAdapter();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobjektBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza1DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teksturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtAutor);
            this.splitContainer1.Size = new System.Drawing.Size(761, 415);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(62, 332);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 56);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.HideSelection = false;
            this.treeView1.ItemHeight = 55;
            this.treeView1.Location = new System.Drawing.Point(16, 210);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(353, 119);
            this.treeView1.TabIndex = 8;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kategorijaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.korisnikidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dobjektBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(353, 134);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // kategorijaDataGridViewTextBoxColumn
            // 
            this.kategorijaDataGridViewTextBoxColumn.DataPropertyName = "kategorija";
            this.kategorijaDataGridViewTextBoxColumn.HeaderText = "kategorija";
            this.kategorijaDataGridViewTextBoxColumn.Name = "kategorijaDataGridViewTextBoxColumn";
            this.kategorijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategorijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikidDataGridViewTextBoxColumn
            // 
            this.korisnikidDataGridViewTextBoxColumn.DataPropertyName = "korisnikid";
            this.korisnikidDataGridViewTextBoxColumn.HeaderText = "korisnikid";
            this.korisnikidDataGridViewTextBoxColumn.Name = "korisnikidDataGridViewTextBoxColumn";
            this.korisnikidDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikidDataGridViewTextBoxColumn.Visible = false;
            // 
            // dobjektBindingSource
            // 
            this.dobjektBindingSource.DataMember = "3D_objekt";
            this.dobjektBindingSource.DataSource = this.baza1DataSet;
            // 
            // baza1DataSet
            // 
            this.baza1DataSet.DataSetName = "Baza1DataSet";
            this.baza1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shaderi";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Texture";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modeli";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorijeToolStripMenuItem,
            this.uploadNaBazuToolStripMenuItem,
            this.logInToolStripMenuItem,
            this.opcijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorija1ToolStripMenuItem,
            this.namjestajToolStripMenuItem,
            this.vozilaToolStripMenuItem,
            this.arhitekturaToolStripMenuItem,
            this.primitivesToolStripMenuItem,
            this.ostaloToolStripMenuItem});
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            // 
            // kategorija1ToolStripMenuItem
            // 
            this.kategorija1ToolStripMenuItem.Name = "kategorija1ToolStripMenuItem";
            this.kategorija1ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.kategorija1ToolStripMenuItem.Text = "Tehnologija";
            this.kategorija1ToolStripMenuItem.Click += new System.EventHandler(this.kategorija1ToolStripMenuItem_Click);
            // 
            // namjestajToolStripMenuItem
            // 
            this.namjestajToolStripMenuItem.Name = "namjestajToolStripMenuItem";
            this.namjestajToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.namjestajToolStripMenuItem.Text = "Namjestaj";
            this.namjestajToolStripMenuItem.Click += new System.EventHandler(this.namjestajToolStripMenuItem_Click);
            // 
            // vozilaToolStripMenuItem
            // 
            this.vozilaToolStripMenuItem.Name = "vozilaToolStripMenuItem";
            this.vozilaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.vozilaToolStripMenuItem.Text = "Vozila";
            this.vozilaToolStripMenuItem.Click += new System.EventHandler(this.vozilaToolStripMenuItem_Click);
            // 
            // arhitekturaToolStripMenuItem
            // 
            this.arhitekturaToolStripMenuItem.Name = "arhitekturaToolStripMenuItem";
            this.arhitekturaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.arhitekturaToolStripMenuItem.Text = "Arhitektura";
            this.arhitekturaToolStripMenuItem.Click += new System.EventHandler(this.arhitekturaToolStripMenuItem_Click);
            // 
            // primitivesToolStripMenuItem
            // 
            this.primitivesToolStripMenuItem.Name = "primitivesToolStripMenuItem";
            this.primitivesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.primitivesToolStripMenuItem.Text = "Primitives";
            this.primitivesToolStripMenuItem.Click += new System.EventHandler(this.primitivesToolStripMenuItem_Click);
            // 
            // ostaloToolStripMenuItem
            // 
            this.ostaloToolStripMenuItem.Name = "ostaloToolStripMenuItem";
            this.ostaloToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ostaloToolStripMenuItem.Text = "Ostalo";
            this.ostaloToolStripMenuItem.Click += new System.EventHandler(this.ostaloToolStripMenuItem_Click);
            // 
            // uploadNaBazuToolStripMenuItem
            // 
            this.uploadNaBazuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadToolStripMenuItem});
            this.uploadNaBazuToolStripMenuItem.Name = "uploadNaBazuToolStripMenuItem";
            this.uploadNaBazuToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.uploadNaBazuToolStripMenuItem.Text = "Upload na bazu";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem1,
            this.kreirajteAccountToolStripMenuItem});
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem1
            // 
            this.logInToolStripMenuItem1.Name = "logInToolStripMenuItem1";
            this.logInToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.logInToolStripMenuItem1.Text = "Log in";
            this.logInToolStripMenuItem1.Click += new System.EventHandler(this.logInToolStripMenuItem1_Click);
            // 
            // kreirajteAccountToolStripMenuItem
            // 
            this.kreirajteAccountToolStripMenuItem.Name = "kreirajteAccountToolStripMenuItem";
            this.kreirajteAccountToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.kreirajteAccountToolStripMenuItem.Text = "Kreirajte account";
            this.kreirajteAccountToolStripMenuItem.Click += new System.EventHandler(this.kreirajteAccountToolStripMenuItem_Click);
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullscreenToolStripMenuItem,
            this.downloadToolStripMenuItem});
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.opcijeToolStripMenuItem.Text = "Opcije";
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            this.fullscreenToolStripMenuItem.Click += new System.EventHandler(this.fullscreenToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutor.Location = new System.Drawing.Point(3, 370);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(359, 20);
            this.txtAutor.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(761, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // _3D_objektTableAdapter
            // 
            this._3D_objektTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikTableAdapter1
            // 
            this.korisnikTableAdapter1.ClearBeforeFill = true;
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 415);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Baza 3D modela [By: Team37]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.LocationChanged += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.SizeChanged += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            this.Resize += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobjektBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza1DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teksturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadNaBazuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorija1ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WindowsFormsApplication1.Baza1DataSet baza1DataSet;
        private System.Windows.Forms.BindingSource dobjektBindingSource;
        private WindowsFormsApplication1.Baza1DataSetTableAdapters._3D_objektTableAdapter _3D_objektTableAdapter;
       
        private System.Windows.Forms.BindingSource teksturaBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobjektDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teksturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem namjestajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arhitekturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primitivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ostaloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAutor;
        private WindowsFormsApplication1.Baza1DataSetTableAdapters.korisnikTableAdapter korisnikTableAdapter1;
        public System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kreirajteAccountToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
    }
}