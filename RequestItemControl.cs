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
    public partial class RequestItemControl : UserControl
    {
        public event EventHandler Edited;
        public event EventHandler Deleted;
        Request request;
        public Request Request
        {
            get
            {
                return request;
            }
            set
            {
                request = value;
                tbID.Text = value.ID.ToString();
                dtCreated.Value = value.Created;
                tbDefect.Text = value.Defect;
                tbClient.Text = value.Client;
                tbStatus.Text = value.Status;
            }
        }
        public RequestItemControl()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Deleted.Invoke(this, new EventArgs());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var dialog = new RequestEditDialog()
            {
                Request = request,
            };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            Request = dialog.Request;
            Edited.Invoke(this, new EventArgs());
        }
    }
}