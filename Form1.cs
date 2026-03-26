namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") || (isOperationPerformed))
                txtInput.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtInput.Text = txtInput.Text + button.Text;
        }

        private void btnNum0_Click(object sender, EventArgs e) => btnNumber_Click(sender, e);
        private void btnNum1_Click(object sender, EventArgs e) => btnNumber_Click(sender, e);
        private void btnNum2_Click(object sender, EventArgs e) => btnNumber_Click(sender, e);
        private void btnNum3_Click(object sender, EventArgs e) => btnNumber_Click(sender, e);
        private void btnNum4_Click(object sender, EventArgs e) => btnNumber_Click(sender, e);
        private void btnNum5_Click(object sender, EventArgs e) => btnNumber_Click(sender, e);
        private void btnNum6_Click(object sender, EventArgs e) => btnNumber_Click(sender, e);
        private void btnNum7_Click(object sender, EventArgs e) => btnNumber_Click(sender, e);
        private void btnNum8_Click(object sender, EventArgs e) => btnNumber_Click(sender, e);
        private void btnNum9_Click(object sender, EventArgs e) => btnNumber_Click(sender, e);

        private void btnOperation_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;

                if (!int.TryParse(txtInput.Text, out int currentValue))
                {
                    MessageBox.Show("유효한 숫자를 입력하세요.", "입력 오류");
                    return;
                }

                // 이전 operation이 있으면 계산 수행
                if (!string.IsNullOrEmpty(operationPerformed) && resultValue != 0)
                {
                    int result = PerformOperation(resultValue, currentValue, operationPerformed);
                    resultValue = result;
                    txtOutput.Text = result + " " + button.Text;
                }
                else
                {
                    resultValue = currentValue;
                    txtOutput.Text = resultValue + " " + button.Text;
                }

                operationPerformed = button.Text;
                isOperationPerformed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "계산 오류");
            }
        }

        private int PerformOperation(int first, int second, string operation)
        {
            switch(operation)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "*":
                    return first * second;
                case "/":
                    if (second == 0)
                        throw new InvalidOperationException("0으로 나눌 수 없습니다.");
                    return first / second;
                default:
                    return second;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) => btnOperation_Click(sender, e);
        private void btnSub_Click(object sender, EventArgs e) => btnOperation_Click(sender, e);
        private void btnMul_Click(object sender, EventArgs e) => btnOperation_Click(sender, e);
        private void btnDiv_Click(object sender, EventArgs e) => btnOperation_Click(sender, e);

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtInput.Text, out int secondValue))
                {
                    MessageBox.Show("유효한 숫자를 입력하세요.", "입력 오류");
                    return;
                }

                if (string.IsNullOrEmpty(operationPerformed))
                {
                    MessageBox.Show("먼저 계산을 수행하세요.", "입력 오류");
                    return;
                }

                int result = PerformOperation(resultValue, secondValue, operationPerformed);

                txtOutput.Text = txtOutput.Text + " " + txtInput.Text + " = " + result;

                txtInput.Text = result.ToString();
                resultValue = 0;
                operationPerformed = "";
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "계산 오류");
                txtInput.Clear();
                txtOutput.Clear();
                resultValue = 0;
                operationPerformed = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message, "계산 오류");
                txtInput.Clear();
                txtOutput.Clear();
                resultValue = 0;
                operationPerformed = "";
            }
        }
    }
}
