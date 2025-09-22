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
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabСontrol1 = new System.Windows.Forms.TabControl();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.btnUpdatePart = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
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
            this.tab1.Controls.Add(this.btnDeleteEmp);
            this.tab1.Controls.Add(this.btnUpdateEmp);
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
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateEmp.Location = new System.Drawing.Point(650, 86);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(280, 55);
            this.btnUpdateEmp.TabIndex = 4;
            this.btnUpdateEmp.Text = "Обновить";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEmp.Location = new System.Drawing.Point(650, 7);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(280, 55);
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
            this.tab2.Controls.Add(this.btnDeletePart);
            this.tab2.Controls.Add(this.btnUpdatePart);
            this.tab2.Controls.Add(this.btnAddPart);
            this.tab2.Controls.Add(this.dataGridView2);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(949, 469);
            this.tab2.TabIndex = 4;
            this.tab2.Text = "tab2";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePart
            // 
            this.btnUpdatePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdatePart.Location = new System.Drawing.Point(654, 75);
            this.btnUpdatePart.Name = "btnUpdatePart";
            this.btnUpdatePart.Size = new System.Drawing.Size(280, 55);
            this.btnUpdatePart.TabIndex = 3;
            this.btnUpdatePart.Text = "Обновить";
            this.btnUpdatePart.UseVisualStyleBackColor = true;
            this.btnUpdatePart.Click += new System.EventHandler(this.btnUpdatePart_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPart.Location = new System.Drawing.Point(654, 4);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(280, 55);
            this.btnAddPart.TabIndex = 2;
            this.btnAddPart.Text = "Добавить";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
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
            // btnDeletePart
            // 
            this.btnDeletePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeletePart.Location = new System.Drawing.Point(654, 148);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(280, 55);
            this.btnDeletePart.TabIndex = 4;
            this.btnDeletePart.Text = "Удалить";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteEmp.Location = new System.Drawing.Point(650, 163);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(280, 55);
            this.btnDeleteEmp.TabIndex = 5;
            this.btnDeleteEmp.Text = "Удалить";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
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
        private System.Windows.Forms.Button btnUpdatePart;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Button btnDeletePart;
    }
}

