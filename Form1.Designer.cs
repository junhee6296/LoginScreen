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
            lblErrorMsg = new Label();
            chkShowPW = new CheckBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("서울남산체 L", 48F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(177, 10);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(189, 76);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("서울한강 장체 L", 27.7499962F);
            txtID.ForeColor = SystemColors.ScrollBar;
            txtID.Location = new Point(40, 86);
            txtID.Name = "txtID";
            txtID.Size = new Size(493, 51);
            txtID.TabIndex = 1;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("서울한강 장체 L", 27.7499962F);
            txtPW.ForeColor = SystemColors.ScrollBar;
            txtPW.Location = new Point(40, 143);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(493, 51);
            txtPW.TabIndex = 2;
            txtPW.Text = "비밀번호";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("서울남산체 M", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(193, 232);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(173, 64);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("서울남산 장체 M", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(141, 328);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(269, 19);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.TextAlign = ContentAlignment.MiddleCenter;
            lblErrorMsg.Visible = false;
            // 
            // chkShowPW
            // 
            chkShowPW.AutoSize = true;
            chkShowPW.Location = new Point(431, 200);
            chkShowPW.Name = "chkShowPW";
            chkShowPW.Size = new Size(102, 19);
            chkShowPW.TabIndex = 5;
            chkShowPW.Text = "비밀번호 표시";
            chkShowPW.UseVisualStyleBackColor = true;
            chkShowPW.CheckedChanged += chkShowPW_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.Font = new Font("서울남산체 M", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClear.ForeColor = SystemColors.ButtonFace;
            btnClear.Location = new Point(409, 51);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "전체 삭제";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // LoginMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 371);
            Controls.Add(btnClear);
            Controls.Add(chkShowPW);
            Controls.Add(lblErrorMsg);
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
        private Label lblErrorMsg;
        private CheckBox chkShowPW;
        private Button btnClear;
    }
}
