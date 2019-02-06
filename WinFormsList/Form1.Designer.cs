namespace WinFormsList
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deptsFormPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.addDeptButton = new System.Windows.Forms.Button();
            this.D_Name = new System.Windows.Forms.TextBox();
            this.peopleFormPanel = new System.Windows.Forms.Panel();
            this.IdDep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.editPersonButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.depGridView = new System.Windows.Forms.DataGridView();
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.deptsFormPanel.SuspendLayout();
            this.peopleFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depGridView)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.deptsFormPanel);
            this.splitContainer1.Panel1.Controls.Add(this.peopleFormPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.buttonReset);
            this.splitContainer1.Panel2.Controls.Add(this.depGridView);
            this.splitContainer1.Panel2.Controls.Add(this.peopleListBox);
            this.splitContainer1.Size = new System.Drawing.Size(884, 562);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // deptsFormPanel
            // 
            this.deptsFormPanel.Controls.Add(this.button1);
            this.deptsFormPanel.Controls.Add(this.button2);
            this.deptsFormPanel.Controls.Add(this.label5);
            this.deptsFormPanel.Controls.Add(this.label6);
            this.deptsFormPanel.Controls.Add(this.Id);
            this.deptsFormPanel.Controls.Add(this.addDeptButton);
            this.deptsFormPanel.Controls.Add(this.D_Name);
            this.deptsFormPanel.Location = new System.Drawing.Point(12, 292);
            this.deptsFormPanel.Name = "deptsFormPanel";
            this.deptsFormPanel.Size = new System.Drawing.Size(264, 150);
            this.deptsFormPanel.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Id";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(3, 30);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(258, 20);
            this.Id.TabIndex = 0;
            // 
            // addDeptButton
            // 
            this.addDeptButton.Location = new System.Drawing.Point(6, 112);
            this.addDeptButton.Name = "addDeptButton";
            this.addDeptButton.Size = new System.Drawing.Size(75, 23);
            this.addDeptButton.TabIndex = 3;
            this.addDeptButton.Text = "Add";
            this.addDeptButton.UseVisualStyleBackColor = true;
            this.addDeptButton.Click += new System.EventHandler(this.addDeptButton_Click);
            // 
            // D_Name
            // 
            this.D_Name.Location = new System.Drawing.Point(3, 86);
            this.D_Name.Name = "D_Name";
            this.D_Name.Size = new System.Drawing.Size(258, 20);
            this.D_Name.TabIndex = 1;
            // 
            // peopleFormPanel
            // 
            this.peopleFormPanel.Controls.Add(this.IdDep);
            this.peopleFormPanel.Controls.Add(this.label4);
            this.peopleFormPanel.Controls.Add(this.deletePersonButton);
            this.peopleFormPanel.Controls.Add(this.editPersonButton);
            this.peopleFormPanel.Controls.Add(this.label3);
            this.peopleFormPanel.Controls.Add(this.label2);
            this.peopleFormPanel.Controls.Add(this.label1);
            this.peopleFormPanel.Controls.Add(this.FirstName);
            this.peopleFormPanel.Controls.Add(this.addPersonButton);
            this.peopleFormPanel.Controls.Add(this.MiddleName);
            this.peopleFormPanel.Controls.Add(this.LastName);
            this.peopleFormPanel.Location = new System.Drawing.Point(12, 12);
            this.peopleFormPanel.Name = "peopleFormPanel";
            this.peopleFormPanel.Size = new System.Drawing.Size(264, 274);
            this.peopleFormPanel.TabIndex = 4;
            // 
            // IdDep
            // 
            this.IdDep.Location = new System.Drawing.Point(4, 199);
            this.IdDep.Name = "IdDep";
            this.IdDep.Size = new System.Drawing.Size(100, 20);
            this.IdDep.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dept ID";
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Location = new System.Drawing.Point(168, 248);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(75, 23);
            this.deletePersonButton.TabIndex = 8;
            this.deletePersonButton.Text = "Delete";
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // editPersonButton
            // 
            this.editPersonButton.Location = new System.Drawing.Point(87, 248);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(75, 23);
            this.editPersonButton.TabIndex = 7;
            this.editPersonButton.Text = "Edit";
            this.editPersonButton.UseVisualStyleBackColor = true;
            this.editPersonButton.Click += new System.EventHandler(this.editPersonButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(3, 30);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(258, 20);
            this.FirstName.TabIndex = 0;
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(6, 248);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(75, 23);
            this.addPersonButton.TabIndex = 3;
            this.addPersonButton.Text = "Add";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(3, 86);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(258, 20);
            this.MiddleName.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(3, 145);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(258, 20);
            this.LastName.TabIndex = 2;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 130);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // depGridView
            // 
            this.depGridView.AllowUserToAddRows = false;
            this.depGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depGridView.Location = new System.Drawing.Point(12, 292);
            this.depGridView.Name = "depGridView";
            this.depGridView.Size = new System.Drawing.Size(562, 150);
            this.depGridView.TabIndex = 1;
            this.depGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.depGridView_RowHeaderMouseClick);
            // 
            // peopleListBox
            // 
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.Location = new System.Drawing.Point(12, 11);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(562, 95);
            this.peopleListBox.TabIndex = 0;
            this.peopleListBox.SelectedValueChanged += new System.EventHandler(this.peopleListBox_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Выделение строк - щелчком по заголовку строки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Сбросить фильтр";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.deptsFormPanel.ResumeLayout(false);
            this.deptsFormPanel.PerformLayout();
            this.peopleFormPanel.ResumeLayout(false);
            this.peopleFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.ListBox peopleListBox;
        private System.Windows.Forms.Panel peopleFormPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editPersonButton;
        private System.Windows.Forms.Button deletePersonButton;
        private System.Windows.Forms.Panel deptsFormPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button addDeptButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox D_Name;
        private System.Windows.Forms.DataGridView depGridView;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox IdDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

