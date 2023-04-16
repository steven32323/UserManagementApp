namespace MyApp.WinForm
{
    partial class AddUser
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
            datePicker = new System.Windows.Forms.Label();
            inputForename = new System.Windows.Forms.TextBox();
            inputSurname = new System.Windows.Forms.TextBox();
            isActiveChecked = new System.Windows.Forms.CheckBox();
            inputDoB = new System.Windows.Forms.DateTimePicker();
            btnSave = new System.Windows.Forms.Button();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(74, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Forename: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(74, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(74, 108);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Is Active?";
            // 
            // datePicker
            // 
            datePicker.AutoSize = true;
            datePicker.Location = new System.Drawing.Point(74, 145);
            datePicker.Name = "datePicker";
            datePicker.Size = new System.Drawing.Size(79, 15);
            datePicker.TabIndex = 3;
            datePicker.Text = "Date of Birth: ";
            // 
            // inputForename
            // 
            inputForename.Location = new System.Drawing.Point(200, 37);
            inputForename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            inputForename.Name = "inputForename";
            inputForename.Size = new System.Drawing.Size(219, 23);
            inputForename.TabIndex = 4;
            inputForename.Validating += inputForename_Validating;
            // 
            // inputSurname
            // 
            inputSurname.Location = new System.Drawing.Point(200, 76);
            inputSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            inputSurname.Name = "inputSurname";
            inputSurname.Size = new System.Drawing.Size(219, 23);
            inputSurname.TabIndex = 5;
            inputSurname.Validating += inputSurname_Validating;
            // 
            // isActiveChecked
            // 
            isActiveChecked.AutoSize = true;
            isActiveChecked.Location = new System.Drawing.Point(200, 111);
            isActiveChecked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            isActiveChecked.Name = "isActiveChecked";
            isActiveChecked.Size = new System.Drawing.Size(15, 14);
            isActiveChecked.TabIndex = 6;
            isActiveChecked.UseVisualStyleBackColor = true;
            // 
            // inputDoB
            // 
            inputDoB.Location = new System.Drawing.Point(200, 141);
            inputDoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            inputDoB.Name = "inputDoB";
            inputDoB.Size = new System.Drawing.Size(219, 23);
            inputDoB.TabIndex = 7;
            inputDoB.Validating += inputDoB_Validating;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(435, 208);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Add User";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(522, 243);
            Controls.Add(btnSave);
            Controls.Add(inputDoB);
            Controls.Add(isActiveChecked);
            Controls.Add(inputSurname);
            Controls.Add(inputForename);
            Controls.Add(datePicker);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "AddUser";
            Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label datePicker;
        public System.Windows.Forms.DateTimePicker inputDoB;
        public System.Windows.Forms.CheckBox isActiveChecked;
        public System.Windows.Forms.TextBox inputSurname;
        public System.Windows.Forms.TextBox inputForename;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}