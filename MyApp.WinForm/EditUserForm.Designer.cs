namespace MyApp.WinForm
{
    partial class EditUserForm
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            inputForename = new System.Windows.Forms.TextBox();
            inputSurname = new System.Windows.Forms.TextBox();
            isActive = new System.Windows.Forms.CheckBox();
            inputDoB = new System.Windows.Forms.DateTimePicker();
            EditSave = new System.Windows.Forms.Button();
            noEdit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Forename: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(37, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(37, 114);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Is Active?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(37, 158);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Date of Birth: ";
            // 
            // inputForename
            // 
            inputForename.Location = new System.Drawing.Point(152, 38);
            inputForename.Name = "inputForename";
            inputForename.Size = new System.Drawing.Size(202, 23);
            inputForename.TabIndex = 4;
            // 
            // inputSurname
            // 
            inputSurname.Location = new System.Drawing.Point(152, 76);
            inputSurname.Name = "inputSurname";
            inputSurname.Size = new System.Drawing.Size(202, 23);
            inputSurname.TabIndex = 5;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Location = new System.Drawing.Point(156, 120);
            isActive.Name = "isActive";
            isActive.Size = new System.Drawing.Size(15, 14);
            isActive.TabIndex = 6;
            isActive.UseVisualStyleBackColor = true;
            // 
            // inputDoB
            // 
            inputDoB.Location = new System.Drawing.Point(154, 157);
            inputDoB.Name = "inputDoB";
            inputDoB.Size = new System.Drawing.Size(200, 23);
            inputDoB.TabIndex = 7;
            // 
            // EditSave
            // 
            EditSave.Location = new System.Drawing.Point(279, 271);
            EditSave.Name = "EditSave";
            EditSave.Size = new System.Drawing.Size(75, 23);
            EditSave.TabIndex = 8;
            EditSave.Text = "Save";
            EditSave.UseVisualStyleBackColor = true;
            EditSave.Click += btnSave_Click;
            // 
            // noEdit
            // 
            noEdit.Location = new System.Drawing.Point(381, 271);
            noEdit.Name = "noEdit";
            noEdit.Size = new System.Drawing.Size(75, 23);
            noEdit.TabIndex = 9;
            noEdit.Text = "Cancel";
            noEdit.UseVisualStyleBackColor = true;
            noEdit.Click += btnCancel_Click;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(529, 313);
            Controls.Add(noEdit);
            Controls.Add(EditSave);
            Controls.Add(inputDoB);
            Controls.Add(isActive);
            Controls.Add(inputSurname);
            Controls.Add(inputForename);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditUserForm";
            Text = "EditUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputForename;
        private System.Windows.Forms.TextBox inputSurname;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.DateTimePicker inputDoB;
        private System.Windows.Forms.Button EditSave;
        private System.Windows.Forms.Button noEdit;
    }
}