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
            btnUserAdd = new Button();
            txtUserName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnProfileAdd = new Button();
            cmbUserName = new ComboBox();
            label3 = new Label();
            txtBio = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUserAdd);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(312, 235);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Create";
            // 
            // btnUserAdd
            // 
            btnUserAdd.Location = new Point(171, 85);
            btnUserAdd.Margin = new Padding(3, 2, 3, 2);
            btnUserAdd.Name = "btnUserAdd";
            btnUserAdd.Size = new Size(82, 31);
            btnUserAdd.TabIndex = 2;
            btnUserAdd.Text = "Add";
            btnUserAdd.UseVisualStyleBackColor = true;
            btnUserAdd.Click += btnUserAdd_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(95, 44);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(158, 23);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 44);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "User Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnProfileAdd);
            groupBox2.Controls.Add(cmbUserName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtBio);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(382, 17);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(335, 226);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Profile Create";
            // 
            // btnProfileAdd
            // 
            btnProfileAdd.Location = new Point(171, 141);
            btnProfileAdd.Margin = new Padding(3, 2, 3, 2);
            btnProfileAdd.Name = "btnProfileAdd";
            btnProfileAdd.Size = new Size(88, 28);
            btnProfileAdd.TabIndex = 4;
            btnProfileAdd.Text = "Add";
            btnProfileAdd.UseVisualStyleBackColor = true;
            btnProfileAdd.Click += btnProfileAdd_Click;
            // 
            // cmbUserName
            // 
            cmbUserName.FormattingEnabled = true;
            cmbUserName.Location = new Point(99, 31);
            cmbUserName.Margin = new Padding(3, 2, 3, 2);
            cmbUserName.Name = "cmbUserName";
            cmbUserName.Size = new Size(160, 23);
            cmbUserName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 37);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "User Name:";
            // 
            // txtBio
            // 
            txtBio.Location = new Point(99, 82);
            txtBio.Margin = new Padding(3, 2, 3, 2);
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(160, 23);
            txtBio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 84);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 0;
            label2.Text = "Bio:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 440);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
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
