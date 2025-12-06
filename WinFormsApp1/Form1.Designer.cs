namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelTotal = new Label();
            labelWorkCost = new Label();
            labelSalary = new Label();
            label1 = new Label();
            buttonCalc = new WinFormsApp1.CONTROL.RJButton();
            textBoxPrice = new WinFormsApp1.CONTROL.RJTextbox();
            closeButton = new WinFormsApp1.CONTROL.RJButton();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            checkBoxAutoOpen = new WinFormsApp1.CONTROL.RJToggleButton();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.FromArgb(3, 71, 136);
            labelTotal.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTotal.ForeColor = Color.White;
            labelTotal.Location = new Point(14, 15);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(213, 36);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "Итоговая сумма";
            // 
            // labelWorkCost
            // 
            labelWorkCost.AutoSize = true;
            labelWorkCost.BackColor = Color.FromArgb(3, 71, 136);
            labelWorkCost.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWorkCost.ForeColor = Color.White;
            labelWorkCost.Location = new Point(14, 111);
            labelWorkCost.Name = "labelWorkCost";
            labelWorkCost.Size = new Size(157, 23);
            labelWorkCost.TabIndex = 2;
            labelWorkCost.Text = "Стоимость работы";
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.BackColor = Color.FromArgb(3, 71, 136);
            labelSalary.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSalary.ForeColor = Color.White;
            labelSalary.Location = new Point(14, 146);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(158, 23);
            labelSalary.TabIndex = 5;
            labelSalary.Text = "Зарплата с работы";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(12, 91, 185);
            label1.Location = new Point(24, 51);
            label1.Name = "label1";
            label1.Size = new Size(289, 66);
            label1.TabIndex = 8;
            label1.Text = "Калькулятор стоимости \r\nремонта смартфона";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCalc
            // 
            buttonCalc.BackColor = Color.FromArgb(254, 193, 42);
            buttonCalc.BackgroundColor = Color.FromArgb(254, 193, 42);
            buttonCalc.BorderColor = Color.PaleVioletRed;
            buttonCalc.BorderRadius = 13;
            buttonCalc.BorderSize = 0;
            buttonCalc.FlatAppearance.BorderSize = 0;
            buttonCalc.FlatStyle = FlatStyle.Flat;
            buttonCalc.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCalc.ForeColor = Color.Black;
            buttonCalc.Location = new Point(20, 179);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(291, 40);
            buttonCalc.TabIndex = 9;
            buttonCalc.Text = "Рассчитать стоимость";
            buttonCalc.TextColor = Color.Black;
            buttonCalc.UseVisualStyleBackColor = false;
            buttonCalc.Click += buttonCalc_Click;
            buttonCalc.KeyDown += textBoxPrice_KeyDown;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.FromArgb(245, 245, 247);
            textBoxPrice.BorderColor = Color.FromArgb(213, 219, 228);
            textBoxPrice.BorderFocusColor = Color.HotPink;
            textBoxPrice.BorderRadius = 13;
            textBoxPrice.BorderSize = 1;
            textBoxPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPrice.Location = new Point(20, 133);
            textBoxPrice.Multiline = false;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Padding = new Padding(10, 7, 10, 7);
            textBoxPrice.PasswordChar = false;
            textBoxPrice.PlaceholderColor = Color.DarkGray;
            textBoxPrice.PlaceholderText = "";
            textBoxPrice.Size = new Size(291, 40);
            textBoxPrice.TabIndex = 10;
            textBoxPrice.Texts = "";
            textBoxPrice.UnderlinedStyle = false;
            textBoxPrice.KeyDown += textBoxPrice_KeyDown;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.White;
            closeButton.BackgroundColor = Color.White;
            closeButton.BackgroundImage = (Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.BorderColor = Color.PaleVioletRed;
            closeButton.BorderRadius = 0;
            closeButton.BorderSize = 0;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(288, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(39, 40);
            closeButton.TabIndex = 13;
            closeButton.TextColor = Color.White;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 71, 136);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelTotal);
            panel1.Controls.Add(checkBoxAutoOpen);
            panel1.Controls.Add(labelWorkCost);
            panel1.Controls.Add(labelSalary);
            panel1.Location = new Point(20, 238);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 246);
            panel1.TabIndex = 14;
            panel1.MouseDown += Form1_MouseDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(14, 87);
            label5.Name = "label5";
            label5.Size = new Size(193, 14);
            label5.TabIndex = 18;
            label5.Text = "!! В сумму заложено 200р на такси !!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(3, 71, 136);
            label4.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 51);
            label4.Name = "label4";
            label4.Size = new Size(30, 36);
            label4.TabIndex = 17;
            label4.Text = "₽";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 182);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 16;
            label2.Text = "Авто открытие при копировании";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxAutoOpen
            // 
            checkBoxAutoOpen.AutoSize = true;
            checkBoxAutoOpen.Checked = true;
            checkBoxAutoOpen.CheckState = CheckState.Checked;
            checkBoxAutoOpen.Location = new Point(14, 182);
            checkBoxAutoOpen.MinimumSize = new Size(45, 22);
            checkBoxAutoOpen.Name = "checkBoxAutoOpen";
            checkBoxAutoOpen.OffBackColor = Color.FromArgb(213, 219, 228);
            checkBoxAutoOpen.OffToggleColor = Color.FromArgb(3, 71, 136);
            checkBoxAutoOpen.OnBackColor = Color.FromArgb(254, 193, 42);
            checkBoxAutoOpen.OnToggleColor = Color.FromArgb(3, 71, 136);
            checkBoxAutoOpen.Size = new Size(45, 22);
            checkBoxAutoOpen.TabIndex = 15;
            checkBoxAutoOpen.UseVisualStyleBackColor = true;
            checkBoxAutoOpen.CheckedChanged += rjToggleButton1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxPrice);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(buttonCalc);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 447);
            panel2.TabIndex = 15;
            panel2.MouseDown += Form1_MouseDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(3, 34);
            label7.Name = "label7";
            label7.Size = new Size(87, 17);
            label7.TabIndex = 17;
            label7.Text = "by @tipmanov";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(254, 193, 42);
            label6.Location = new Point(3, 15);
            label6.Name = "label6";
            label6.Size = new Size(28, 16);
            label6.TabIndex = 16;
            label6.Text = "V 1.4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 15;
            label3.Text = "Версия от 06.12.25";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 71, 136);
            ClientSize = new Size(340, 459);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelTotal;
        private Label labelWorkCost;
        private Label labelSalary;
        private Label label1;
        private CONTROL.RJButton buttonCalc;
        private CONTROL.RJTextbox textBoxPrice;
        private CONTROL.RJButton closeButton;
        private Panel panel1;
        private Panel panel2;
        private CONTROL.RJToggleButton checkBoxAutoOpen;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
