using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.CONTROL;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Drawing.Printing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {




        
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        
        [DllImport("user32.dll")]
        private static extern bool AddClipboardFormatListener(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            AddClipboardFormatListener(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_CLIPBOARDUPDATE = 0x031D;

            if (m.Msg == WM_CLIPBOARDUPDATE)
            {
                OnClipboardChanged();
            }

            base.WndProc(ref m);
        }

        private bool autoOpenEnabled = true;

        private void OnClipboardChanged()
        {
            if (!autoOpenEnabled) return;

            string clipboardText = Clipboard.GetText();

            if (decimal.TryParse(clipboardText, out decimal priceDecimal))
            {
                int price = (int)priceDecimal;
                textBoxPrice.Texts = clipboardText;

                var screen = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(screen.Right - this.Width, screen.Top);

                this.WindowState = FormWindowState.Normal;
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.TopMost = true;
                this.BringToFront();
                this.Activate();
                this.TopMost = false;

                buttonCalc.PerformClick();
            }
        }

       
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            string input = textBoxPrice.Texts.Replace(" ", "");

            if (!int.TryParse(input, out int price) || price <= 0)
            {
                MessageBox.Show("Введите корректную положительную цену!");
                return;
            }

            int total;
            int workCost;
            int salary;

            if (price > 12000)
            {
                workCost = price;
                total = price * 2;
                salary = (int)Math.Round(workCost * 0.18);
            }
            else
            {
                workCost = CalculateWorkCost(price);
                salary = (int)Math.Round(workCost * 0.18);
                total = price + workCost;
            }

            labelWorkCost.Text = $"Стоимость работы: {workCost} ₽";
            labelSalary.Text = $"Зарплата с работы: {salary} ₽";
            labelTotal.Text = $"Итоговая сумма:";
            label4.Text = $"{total} ₽";
        }

        // === РАСЧЕТ СТОИМОСТИ РАБОТ ===
        private int CalculateWorkCost(int price)
        {
            if (price <= 000) return 0000 ; //сюда писать. первое цену запчасти. второе цену работы на стоимость данной запчасти
            else if (price <= 10000) return 200000; //сюда писать. первое цену запчасти. второе цену работы на стоимость данной запчасти к примеру
            else if (price <= 0000) return 0000; // цена диспа 1500р дальше вы пишите цену работы добавлять строки можно бесконечно и сделать максимально точную ценну

            return 0;
        }

        private void textBoxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonCalc.PerformClick();
            }
        }

        private void Form1_Shown(object sender, EventArgs e) => TryInsertClipboardPrice();
        private void Form1_Activated(object sender, EventArgs e) => TryInsertClipboardPrice();

        private void TryInsertClipboardPrice()
        {
            string clipboardText = Clipboard.GetText();
            if (decimal.TryParse(clipboardText, out decimal priceDecimal))
            {
                textBoxPrice.Texts = clipboardText;
            }
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            autoOpenEnabled = checkBoxAutoOpen.Checked;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
