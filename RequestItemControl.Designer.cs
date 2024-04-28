namespace Lab5UserControl
{
    partial class RequestItemControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbID = new TextBox();
            tbClient = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtCreated = new DateTimePicker();
            tbDefect = new TextBox();
            label4 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            label5 = new Label();
            tbStatus = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(31, 24);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // tbID
            // 
            tbID.Enabled = false;
            tbID.Location = new Point(54, 16);
            tbID.Name = "tbID";
            tbID.Size = new Size(125, 27);
            tbID.TabIndex = 1;
            // 
            // tbClient
            // 
            tbClient.Enabled = false;
            tbClient.Location = new Point(590, 6);
            tbClient.Multiline = true;
            tbClient.Name = "tbClient";
            tbClient.Size = new Size(176, 55);
            tbClient.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(515, 20);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 2;
            label2.Text = "Клиент";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 69);
            label3.Name = "label3";
            label3.Size = new Size(49, 24);
            label3.TabIndex = 4;
            label3.Text = "Дата";
            // 
            // dtCreated
            // 
            dtCreated.CalendarFont = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtCreated.Enabled = false;
            dtCreated.Format = DateTimePickerFormat.Short;
            dtCreated.Location = new Point(54, 66);
            dtCreated.Name = "dtCreated";
            dtCreated.Size = new Size(125, 27);
            dtCreated.TabIndex = 5;
            // 
            // tbDefect
            // 
            tbDefect.Enabled = false;
            tbDefect.Location = new Point(293, 11);
            tbDefect.Multiline = true;
            tbDefect.Name = "tbDefect";
            tbDefect.Size = new Size(203, 83);
            tbDefect.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(195, 37);
            label4.Name = "label4";
            label4.Size = new Size(95, 24);
            label4.TabIndex = 6;
            label4.Text = "Проблема";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(73, 140, 81);
            btnEdit.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(772, 17);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(48, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "✎";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(73, 140, 81);
            btnDelete.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(772, 61);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(47, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "✗";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(521, 68);
            label5.Name = "label5";
            label5.Size = new Size(63, 24);
            label5.TabIndex = 10;
            label5.Text = "Статус";
            // 
            // tbStatus
            // 
            tbStatus.Enabled = false;
            tbStatus.Location = new Point(590, 70);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(176, 27);
            tbStatus.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 106);
            panel1.TabIndex = 12;
            // 
            // RequestItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbStatus);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(tbDefect);
            Controls.Add(label4);
            Controls.Add(dtCreated);
            Controls.Add(label3);
            Controls.Add(tbClient);
            Controls.Add(label2);
            Controls.Add(tbID);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "RequestItemControl";
            Size = new Size(839, 106);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbID;
        private TextBox tbClient;
        private Label label2;
        private Label label3;
        private DateTimePicker dtCreated;
        private TextBox tbDefect;
        private Label label4;
        private Button btnEdit;
        private Button btnDelete;
        private Label label5;
        private TextBox tbStatus;
        private Panel panel1;
    }
}
