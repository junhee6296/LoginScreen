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
        //비밀번호 실패 카운트
        int failCount = 0;


        // 로그인 버튼 클릭 이벤트 핸들러
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text; 
            string inputPW = txtPW.Text;

            if (inputID.Contains(" ")) // 아이디에 넣을 수 없는 글자 체크 (예: 공백) 
            {
                lblErrorMsg.Text = "아이디에 공백을 포함할 수 없습니다.";
                lblErrorMsg.Visible = true;
                return; 
            }

            if (inputPW.Length < 4) // 비밀번호에 꼭 들어가야 하는 문자 조건 체크 (예: 최소 길이) 
            {
                lblErrorMsg.Text = "비밀번호는 4자리 이상 입력해야 합니다.";
                lblErrorMsg.Visible = true;
                return; 
            }

            if (inputID == myID && inputPW == myPW)
            {
                lblErrorMsg.Visible = false;
                MessageBox.Show("로그인 성공!");
                failCount = 0; //성공 시 카운트 초기화
            }
            else
            {
                failCount++; // 로그인 실패 시 카운트 증가
                lblErrorMsg.Text = $"아이디 또는 비밀번호가 잘못 되었습니다. (실패: {failCount}회)";
                lblErrorMsg.Visible = true;

                if (failCount >= 3) // 3회 이상 실패 시
                {
                    MessageBox.Show("로그인 시도 횟수를 초과했습니다. 30초 후에 다시 시도해주세요.");
                    btnLogin.Enabled = false; // 로그인 버튼 클릭 방지

                    // 일정 회수가 지나면 정해진 시간 후에 재시도 가능하게 타이머 생성 
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 30000; // 30초
                    timer.Tick += delegate (object? s, EventArgs args)
                    {
                        btnLogin.Enabled = true; // 버튼 다시 활성화
                        failCount = 0; // 횟수 초기화
                        lblErrorMsg.Visible = false;
                        timer.Stop();
                        timer.Dispose();
                    };
                    timer.Start();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 아이디 초기화
            txtID.Text = "아이디";
            txtID.ForeColor = Color.Silver;

            // 비밀번호 초기화
            txtPW.Text = "비밀번호";
            txtPW.ForeColor = Color.Silver;
            txtPW.UseSystemPasswordChar = false; // 동그라미 가림막 해제

            lblErrorMsg.Visible = false; // 에러 메시지도 숨김
            txtID.Focus(); // 키보드 입력 커서를 다시 아이디 창으로 이동
        }

        // 비밀번호 표시 체크박스 상태 변경 이벤트
        private void chkShowPW_CheckedChanged(object sender, EventArgs e)
        {
            // 입력된 텍스트가 힌트용 "패스워드"가 아닐 때만 작동하도록 예외 처리
            if (txtPW.Text != "비밀번호")
            {
                // 체크박스가 체크되면 가림막(true)을 반전시켜서 false(보이게)로 만듦
                txtPW.UseSystemPasswordChar = !chkShowPW.Checked;
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
