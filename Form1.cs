namespace BurgerKiosk
{
    public partial class Form1 : Form
    {

        // 변수 설계
        int totalCost = 0;

        public Form1()
        {
            InitializeComponent();
            // Shown 이벤트를 사용하여 화면이 다 뜨고 난 직후에 체크 해제
            this.Shown += (s, e) => {
                rdoHamBurger.Checked = false;
                rdoBulgogiBurger.Checked = false;
                rdoChickenBurger.Checked = false;
                lblTotalCost.Text = "총 금액 : 0원"; // 텍스트 유지
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 모든 라디오 버튼 체크 해제
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            // [핵심] 체크는 안 되어 있지만, Tab 키를 누르면 여기로 오게 설정
            rdoHamBurger.TabStop = true;

            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액 : 0원";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateOrderInfo()
        {
            // 1. 초기화 (계산 전 항상 0으로 시작)
            totalCost = 0;
            lstOrder.Items.Clear();
            lblTotalCost.ForeColor = System.Drawing.Color.Blue;

            // 2. RadioButton 확인 (즉시 리스트 추가 및 금액 합산)
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            // 3. CheckBox 확인 (즉시 리스트 추가 및 금액 합산)
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            // 4. 즉시 라벨 업데이트
            lblTotalCost.Text = "총 금액 : " + totalCost.ToString("N0") + "원";
        }

        private void Menu_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderInfo();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            UpdateOrderInfo();

            // 2. 메뉴 선택 여부 확인
            if (totalCost == 0) // UpdateOrderInfo 실행 후 totalCost가 0이라면
            {
                lblTotalCost.Text = "메뉴를 선택하세요";
                lblTotalCost.ForeColor = System.Drawing.Color.Red;
                return;
            }


            // 문자열 출력 (결과 표시)
            // 기본 형식: "총 금액: " + totalCost + "원"
            lblTotalCost.Text = "총 금액 : " + totalCost.ToString() + "원";

            groupBox1.Focus();
            rdoHamBurger.TabStop = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // 1. 변수 초기화
            totalCost = 0;

            // 2. UI 컨트롤 초기화
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액 : 0원";

            // 3. 선택 상태 초기화
            rdoHamBurger.Checked = true;

            lblTotalCost.ForeColor = System.Drawing.Color.Black; // 색상도 초기화

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            groupBox1.Focus();
            rdoHamBurger.TabStop = true;
        }
    }
}
