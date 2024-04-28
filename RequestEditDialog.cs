using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5UserControl
{
    public partial class RequestEditDialog : Form
    {
        public RequestEditDialog()
        {
            InitializeComponent();
            cbStatus.DataSource = Request.Statuses;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
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
                r.Comment = tbComment.Text;
                r.Master = tbMaster.Text;
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
                tbComment.Text = value.Comment;
                tbMaster.Text = value.Master;
            }
        }
    }
}