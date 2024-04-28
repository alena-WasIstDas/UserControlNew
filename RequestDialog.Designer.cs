namespace Lab5UserControl
{
    partial class RequestDialog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dtCreated = new DateTimePicker();
            label2 = new Label();
            tbID = new TextBox();
            cbStatus = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            tbEquipment = new TextBox();
            tbDefect = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbDescription = new TextBox();
            button1 = new Button();
            label8 = new Label();
            tbClient = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 52);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
            label1.TabIndex = 0;
            label1.Text = "Номер заявки";
            // 
            // dtCreated
            // 
            dtCreated.Location = new Point(162, 114);
            dtCreated.Name = "dtCreated";
            dtCreated.Size = new Size(170, 27);
            dtCreated.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 119);
            label2.Name = "label2";
            label2.Size = new Size(152, 24);
            label2.TabIndex = 2;
            label2.Text = "Дата добавления";
            // 
            // tbID
            // 
            tbID.Enabled = false;
            tbID.Location = new Point(132, 49);
            tbID.Name = "tbID";
            tbID.Size = new Size(98, 27);
            tbID.TabIndex = 3;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(131, 187);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(170, 28);
            cbStatus.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(4, 190);
            label3.Name = "label3";
            label3.Size = new Size(121, 24);
            label3.TabIndex = 5;
            label3.Text = "Статус заявки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(352, 52);
            label4.Name = "label4";
            label4.Size = new Size(130, 24);
            label4.TabIndex = 6;
            label4.Text = "Оборудование";
            // 
            // tbEquipment
            // 
            tbEquipment.Location = new Point(499, 49);
            tbEquipment.Multiline = true;
            tbEquipment.Name = "tbEquipment";
            tbEquipment.Size = new Size(295, 57);
            tbEquipment.TabIndex = 7;
            // 
            // tbDefect
            // 
            tbDefect.Location = new Point(499, 112);
            tbDefect.Multiline = true;
            tbDefect.Name = "tbDefect";
            tbDefect.Size = new Size(295, 56);
            tbDefect.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(352, 112);
            label5.Name = "label5";
            label5.Size = new Size(141, 48);
            label5.TabIndex = 9;
            label5.Text = "Тип\r\n неисправности";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(377, 195);
            label6.Name = "label6";
            label6.Size = new Size(0, 24);
            label6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(371, 334);
            label7.Name = "label7";
            label7.Size = new Size(71, 24);
            label7.TabIndex = 12;
            label7.Text = "Клиент";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(459, 191);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(336, 122);
            tbDescription.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(73, 140, 81);
            button1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(44, 300);
            button1.Name = "button1";
            button1.Size = new Size(178, 58);
            button1.TabIndex = 14;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(352, 195);
            label8.Name = "label8";
            label8.Size = new Size(100, 48);
            label8.TabIndex = 15;
            label8.Text = "Описание \r\nпроблемы";
            // 
            // tbClient
            // 
            tbClient.Location = new Point(452, 337);
            tbClient.Name = "tbClient";
            tbClient.Size = new Size(336, 27);
            tbClient.TabIndex = 16;
            // 
            // RequestDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 382);
            Controls.Add(tbClient);
            Controls.Add(label8);
            Controls.Add(button1);
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
            Name = "RequestDialog";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtCreated;
        private Label label2;
        private TextBox tbID;
        private ComboBox cbStatus;
        private Label label3;
        private Label label4;
        private TextBox tbEquipment;
        private TextBox tbDefect;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbDescription;
        private Button button1;
        private Label label8;
        private TextBox tbClient;
    }
}
