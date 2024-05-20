namespace CodeFirstConvertionDataEx
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtUserName = new TextBox();
            btnUserAdd = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            txtBio = new TextBox();
            label3 = new Label();
            cmbUserName = new ComboBox();
            btnProfileAdd = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUserAdd);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 313);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Create";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 58);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(109, 58);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(180, 27);
            txtUserName.TabIndex = 1;
            // 
            // btnUserAdd
            // 
            btnUserAdd.Location = new Point(195, 113);
            btnUserAdd.Name = "btnUserAdd";
            btnUserAdd.Size = new Size(94, 41);
            btnUserAdd.TabIndex = 2;
            btnUserAdd.Text = "Add";
            btnUserAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnProfileAdd);
            groupBox2.Controls.Add(cmbUserName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtBio);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(436, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(383, 302);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Profile Create";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 112);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 0;
            label2.Text = "Bio:";
            // 
            // txtBio
            // 
            txtBio.Location = new Point(113, 109);
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(182, 27);
            txtBio.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 49);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "User Name:";
            // 
            // cmbUserName
            // 
            cmbUserName.FormattingEnabled = true;
            cmbUserName.Location = new Point(113, 41);
            cmbUserName.Name = "cmbUserName";
            cmbUserName.Size = new Size(182, 28);
            cmbUserName.TabIndex = 3;
            // 
            // btnProfileAdd
            // 
            btnProfileAdd.Location = new Point(195, 188);
            btnProfileAdd.Name = "btnProfileAdd";
            btnProfileAdd.Size = new Size(100, 37);
            btnProfileAdd.TabIndex = 4;
            btnProfileAdd.Text = "Add";
            btnProfileAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 587);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            }
            #endregion
             private GroupBox groupBox1;
            private Button btnUserAdd;
            private TextBox txtUserName;
            private Label label1;
            private GroupBox groupBox2;
            private Button btnProfileAdd;
            private ComboBox cmbUserName;
            private Label label3;
            private TextBox txtBio;
            private Label label2;
    }
}
