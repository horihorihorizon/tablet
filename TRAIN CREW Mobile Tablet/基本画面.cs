namespace test
{
    public partial class ‹N“®‰æ–Ê : Form
    {
        ControlScaler scaler;

        public ‹N“®‰æ–Ê()
        {
            InitializeComponent();
            scaler = new ControlScaler();
            scaler.CaptureInitialState(this);
        }

        private void M_Click(object sender, EventArgs e)
        {
            this.Hide();
            var M = new M();
            M.ShowDialog();
            this.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.TopMost == false)
            {
                this.TopMost = true;
                button3.BackColor = Color.Yellow;
            }
            else
            {
                this.TopMost = false;
                button3.BackColor = Color.White;
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            this.Hide();
            var One = new One();
            One.ShowDialog();
            this.Show();
        }
        private void C_Click(object sender, EventArgs e)
        {
            this.Hide();
            var C = new C();
            C.ShowDialog();
            this.Show();
        }

        private void ‹N“®‰æ–Ê_Resize(object sender, EventArgs e)
        {
            scaler?.ScaleToCurrentSize(this, controlScalerProvider1);
        }
    }
}