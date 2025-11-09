using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseRecorderApp
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;

        private List<Point> recordedClicks = new List<Point>();
        private bool isRecording = false;
        private bool isReplaying = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.MouseClick += Form1_MouseClick;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isRecording && e.Button == MouseButtons.Left)
            {
                Point clickPos = Cursor.Position;
                recordedClicks.Add(clickPos);
                txb_kordinat.Text = $"Kaydedildi: X={clickPos.X}, Y={clickPos.Y}";
            }
        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
            recordedClicks.Clear();
            isRecording = true;
            MessageBox.Show("Kayıt başladı. Sol tıklamalar kaydedilecek.");
        }

        private void btn_durdur_Click(object sender, EventArgs e)
        {
            isRecording = false;
            MessageBox.Show("Kayıt durduruldu.");
        }

        private async void btn_tekrarla_Click(object sender, EventArgs e)
        {
            if (recordedClicks.Count == 0)
            {
                MessageBox.Show("Hiç tıklama kaydedilmemiş.");
                return;
            }

            if (!int.TryParse(txb_tekrar_sayisi.Text, out int tekrarSayisi) || tekrarSayisi <= 0)
            {
                MessageBox.Show("Geçerli bir tekrar sayısı girin.");
                return;
            }

            if (!int.TryParse(txb_tekrarlarin_arasindaki_sure_araligi.Text, out int tekrarAralik))
                tekrarAralik = 1000;

            if (!int.TryParse(txb_tekrarlama_hareket_sure_araligi.Text, out int hareketAralik))
                hareketAralik = 300;

            isReplaying = true;

            for (int i = 0; i < tekrarSayisi && isReplaying; i++)
            {
                foreach (Point point in recordedClicks)
                {
                    if (!isReplaying) break;

                    SetCursorPos(point.X, point.Y);
                    await Task.Delay(100);
                    SolTiklamaYap();
                    await Task.Delay(hareketAralik);
                }

                if (i < tekrarSayisi - 1 && isReplaying)
                    await Task.Delay(tekrarAralik);
            }

            isReplaying = false;
            MessageBox.Show("Tekrar tamamlandı.");
        }

        private void btn_tekrarlamayi_durdur_Click(object sender, EventArgs e)
        {
            isReplaying = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && isReplaying)
            {
                isReplaying = false;
                MessageBox.Show("ESC tuşuna basıldı. Tekrar durduruldu.");
            }
        }

        private void SolTiklamaYap()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
    }
}
