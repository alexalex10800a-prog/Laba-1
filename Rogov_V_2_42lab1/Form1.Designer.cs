namespace Rogov_V_2_42lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabСontrol1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.query1 = new System.Windows.Forms.TabPage();
            this.query2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabСontrol1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabСontrol1
            // 
            this.tabСontrol1.Controls.Add(this.tab1);
            this.tabСontrol1.Controls.Add(this.tab2);
            this.tabСontrol1.Controls.Add(this.query1);
            this.tabСontrol1.Controls.Add(this.query2);
            this.tabСontrol1.Location = new System.Drawing.Point(17, 16);
            this.tabСontrol1.Margin = new System.Windows.Forms.Padding(4);
            this.tabСontrol1.Name = "tabСontrol1";
            this.tabСontrol1.SelectedIndex = 0;
            this.tabСontrol1.Size = new System.Drawing.Size(957, 498);
            this.tabСontrol1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.comboBox1);
            this.tab1.Controls.Add(this.dataGridView1);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Margin = new System.Windows.Forms.Padding(4);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(4);
            this.tab1.Size = new System.Drawing.Size(949, 469);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "tab1";
            this.tab1.UseVisualStyleBackColor = true;
            this.tab1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(620, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.dataGridView2);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Margin = new System.Windows.Forms.Padding(4);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(4);
            this.tab2.Size = new System.Drawing.Size(949, 469);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "tab2";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 7);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(480, 452);
            this.dataGridView2.TabIndex = 0;
            // 
            // query1
            // 
            this.query1.Location = new System.Drawing.Point(4, 25);
            this.query1.Margin = new System.Windows.Forms.Padding(4);
            this.query1.Name = "query1";
            this.query1.Padding = new System.Windows.Forms.Padding(4);
            this.query1.Size = new System.Drawing.Size(949, 469);
            this.query1.TabIndex = 2;
            this.query1.Text = "query1";
            this.query1.UseVisualStyleBackColor = true;
            // 
            // query2
            // 
            this.query2.Location = new System.Drawing.Point(4, 25);
            this.query2.Margin = new System.Windows.Forms.Padding(4);
            this.query2.Name = "query2";
            this.query2.Padding = new System.Windows.Forms.Padding(4);
            this.query2.Size = new System.Drawing.Size(949, 469);
            this.query2.TabIndex = 3;
            this.query2.Text = "query2";
            this.query2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(656, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 554);
            this.Controls.Add(this.tabСontrol1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabСontrol1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabСontrol1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage query1;
        private System.Windows.Forms.TabPage query2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

