using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class frmMediaAluno : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
              int left,
              int top,
              int right,
              int bottom,
              int width,
              int height
          );
        public frmMediaAluno()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double N1, N2, N3, media;

            N1 = double.Parse(txtAtividade1.Text);
            N2 = double.Parse(txtAtividade2.Text);
            N3 = double.Parse(txtAtividade3.Text);

            media = (N1 + N2 + N3) / 3;

            txtMedia.Text = (" a média do aluno é: " + media);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAtividade1.Clear();
            txtAtividade2.Clear();
            txtAtividade3.Clear();
            txtMedia.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
