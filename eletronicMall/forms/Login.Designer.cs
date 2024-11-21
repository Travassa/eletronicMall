namespace eletronicMall
{
    partial class Login
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
            groupBox = new GroupBox();
            btnLogin = new Button();
            btnExit = new Button();
            textUser = new Label();
            textPass = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(textBox2);
            groupBox.Controls.Add(textBox1);
            groupBox.Controls.Add(textPass);
            groupBox.Controls.Add(textUser);
            groupBox.Controls.Add(btnExit);
            groupBox.Controls.Add(btnLogin);
            groupBox.Location = new Point(24, 20);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(471, 250);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Login";
            groupBox.Enter += groupBox1_Enter;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(271, 209);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Enter";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(371, 209);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // textUser
            // 
            textUser.AutoSize = true;
            textUser.Location = new Point(43, 55);
            textUser.Name = "textUser";
            textUser.Size = new Size(45, 20);
            textUser.TabIndex = 2;
            textUser.Text = "User :";
            // 
            // textPass
            // 
            textPass.AutoSize = true;
            textPass.Location = new Point(43, 119);
            textPass.Name = "textPass";
            textPass.Size = new Size(43, 20);
            textPass.TabIndex = 3;
            textPass.Text = "Pass :";
            textPass.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(359, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 294);
            Controls.Add(groupBox);
            Name = "Form1";
            Text = "Form1";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label textPass;
        private Label textUser;
        private Button btnExit;
        private Button btnLogin;
    }
}
