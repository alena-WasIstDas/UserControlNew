namespace Lab5UserControl
{
    partial class RequestEditDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbClient = new TextBox();
            label8 = new Label();
            btnEdit = new Button();
            tbDescription = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tbDefect = new TextBox();
            tbEquipment = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cbStatus = new ComboBox();
            tbID = new TextBox();
            label2 = new Label();
            dtCreated = new DateTimePicker();
            label1 = new Label();
            tbMaster = new TextBox();
            label9 = new Label();
            label10 = new Label();
            tbComment = new TextBox();
            SuspendLayout();
            // 
            // tbClient
            // 
            tbClient.Enabled = false;
            tbClient.Location = new Point(452, 313);
            tbClient.Name = "tbClient";
            tbClient.Size = new Size(336, 27);
            tbClient.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(371, 171);
            label8.Name = "label8";
            label8.Size = new Size(100, 48);
            label8.TabIndex = 31;
            label8.Text = "Описание \r\nпроблемы";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(73, 140, 81);
            btnEdit.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(535, 380);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(178, 58);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // tbDescription
            // 
            tbDescription.Enabled = false;
            tbDescription.Location = new Point(493, 167);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(296, 122);
            tbDescription.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(371, 310);
            label7.Name = "label7";
            label7.Size = new Size(71, 24);
            label7.TabIndex = 28;
            label7.Text = "Клиент";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(371, 171);
            label6.Name = "label6";
            label6.Size = new Size(0, 24);
            label6.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(346, 88);
            label5.Name = "label5";
            label5.Size = new Size(141, 48);
            label5.TabIndex = 26;
            label5.Text = "Тип\r\n неисправности";
            // 
            // tbDefect
            // 
            tbDefect.Enabled = false;
            tbDefect.Location = new Point(493, 88);
            tbDefect.Multiline = true;
            tbDefect.Name = "tbDefect";
            tbDefect.Size = new Size(295, 56);
            tbDefect.TabIndex = 25;
            // 
            // tbEquipment
            // 
            tbEquipment.Enabled = false;
            tbEquipment.Location = new Point(493, 25);
            tbEquipment.Multiline = true;
            tbEquipment.Name = "tbEquipment";
            tbEquipment.Size = new Size(295, 57);
            tbEquipment.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(346, 28);
            label4.Name = "label4";
            label4.Size = new Size(130, 24);
            label4.TabIndex = 23;
            label4.Text = "Оборудование";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 119);
            label3.Name = "label3";
            label3.Size = new Size(121, 24);
            label3.TabIndex = 22;
            label3.Text = "Статус заявки";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(140, 116);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(200, 28);
            cbStatus.TabIndex = 21;
            // 
            // tbID
            // 
            tbID.Enabled = false;
            tbID.Location = new Point(167, 28);
            tbID.Name = "tbID";
            tbID.Size = new Size(98, 27);
            tbID.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 75);
            label2.Name = "label2";
            label2.Size = new Size(152, 24);
            label2.TabIndex = 19;
            label2.Text = "Дата добавления";
            // 
            // dtCreated
            // 
            dtCreated.Enabled = false;
            dtCreated.Format = DateTimePickerFormat.Short;
            dtCreated.Location = new Point(167, 72);
            dtCreated.Name = "dtCreated";
            dtCreated.Size = new Size(97, 27);
            dtCreated.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
            label1.TabIndex = 17;
            label1.Text = "Номер заявки";
            // 
            // tbMaster
            // 
            tbMaster.Location = new Point(13, 192);
            tbMaster.Name = "tbMaster";
            tbMaster.Size = new Size(338, 27);
            tbMaster.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(10, 165);
            label9.Name = "label9";
            label9.Size = new Size(122, 24);
            label9.TabIndex = 33;
            label9.Text = "Исполнитель";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(4, 240);
            label10.Name = "label10";
            label10.Size = new Size(123, 24);
            label10.TabIndex = 36;
            label10.Text = "Комментарий";
            // 
            // tbComment
            // 
            tbComment.Location = new Point(126, 236);
            tbComment.Multiline = true;
            tbComment.Name = "tbComment";
            tbComment.Size = new Size(225, 169);
            tbComment.TabIndex = 35;
            // 
            // RequestEditDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(tbComment);
            Controls.Add(tbMaster);
            Controls.Add(label9);
            Controls.Add(tbClient);
            Controls.Add(label8);
            Controls.Add(btnEdit);
            Controls.Add(tbDescription);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbDefect);
            Controls.Add(tbEquipment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbStatus);
            Controls.Add(tbID);
            Controls.Add(label2);
            Controls.Add(dtCreated);
            Controls.Add(label1);
            Name = "RequestEditDialog";
            Text = "RequestEditDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbClient;
        private Label label8;
        private Button btnEdit;
        private TextBox tbDescription;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbDefect;
        private TextBox tbEquipment;
        private Label label4;
        private Label label3;
        private ComboBox cbStatus;
        private TextBox tbID;
        private Label label2;
        private DateTimePicker dtCreated;
        private Label label1;
        private TextBox tbMaster;
        private Label label9;
        private Label label10;
        private TextBox tbComment;
    }
}