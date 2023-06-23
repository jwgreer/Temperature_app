namespace Tempreture_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float input_celsius;

        public float input_fahrenheit;




        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fahrenheit.Text))
            {
                fahrenheit.Text = "0";
            }

            input_fahrenheit = float.Parse(fahrenheit.Text);

            input_celsius = (input_fahrenheit - 32) * 5 / 9;

            celsius.Text = input_celsius.ToString();
        }

        private void C_to_F_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(celsius.Text))
            {
                celsius.Text = "0";
            }

            input_celsius = float.Parse(celsius.Text);

            input_fahrenheit = (input_celsius * 9 / 5) + 32;

            fahrenheit.Text = input_fahrenheit.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            celsius.Clear();
            fahrenheit.Clear();

        }

        private void K_to_F_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fahrenheit.Text))
            {
                fahrenheit.Text = "0";
            }

            input_fahrenheit = float.Parse(fahrenheit.Text);

            input_celsius = (input_fahrenheit - 32) * 5.0f / 9.0f + 273;

            celsius.Text = input_celsius.ToString();

        }
    }
}