namespace Projet_Forms_01 {
    public partial class Form1 : Form {

        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multipicacao = false;
        bool divisao = false;
        bool resultado = false;


        public Form1 () {
            InitializeComponent();
        }

        private void textBox1_TextChanged (object sender, EventArgs e) {

        }

        //--------Evento das Teclas da calculadora-----------------------
        private void btn1_Click (object sender, EventArgs e) {
            txtResultado.Text += "1";

            txtOperacao.Text += "1";
        }

        private void btn2_Click (object sender, EventArgs e) {
            txtResultado.Text += "2";

            txtOperacao.Text += "2";
        }

        private void btn3_Click (object sender, EventArgs e) {
            txtResultado.Text += "3";

            txtOperacao.Text += "3";
        }

        private void btn4_Click (object sender, EventArgs e) {
            txtResultado.Text += "4";

            txtOperacao.Text += "4";
        }

        private void btn5_Click (object sender, EventArgs e) {
            txtResultado.Text += "5";

            txtOperacao.Text += "5";
        }

        private void btn6_Click (object sender, EventArgs e) {
            txtResultado.Text += "6";

            txtOperacao.Text += "6";
        }

        private void btn7_Click (object sender, EventArgs e) {
            txtResultado.Text += "7";

            txtOperacao.Text += "7";
        }

        private void btn8_Click (object sender, EventArgs e) {
            txtResultado.Text += "8";

            txtOperacao.Text += "8";
        }

        private void btn9_Click (object sender, EventArgs e) {
            txtResultado.Text += "9";

            txtOperacao.Text += "9";
        }

        private void btn0_Click (object sender, EventArgs e) {
            txtOperacao.Text += "0";

            txtResultado.Text += "0";
        }

        private void btnVirgula_Click (object sender, EventArgs e) {
            txtOperacao.Text += ",";

            txtResultado.Text += ",";
        }

        //----------Evento das Operações-------------------------
        private void btnadicao_Click (object sender, EventArgs e) {

            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += " + ";

            txtResultado.Text = "";

            adicao = true;
            subtracao = false;
            multipicacao = false;
            divisao = false;
        }
        private void btnSubritacao_Click (object sender, EventArgs e) {

            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "-";

            txtResultado.Text = "";

            adicao = false;
            subtracao = true;
            multipicacao = false;
            divisao = false;
        }

        private void btnMutiplicacao_Click (object sender, EventArgs e) {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "*";

            txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multipicacao = true;
            divisao = false;
        }

        private void btnDivisao_Click (object sender, EventArgs e) {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += " / ";

            txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multipicacao = false;
            divisao = true;
        }

        private void btnIgual_Click (object sender, EventArgs e) {
            resultado = true;

            txtOperacao.Text += "= ";

            if (adicao) {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) + calculo);

                txtOperacao.Text += txtResultado.Text;
            }

            else if (subtracao) {
                txtResultado.Text = Convert.ToString(calculo - Convert.ToDecimal(txtResultado.Text));

                txtOperacao.Text += txtResultado.Text;
            }
            else if (multipicacao) {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) * calculo);

                txtOperacao.Text += txtResultado.Text;
            }
            else if (divisao) {
                txtResultado.Text = Convert.ToString(calculo / Convert.ToDecimal(txtResultado.Text));

                txtOperacao.Text = txtResultado.Text;
            }
        }

        private void btnLimpa_Click (object sender, EventArgs e) {
            txtResultado.Text = "";

            txtOperacao.Text = "";
        }

        private void btnAC_Click (object sender, EventArgs e) {
            try {
                string delete = txtResultado.Text;

                delete = delete.Remove(delete.Length - 1);

                txtResultado.Text = delete;
                txtOperacao.Text = delete;
            }

            catch (Exception) { }
        }
    }
}