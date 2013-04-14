using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CronometroTarefa
{
    public partial class frmMain : Form
    {

        Timer t = null;
        TimeSpan final;
        TimeSpan inicial;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                if (Convert.ToInt32(b.Tag) == 1)
                {
                    t.Stop();
                    b.Tag = 0;
                }
                else
                {
                    TimeSpan decorrido = final - DateTime.Now.TimeOfDay;
                    if (inicial.Ticks == 0)
                        inicial = DateTime.Now.TimeOfDay;
                    final =
                        inicial +
                        Convert.ToDateTime(txTempo.Text).TimeOfDay;
                    t.Start();
                    b.Tag = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Tick += (a, b) =>
            {
                if (DateTime.Now.TimeOfDay >= final)
                {
                    ZeraCronometro();
                    MessageBox.Show("Tempo de tarefa finalizado!");
                }
                else
                {
                    TimeSpan tempo = final - DateTime.Now.TimeOfDay;
                    lbTempo.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:000}", new object[] {
                            tempo.Hours, tempo.Minutes, tempo.Seconds, tempo.Milliseconds});
                    lbTempo.Refresh();
                }
            };
        }

        private void ZeraCronometro()
        {
            t.Stop();
            lbTempo.Text = "00:00:00:000";
            inicial = TimeSpan.Zero;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ZeraCronometro();
        }
    }
}
