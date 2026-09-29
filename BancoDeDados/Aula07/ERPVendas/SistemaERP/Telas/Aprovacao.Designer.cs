namespace SistemaERP.Telas
{
    partial class Aprovacao
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(540, 202);
            dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.pasta__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(613, 320);
            button2.Name = "button2";
            button2.Size = new Size(113, 41);
            button2.TabIndex = 1;
            button2.Text = "Reprovar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.aprovado__1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(613, 252);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 2;
            button1.Text = "Aprovar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(189, 56);
            label1.Name = "label1";
            label1.Size = new Size(424, 54);
            label1.TabIndex = 3;
            label1.Text = "Aprovação de usuários";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(638, 100);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Acesso normal";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(638, 146);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Admin";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Aprovacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Name = "Aprovacao";
            Text = "Aprovacao";
            Load += Aprovacao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}