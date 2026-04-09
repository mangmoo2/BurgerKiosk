namespace BurgerKiosk
{
    public partial class Form1 : Form
    {

        // 변수 설계
        int totalCost = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 주의: 계산 전 항상 0으로 초기화
            totalCost = 0;
            lstOrder.Items.Clear();

            // 2. 메뉴 선택 여부 확인 
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                // 에러 메시지 표시
                lblTotalCost.Text = "메뉴를 선택하세요";
                lblTotalCost.ForeColor = System.Drawing.Color.Red; // 에러는 빨간색으로 강조
                return; 
            }

            // 특징: 하나만 선택되므로 중복 계산 없음
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

            // 확장: 다른 체크박스에도 동일 패턴 적용
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀기 3,500원");
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

            // 문자열 출력 (결과 표시)
            // 기본 형식: "총 금액: " + totalCost + "원"
            lblTotalCost.Text = "총 금액 : " + totalCost.ToString() + "원";

            rdoHamBurger.Focus();
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
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            lblTotalCost.ForeColor = System.Drawing.Color.Black; // 색상도 초기화

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            rdoHamBurger.Focus();
        }
    }
}
