namespace LoginScreen
{
    public partial class LoginMainForm : Form
    {
        public LoginMainForm()
        {
            InitializeComponent();
        }
        //비밀번호 및 아이디는 보통 DB에서 가져오지만, 예시에서는 간단히 하드코딩으로 처리
        string myID = "admin"; 
        string myPW = "superman";


        // 로그인 버튼 클릭 이벤트 핸들러
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text; 
            string inputPW = txtPW.Text;

            if (inputID == myID && inputPW == myPW)
            {
                lblErrorMsg.Visible = false;
                MessageBox.Show("로그인 성공!");
            }
            else
            {
                lblErrorMsg.Visible = true;
            }
        }

        // 아이디 가이드텍스트 on/off
        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        // 비밀번호 가이드텍스트 on/off
        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "비밀번호")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "비밀번호";
                txtPW.ForeColor = Color.Silver;
            }
        }
        // 아이디 >> 패스워드
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true; //비프음 방지
                txtPW.Focus(); // 패스워드 입력창으로 입력 커서(포커스)를 이동
            }
        }

        // 패스워드 >> 로그인 버튼 클릭
        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true; // 비프음 방지 
                btnLogin.PerformClick(); // 버튼을 직접 마우스로 클릭한 것과 동일한 기능 수행
            }
        }
    }
}
