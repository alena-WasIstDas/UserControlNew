namespace Lab5UserControl
{
    public partial class RequestDialog : Form
    {
        public RequestDialog()
        {
            InitializeComponent();
            cbStatus.DataSource = Request.Statuses;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
        }
        public Request Request
        {
            get
            {
                var r = new Request();
                r.ID = int.Parse(tbID.Text);
                r.Created = dtCreated.Value;
                r.Equipment = tbEquipment.Text;
                r.Defect = tbDefect.Text;
                r.Description = tbDescription.Text;
                r.Client = tbClient.Text;
                r.Status = (string)cbStatus.SelectedItem;
                return r;
            }
            set
            {
                tbID.Text = value.ID.ToString();
                dtCreated.Value = value.Created;
                tbEquipment.Text = value.Equipment;
                tbDefect.Text = value.Defect;
                tbDescription.Text = value.Description;
                tbClient.Text = value.Client;   
                cbStatus.SelectedItem = value.Status;
            }
        }
    }
}
