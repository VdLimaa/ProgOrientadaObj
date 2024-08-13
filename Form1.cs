using PRJ_Figuras;

namespace WinFormsApp1
{
    public partial class PRJ_Figuras : Form
    {
        public PRJ_Figuras()
        {
            InitializeComponent();
        }

        private void PRJ_Figuras_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LadoA_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            lbMensagem.Text = String.Empty;
            labelResultado.Text = $"Área:";
            label2Resultado.Text = $"Perímetro:";
            label3Resultado.Text = $"Diagonal:";

            float ladoA, ladoB;

            if (!float.TryParse(textBoxLadoA.Text, out ladoA))
            {
                lbMensagem.Text = "Lado A com erro de digitação";
                return;
            }
            if (!float.TryParse(textBoxLadoB.Text, out ladoB))
            {
                lbMensagem.Text = "Lado B com erro de digitação";
                return;

            }

           // Retangulo ret = new Retangulo(ladoA, ladoB);
           TrianguloRetangulo ret = new TrianguloRetangulo(ladoA, ladoB);
            labelResultado.Text = $"Área: {ret.calculaArea()}";
            label2Resultado.Text = $"Perímetro: {ret.calculaPerimetro()}";
            label3Resultado.Text = $"Hipotenusa: {ret.catetoC()}";
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
