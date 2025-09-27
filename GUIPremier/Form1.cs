namespace GUIPremier
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Premier> premiers;

        public Form1()
        {
            InitializeComponent();
            InitializeGui();
            listPremiers.SelectedValueChanged += lstPremiers_SelectedValueChanged;
            picPremier.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void InitializeGui()
        {
            premiers = new Dictionary<string, Premier>();

            List<Premier> premierList = Premier.GetPremiers();

            foreach (Premier p in premierList)
            {
                string key = p.GenerateKey();
                premiers[key] = p;
            }

            List<string> keys = new List<string>(premiers.Keys);
            listPremiers.DataSource = keys;
        }

        private void UpdateGui(string key)
        {
            if (premiers.ContainsKey(key))
            {
                Premier p = premiers[key];

                lblName.Text = $"Name: {p.Name}";
                lblLife.Text = $"Life: {p.Life}";
                lblStartEnd.Text = $"Term: {p.Term}";

                string imagePath = Path.Combine("images", key + ".jpg");
                if (File.Exists(imagePath))
                {
                    picPremier.Image = Image.FromFile(imagePath);
                }
                else
                {
                    picPremier.Image = null;
                    MessageBox.Show($"Image file not found: {imagePath}", "Image Error");
                }
            }
        }

        private void lstPremiers_SelectedValueChanged(object sender, EventArgs e)
        {
            string key = listPremiers.SelectedValue.ToString();
            UpdateGui(key);
        }
    
    }
}
