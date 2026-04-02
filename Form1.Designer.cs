namespace LoginScreen
{
    partial class LoginMainForm
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
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("서울남산체 L", 48F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(188, 22);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(189, 76);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("서울한강 장체 L", 27.7499962F);
            txtID.ForeColor = SystemColors.ScrollBar;
            txtID.Location = new Point(40, 121);
            txtID.Name = "txtID";
            txtID.Size = new Size(493, 51);
            txtID.TabIndex = 1;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("서울한강 장체 L", 27.7499962F);
            txtPW.ForeColor = SystemColors.ScrollBar;
            txtPW.Location = new Point(40, 194);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(493, 51);
            txtPW.TabIndex = 2;
            txtPW.Text = "비밀번호";
            txtPW.Enter += txtPW_Enter;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("서울남산체 M", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(204, 272);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(173, 64);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // LoginMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 371);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "LoginMainForm";
            Text = "로그인";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
    }
}
