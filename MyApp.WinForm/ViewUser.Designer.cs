namespace MyApp.WinForm
{
    partial class ViewUser
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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblForename = new System.Windows.Forms.Label();
            lblSurname = new System.Windows.Forms.Label();
            lblIsActive = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            lblDateOfBirth = new System.Windows.Forms.Label();
            dataGridView = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            actionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            actionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            actionLogBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)actionLogBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(24, 22);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "View User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 70);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Forename:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(25, 106);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Surname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(25, 140);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Is Active:";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Location = new System.Drawing.Point(121, 70);
            lblForename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblForename.Name = "lblForename";
            lblForename.Size = new System.Drawing.Size(77, 15);
            lblForename.TabIndex = 4;
            lblForename.Text = "[FORENAME]";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new System.Drawing.Point(121, 106);
            lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new System.Drawing.Size(70, 15);
            lblSurname.TabIndex = 5;
            lblSurname.Text = "[SURNAME]";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new System.Drawing.Point(121, 140);
            lblIsActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new System.Drawing.Size(62, 15);
            lblIsActive.TabIndex = 6;
            lblIsActive.Text = "[ISACTIVE]";
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(326, 334);
            btnBack.Margin = new System.Windows.Forms.Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(93, 40);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(25, 178);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 15);
            label5.TabIndex = 8;
            label5.Text = "Date of Birth: ";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new System.Drawing.Point(121, 178);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new System.Drawing.Size(88, 15);
            lblDateOfBirth.TabIndex = 9;
            lblDateOfBirth.Text = "[DATEOFBIRTH]";
            // 
            // dataGridView
            // 
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, actionTypeDataGridViewTextBoxColumn, actionDateDataGridViewTextBoxColumn });
            dataGridView.DataSource = actionLogBindingSource;
            dataGridView.Location = new System.Drawing.Point(310, 43);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new System.Drawing.Size(444, 257);
            dataGridView.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // actionTypeDataGridViewTextBoxColumn
            // 
            actionTypeDataGridViewTextBoxColumn.DataPropertyName = "ActionType";
            actionTypeDataGridViewTextBoxColumn.HeaderText = "ActionType";
            actionTypeDataGridViewTextBoxColumn.Name = "actionTypeDataGridViewTextBoxColumn";
            // 
            // actionDateDataGridViewTextBoxColumn
            // 
            actionDateDataGridViewTextBoxColumn.DataPropertyName = "ActionDate";
            actionDateDataGridViewTextBoxColumn.HeaderText = "ActionDate";
            actionDateDataGridViewTextBoxColumn.Name = "actionDateDataGridViewTextBoxColumn";
            // 
            // actionLogBindingSource
            // 
            actionLogBindingSource.DataSource = typeof(Models.ActionLog);
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(785, 385);
            Controls.Add(dataGridView);
            Controls.Add(lblDateOfBirth);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(lblIsActive);
            Controls.Add(lblSurname);
            Controls.Add(lblForename);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "ViewUser";
            Text = "ViewUser";
            Load += ViewUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)actionLogBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource actionLogBindingSource;
    }
}