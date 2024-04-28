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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Redraw();
        }
        void Redraw()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var i in Data.Requests)
            {
                var c = new RequestItemControl() {
                    Request = i,
                };
                c.Edited += C_Edited;
                c.Deleted += C_Deleted;
                flowLayoutPanel1.Controls.Add(c);
            }
            lbInWork.Text = Data.Requests.Count(obj => obj.Status == "В работе").ToString();
            lbDone.Text = Data.Requests.Count(obj => obj.Status == "Выполнено").ToString();
        }

        private void C_Deleted(object? sender, EventArgs e)
        {
            var req = ((RequestItemControl)sender).Request;
            Data.Requests.RemoveAll(obj => obj.ID == req.ID);
            Redraw();
        }

        private void C_Edited(object? sender, EventArgs e)
        {
            var req = ((RequestItemControl)sender).Request;
            Data.Requests[Data.Requests.FindIndex(obj => obj.ID == req.ID)] = req;
            Redraw();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new RequestDialog() {
                Request = new Request()
                {
                    ID = Data.Requests.Select(obj => obj.ID).DefaultIfEmpty(0).Max() + 1,
                    Created = DateTime.Now,
                }
            };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            Data.Requests.Add(dialog.Request);
            Redraw();
        }
    }
}