namespace Lab5UserControl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button btnAdd;
        private FlowLayoutPanel flowLayoutPanel1;

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
            btnAdd = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            lbInWork = new Label();
            lbDone = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(73, 140, 81);
            btnAdd.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(730, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 45);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(118, 227, 131);
            flowLayoutPanel1.Location = new Point(12, 64);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(849, 324);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 15);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 2;
            label1.Text = "В работе:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(334, 15);
            label2.Name = "label2";
            label2.Size = new Size(111, 24);
            label2.TabIndex = 3;
            label2.Text = "Выполнено:";
            // 
            // lbInWork
            // 
            lbInWork.AutoSize = true;
            lbInWork.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbInWork.Location = new Point(121, 15);
            lbInWork.Name = "lbInWork";
            lbInWork.Size = new Size(0, 24);
            lbInWork.TabIndex = 4;
            // 
            // lbDone
            // 
            lbDone.AutoSize = true;
            lbDone.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbDone.Location = new Point(441, 14);
            lbDone.Name = "lbDone";
            lbDone.Size = new Size(15, 24);
            lbDone.TabIndex = 5;
            lbDone.Text = " ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 400);
            Controls.Add(lbDone);
            Controls.Add(lbInWork);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnAdd);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbInWork;
        private Label lbDone;
    }
}