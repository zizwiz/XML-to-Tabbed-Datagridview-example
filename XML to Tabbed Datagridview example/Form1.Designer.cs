
namespace XML_to_Tabbed_Datagridview_example
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_one = new System.Windows.Forms.TabPage();
            this.dgv_tab1 = new System.Windows.Forms.DataGridView();
            this.tab_two = new System.Windows.Forms.TabPage();
            this.dgv_tab2 = new System.Windows.Forms.DataGridView();
            this.tab_three = new System.Windows.Forms.TabPage();
            this.dgv_tab3 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_open = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_one.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tab1)).BeginInit();
            this.tab_two.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tab2)).BeginInit();
            this.tab_three.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tab3)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1223, 772);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 686);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_one);
            this.tabControl1.Controls.Add(this.tab_two);
            this.tabControl1.Controls.Add(this.tab_three);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1217, 686);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_one
            // 
            this.tab_one.Controls.Add(this.dgv_tab1);
            this.tab_one.Location = new System.Drawing.Point(4, 29);
            this.tab_one.Name = "tab_one";
            this.tab_one.Padding = new System.Windows.Forms.Padding(3);
            this.tab_one.Size = new System.Drawing.Size(1209, 653);
            this.tab_one.TabIndex = 0;
            this.tab_one.Text = "Tab 1";
            this.tab_one.UseVisualStyleBackColor = true;
            // 
            // dgv_tab1
            // 
            this.dgv_tab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tab1.Location = new System.Drawing.Point(3, 3);
            this.dgv_tab1.Name = "dgv_tab1";
            this.dgv_tab1.RowHeadersWidth = 62;
            this.dgv_tab1.RowTemplate.Height = 28;
            this.dgv_tab1.Size = new System.Drawing.Size(1203, 647);
            this.dgv_tab1.TabIndex = 0;
            // 
            // tab_two
            // 
            this.tab_two.Controls.Add(this.dgv_tab2);
            this.tab_two.Location = new System.Drawing.Point(4, 29);
            this.tab_two.Name = "tab_two";
            this.tab_two.Padding = new System.Windows.Forms.Padding(3);
            this.tab_two.Size = new System.Drawing.Size(1209, 653);
            this.tab_two.TabIndex = 1;
            this.tab_two.Text = "Tab 2";
            this.tab_two.UseVisualStyleBackColor = true;
            // 
            // dgv_tab2
            // 
            this.dgv_tab2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tab2.Location = new System.Drawing.Point(3, 3);
            this.dgv_tab2.Name = "dgv_tab2";
            this.dgv_tab2.RowHeadersWidth = 62;
            this.dgv_tab2.RowTemplate.Height = 28;
            this.dgv_tab2.Size = new System.Drawing.Size(1203, 647);
            this.dgv_tab2.TabIndex = 1;
            // 
            // tab_three
            // 
            this.tab_three.Controls.Add(this.dgv_tab3);
            this.tab_three.Location = new System.Drawing.Point(4, 29);
            this.tab_three.Name = "tab_three";
            this.tab_three.Size = new System.Drawing.Size(1209, 653);
            this.tab_three.TabIndex = 2;
            this.tab_three.Text = "Tab 3";
            this.tab_three.UseVisualStyleBackColor = true;
            // 
            // dgv_tab3
            // 
            this.dgv_tab3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tab3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tab3.Location = new System.Drawing.Point(0, 0);
            this.dgv_tab3.Name = "dgv_tab3";
            this.dgv_tab3.RowHeadersWidth = 62;
            this.dgv_tab3.RowTemplate.Height = 28;
            this.dgv_tab3.Size = new System.Drawing.Size(1209, 653);
            this.dgv_tab3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 74);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1217, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_open);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 68);
            this.panel3.TabIndex = 0;
            // 
            // btn_open
            // 
            this.btn_open.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open.Location = new System.Drawing.Point(79, 7);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(141, 55);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_save);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(307, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 68);
            this.panel4.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(79, 7);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(141, 55);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(611, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 68);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_close);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(915, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 68);
            this.panel6.TabIndex = 3;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(79, 7);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(141, 55);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 772);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "XML to Tabbed Gridview Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_one.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tab1)).EndInit();
            this.tab_two.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tab2)).EndInit();
            this.tab_three.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tab3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_one;
        private System.Windows.Forms.TabPage tab_two;
        private System.Windows.Forms.TabPage tab_three;
        public System.Windows.Forms.DataGridView dgv_tab3;
        private System.Windows.Forms.DataGridView dgv_tab1;
        private System.Windows.Forms.DataGridView dgv_tab2;
    }
}

