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
            this.label3 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTypeName.Location = new System.Drawing.Point(15, 49);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(266, 20);
            this.txtTypeName.TabIndex = 1;
            this.txtTypeName.Text = "System.Object";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fully quialified name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Assembly:";
            // 
            // txtAssemblyPath
            // 
            this.txtAssemblyPath.Location = new System.Drawing.Point(72, 195);
            this.txtAssemblyPath.Name = "txtAssemblyPath";
            this.txtAssemblyPath.Size = new System.Drawing.Size(209, 20);
            this.txtAssemblyPath.TabIndex = 4;
            this.txtAssemblyPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAssemblyPath_KeyDown);
            // 
            // btnSelectAssembly
            // 
            this.btnSelectAssembly.Location = new System.Drawing.Point(287, 193);
            this.btnSelectAssembly.Name = "btnSelectAssembly";
            this.btnSelectAssembly.Size = new System.Drawing.Size(60, 24);
            this.btnSelectAssembly.TabIndex = 5;
            this.btnSelectAssembly.Text = "...";
            this.btnSelectAssembly.UseVisualStyleBackColor = true;
            this.btnSelectAssembly.Click += new System.EventHandler(this.btnSelectAssembly_Click);
            // 
            // lstbxTypes
            // 
            this.lstbxTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstbxTypes.FormattingEnabled = true;
            this.lstbxTypes.IntegralHeight = false;
            this.lstbxTypes.Location = new System.Drawing.Point(15, 223);
            this.lstbxTypes.Name = "lstbxTypes";
            this.lstbxTypes.Size = new System.Drawing.Size(332, 200);
            this.lstbxTypes.TabIndex = 6;
            this.lstbxTypes.SelectedIndexChanged += new System.EventHandler(this.lstTypes_SelectedIndexChanged);
            // 
            // richtxtInfo
            // 
            this.richtxtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtxtInfo.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richtxtInfo.Location = new System.Drawing.Point(372, 49);
            this.richtxtInfo.Name = "richtxtInfo";
            this.richtxtInfo.Size = new System.Drawing.Size(836, 438);
            this.richtxtInfo.TabIndex = 13;
            this.richtxtInfo.Text = "";
            this.richtxtInfo.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Info:";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowInfo.Location = new System.Drawing.Point(287, 47);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(60, 24);
            this.btnShowInfo.TabIndex = 2;
            this.btnShowInfo.Text = "Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkFlattenHierarchy);
            this.groupBox1.Controls.Add(this.chkDeclaredOnly);
            this.groupBox1.Controls.Add(this.comboVisibility);
            this.groupBox1.Controls.Add(this.comboInstanceStatic);
            this.groupBox1.Location = new System.Drawing.Point(15, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Members attributes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Inst. / Stat.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Acc. modif.";
            // 
            // chkFlattenHierarchy
            // 
            this.chkFlattenHierarchy.AutoSize = true;
            this.chkFlattenHierarchy.Location = new System.Drawing.Point(183, 48);
            this.chkFlattenHierarchy.Name = "chkFlattenHierarchy";
            this.chkFlattenHierarchy.Size = new System.Drawing.Size(104, 17);
            this.chkFlattenHierarchy.TabIndex = 11;
            this.chkFlattenHierarchy.Text = "Flatten hierarchy";
            this.chkFlattenHierarchy.UseVisualStyleBackColor = true;
            // 
            // chkDeclaredOnly
            // 
            this.chkDeclaredOnly.AutoSize = true;
            this.chkDeclaredOnly.Location = new System.Drawing.Point(183, 19);
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
            this.comboVisibility.Location = new System.Drawing.Point(68, 46);
            this.comboVisibility.Name = "comboVisibility";
            this.comboVisibility.Size = new System.Drawing.Size(95, 21);
            this.comboVisibility.TabIndex = 9;
            // 
            // comboInstanceStatic
            // 
            this.comboInstanceStatic.FormattingEnabled = true;
            this.comboInstanceStatic.Items.AddRange(new object[] {
            "Both",
            "Instance",
            "Static"});
            this.comboInstanceStatic.Location = new System.Drawing.Point(68, 19);
            this.comboInstanceStatic.Name = "comboInstanceStatic";
            this.comboInstanceStatic.Size = new System.Drawing.Size(95, 21);
            this.comboInstanceStatic.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Filter:";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(243, 461);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(49, 24);
            this.btnFilter.TabIndex = 16;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilter.Location = new System.Drawing.Point(15, 463);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(221, 20);
            this.txtFilter.TabIndex = 15;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.Location = new System.Drawing.Point(298, 461);
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
            this.chkWrapLines.Location = new System.Drawing.Point(1132, 32);
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
            this.lblCount.Location = new System.Drawing.Point(41, 429);
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
            this.menuStrip1.Size = new System.Drawing.Size(1220, 24);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "Search...";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 499);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.chkWrapLines);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richtxtInfo);
            this.Controls.Add(this.lstbxTypes);
            this.Controls.Add(this.btnSelectAssembly);
            this.Controls.Add(this.txtAssemblyPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ReflectorTRM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label3;
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
    }
}

