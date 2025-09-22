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
            this.query2 = new System.Windows.Forms.TabPage();
            this.query1 = new System.Windows.Forms.TabPage();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabСontrol1 = new System.Windows.Forms.TabControl();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabСontrol1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            // tab1
            // 
            this.tab1.Controls.Add(this.txtFullName);
            this.tab1.Controls.Add(this.txtEmployeeID);
            this.tab1.Controls.Add(this.btnAddEmp);
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
            // btnAddEmp
            // 
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEmp.Location = new System.Drawing.Point(650, 175);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(292, 55);
            this.btnAddEmp.TabIndex = 3;
            this.btnAddEmp.Text = "Добавить";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(642, 461);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // tab2
            // 
            this.tab2.Controls.Add(this.btnAddPart);
            this.tab2.Controls.Add(this.dataGridView2);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(949, 469);
            this.tab2.TabIndex = 4;
            this.tab2.Text = "tab2";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPart.Location = new System.Drawing.Point(654, 4);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(292, 55);
            this.btnAddPart.TabIndex = 2;
            this.btnAddPart.Text = "Добавить";
            this.btnAddPart.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(643, 461);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(654, 19);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(288, 22);
            this.txtEmployeeID.TabIndex = 4;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(653, 47);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(288, 22);
            this.txtFullName.TabIndex = 5;
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
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabСontrol1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage query2;
        private System.Windows.Forms.TabPage query1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabСontrol1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtFullName;
    }
}

