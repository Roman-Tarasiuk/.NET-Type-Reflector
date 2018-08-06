namespace ReflectorTRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAssemblyPath = new System.Windows.Forms.TextBox();
            this.btnSelectAssembly = new System.Windows.Forms.Button();
            this.lstbxTypes = new System.Windows.Forms.ListBox();
            this.richtxtInfo = new System.Windows.Forms.RichTextBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkFlattenHierarchy = new System.Windows.Forms.CheckBox();
            this.chkDeclaredOnly = new System.Windows.Forms.CheckBox();
            this.comboVisibility = new System.Windows.Forms.ComboBox();
            this.comboInstanceStatic = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.chkWrapLines = new System.Windows.Forms.CheckBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            //
            // txtTypeName
            //
            this.txtTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTypeName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTypeName.Location = new System.Drawing.Point(7, 18);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(240, 20);
            this.txtTypeName.TabIndex = 1;
            this.txtTypeName.Text = "System.Object";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fully quialified name:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Assembly:";
            //
            // txtAssemblyPath
            //
            this.txtAssemblyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssemblyPath.Location = new System.Drawing.Point(66, 2);
            this.txtAssemblyPath.Name = "txtAssemblyPath";
            this.txtAssemblyPath.Size = new System.Drawing.Size(174, 20);
            this.txtAssemblyPath.TabIndex = 4;
            this.txtAssemblyPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAssemblyPath_KeyDown);
            //
            // btnSelectAssembly
            //
            this.btnSelectAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAssembly.Location = new System.Drawing.Point(246, 0);
            this.btnSelectAssembly.Name = "btnSelectAssembly";
            this.btnSelectAssembly.Size = new System.Drawing.Size(27, 24);
            this.btnSelectAssembly.TabIndex = 5;
            this.btnSelectAssembly.Text = "...";
            this.btnSelectAssembly.UseVisualStyleBackColor = true;
            this.btnSelectAssembly.Click += new System.EventHandler(this.btnSelectAssembly_Click);
            //
            // lstbxTypes
            //
            this.lstbxTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbxTypes.FormattingEnabled = true;
            this.lstbxTypes.IntegralHeight = false;
            this.lstbxTypes.Location = new System.Drawing.Point(9, 28);
            this.lstbxTypes.Name = "lstbxTypes";
            this.lstbxTypes.Size = new System.Drawing.Size(264, 282);
            this.lstbxTypes.TabIndex = 6;
            this.lstbxTypes.SelectedIndexChanged += new System.EventHandler(this.lstTypes_SelectedIndexChanged);
            this.lstbxTypes.DoubleClick += new System.EventHandler(this.lstbxTypes_DoubleClick);
            //
            // richtxtInfo
            //
            this.richtxtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtxtInfo.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richtxtInfo.Location = new System.Drawing.Point(3, 19);
            this.richtxtInfo.Name = "richtxtInfo";
            this.richtxtInfo.Size = new System.Drawing.Size(724, 515);
            this.richtxtInfo.TabIndex = 13;
            this.richtxtInfo.Text = "";
            this.richtxtInfo.WordWrap = false;
            //
            // btnShowInfo
            //
            this.btnShowInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowInfo.Location = new System.Drawing.Point(248, 17);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(42, 22);
            this.btnShowInfo.TabIndex = 2;
            this.btnShowInfo.Text = "Info";
            this.btnShowInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            //
            // groupBox1
            //
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkFlattenHierarchy);
            this.groupBox1.Controls.Add(this.chkDeclaredOnly);
            this.groupBox1.Controls.Add(this.comboVisibility);
            this.groupBox1.Controls.Add(this.comboInstanceStatic);
            this.groupBox1.Location = new System.Drawing.Point(7, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Members attributes:";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Inst. / Stat.";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Acc. modif.";
            //
            // chkFlattenHierarchy
            //
            this.chkFlattenHierarchy.AutoSize = true;
            this.chkFlattenHierarchy.Location = new System.Drawing.Point(120, 69);
            this.chkFlattenHierarchy.Name = "chkFlattenHierarchy";
            this.chkFlattenHierarchy.Size = new System.Drawing.Size(104, 17);
            this.chkFlattenHierarchy.TabIndex = 11;
            this.chkFlattenHierarchy.Text = "Flatten hierarchy";
            this.chkFlattenHierarchy.UseVisualStyleBackColor = true;
            //
            // chkDeclaredOnly
            //
            this.chkDeclaredOnly.AutoSize = true;
            this.chkDeclaredOnly.Location = new System.Drawing.Point(6, 69);
            this.chkDeclaredOnly.Name = "chkDeclaredOnly";
            this.chkDeclaredOnly.Size = new System.Drawing.Size(91, 17);
            this.chkDeclaredOnly.TabIndex = 10;
            this.chkDeclaredOnly.Text = "Declared only";
            this.chkDeclaredOnly.UseVisualStyleBackColor = true;
            //
            // comboVisibility
            //
            this.comboVisibility.FormattingEnabled = true;
            this.comboVisibility.Items.AddRange(new object[] {
            "Both",
            "Public",
            "NonPublic"});
            this.comboVisibility.Location = new System.Drawing.Point(68, 42);
            this.comboVisibility.Name = "comboVisibility";
            this.comboVisibility.Size = new System.Drawing.Size(139, 21);
            this.comboVisibility.TabIndex = 9;
            //
            // comboInstanceStatic
            //
            this.comboInstanceStatic.FormattingEnabled = true;
            this.comboInstanceStatic.Items.AddRange(new object[] {
            "Both",
            "Instance",
            "Static"});
            this.comboInstanceStatic.Location = new System.Drawing.Point(68, 18);
            this.comboInstanceStatic.Name = "comboInstanceStatic";
            this.comboInstanceStatic.Size = new System.Drawing.Size(139, 21);
            this.comboInstanceStatic.TabIndex = 8;
            //
            // label4
            //
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Filter:";
            //
            // btnFilter
            //
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(166, 345);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(49, 24);
            this.btnFilter.TabIndex = 16;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            //
            // txtFilter
            //
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(6, 347);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(153, 20);
            this.txtFilter.TabIndex = 15;
            //
            // btnClearFilter
            //
            this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.Location = new System.Drawing.Point(221, 345);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(49, 24);
            this.btnClearFilter.TabIndex = 17;
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            //
            // chkWrapLines
            //
            this.chkWrapLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkWrapLines.AutoSize = true;
            this.chkWrapLines.Location = new System.Drawing.Point(651, 3);
            this.chkWrapLines.Name = "chkWrapLines";
            this.chkWrapLines.Size = new System.Drawing.Size(76, 17);
            this.chkWrapLines.TabIndex = 18;
            this.chkWrapLines.Text = "Wrap lines";
            this.chkWrapLines.UseVisualStyleBackColor = true;
            this.chkWrapLines.CheckedChanged += new System.EventHandler(this.chkWrapLines_CheckedChanged);
            //
            // lblCount
            //
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(32, 313);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(36, 13);
            this.lblCount.TabIndex = 19;
            this.lblCount.Text = "... / ...";
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            //
            // fileToolStripMenuItem
            //
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            //
            // exitToolStripMenuItem
            //
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            //
            // editToolStripMenuItem
            //
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            //
            // searchToolStripMenuItem
            //
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.searchToolStripMenuItem.Text = "Search...";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            //
            // splitContainer1
            //
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            //
            // splitContainer1.Panel1
            //
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtTypeName);
            this.splitContainer1.Panel1.Controls.Add(this.btnShowInfo);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.richtxtInfo);
            this.splitContainer1.Panel2.Controls.Add(this.chkWrapLines);
            this.splitContainer1.Size = new System.Drawing.Size(1025, 537);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 21;
            //
            // tabControl1
            //
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(289, 399);
            this.tabControl1.TabIndex = 0;
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblCount);
            this.tabPage1.Controls.Add(this.txtAssemblyPath);
            this.tabPage1.Controls.Add(this.btnSelectAssembly);
            this.tabPage1.Controls.Add(this.btnClearFilter);
            this.tabPage1.Controls.Add(this.lstbxTypes);
            this.tabPage1.Controls.Add(this.btnFilter);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtFilter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(281, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Assembly";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // tabPage2
            //
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 217);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 563);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = ".NET Type Reflector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAssemblyPath;
        private System.Windows.Forms.Button btnSelectAssembly;
        private System.Windows.Forms.ListBox lstbxTypes;
        private System.Windows.Forms.RichTextBox richtxtInfo;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboInstanceStatic;
        private System.Windows.Forms.ComboBox comboVisibility;
        private System.Windows.Forms.CheckBox chkDeclaredOnly;
        private System.Windows.Forms.CheckBox chkFlattenHierarchy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.CheckBox chkWrapLines;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

