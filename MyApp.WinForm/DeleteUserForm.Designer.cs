namespace MyApp.WinForm
{
    partial class DeleteUserForm
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
            btnYes = new System.Windows.Forms.Button();
            btnNo = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(233, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(270, 15);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you want to delete the selected user?";
            //
            // btnYes
            // 
            btnYes = new System.Windows.Forms.Button();
            btnYes.Location = new System.Drawing.Point(268, 71);
            btnYes.Name = "btnYes";
            btnYes.Size = new System.Drawing.Size(75, 23);
            btnYes.TabIndex = 1;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            btnNo = new System.Windows.Forms.Button();
            btnNo.Location = new System.Drawing.Point(382, 71);
            btnNo.Name = "btnNo";
            btnNo.Size = new System.Drawing.Size(75, 23);
            btnNo.TabIndex = 2;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(731, 111);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(label1);
            Name = "DeleteUser";
            Text = "DeleteUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}