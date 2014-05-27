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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorija1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadNaBazuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baza1DataSet = new WindowsFormsApplication1.Baza1DataSet();
            this.dobjektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._3D_objektTableAdapter = new WindowsFormsApplication1.Baza1DataSetTableAdapters._3D_objektTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.baza1DataSet1 = new WindowsFormsApplication1.Baza1DataSet1();
            this.teksturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teksturaTableAdapter = new WindowsFormsApplication1.Baza1DataSet1TableAdapters.teksturaTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobjektDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teksturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baza1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobjektBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza1DataSet1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(794, 438);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(304, 104);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shaderi";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Texture";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modeli";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorijeToolStripMenuItem,
            this.uploadNaBazuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorija1ToolStripMenuItem});
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            // 
            // kategorija1ToolStripMenuItem
            // 
            this.kategorija1ToolStripMenuItem.Name = "kategorija1ToolStripMenuItem";
            this.kategorija1ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.kategorija1ToolStripMenuItem.Text = "Kategorija 1";
            this.kategorija1ToolStripMenuItem.Click += new System.EventHandler(this.kategorija1ToolStripMenuItem_Click);
            // 
            // uploadNaBazuToolStripMenuItem
            // 
            this.uploadNaBazuToolStripMenuItem.Name = "uploadNaBazuToolStripMenuItem";
            this.uploadNaBazuToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.uploadNaBazuToolStripMenuItem.Text = "Upload na bazu";
            // 
            // baza1DataSet
            // 
            this.baza1DataSet.DataSetName = "Baza1DataSet";
            this.baza1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dobjektBindingSource
            // 
            this.dobjektBindingSource.DataMember = "3D_objekt";
            this.dobjektBindingSource.DataSource = this.baza1DataSet;
            // 
            // _3D_objektTableAdapter
            // 
            this._3D_objektTableAdapter.ClearBeforeFill = true;
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
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dobjektDataGridViewTextBoxColumn,
            this.teksturaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.teksturaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(33, 195);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(282, 120);
            this.dataGridView2.TabIndex = 8;
            // 
            // baza1DataSet1
            // 
            this.baza1DataSet1.DataSetName = "Baza1DataSet1";
            this.baza1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teksturaBindingSource
            // 
            this.teksturaBindingSource.DataMember = "tekstura";
            this.teksturaBindingSource.DataSource = this.baza1DataSet1;
            // 
            // teksturaTableAdapter
            // 
            this.teksturaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dobjektDataGridViewTextBoxColumn
            // 
            this.dobjektDataGridViewTextBoxColumn.DataPropertyName = "_3D_objekt";
            this.dobjektDataGridViewTextBoxColumn.HeaderText = "_3D_objekt";
            this.dobjektDataGridViewTextBoxColumn.Name = "dobjektDataGridViewTextBoxColumn";
            this.dobjektDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobjektDataGridViewTextBoxColumn.Visible = false;
            // 
            // teksturaDataGridViewTextBoxColumn
            // 
            this.teksturaDataGridViewTextBoxColumn.DataPropertyName = "tekstura";
            this.teksturaDataGridViewTextBoxColumn.HeaderText = "tekstura";
            this.teksturaDataGridViewTextBoxColumn.Name = "teksturaDataGridViewTextBoxColumn";
            this.teksturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.teksturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 438);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LocationChanged += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.SizeChanged += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            this.Resize += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baza1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobjektBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teksturaBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikidDataGridViewTextBoxColumn;
        private WindowsFormsApplication1.Baza1DataSet1 baza1DataSet1;
        private System.Windows.Forms.BindingSource teksturaBindingSource;
        private WindowsFormsApplication1.Baza1DataSet1TableAdapters.teksturaTableAdapter teksturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobjektDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teksturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
    }
}