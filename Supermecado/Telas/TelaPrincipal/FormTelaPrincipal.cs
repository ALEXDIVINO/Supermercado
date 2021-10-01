using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermecado.Telas
{
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();
        }

        //Permite fazer captura de tela, para pode arrastar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();//Fecha a janela de execussão
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormTelaPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide(); //Esconde a tela atual
            FormLoad fM = new FormLoad(); //Instancia do objeto FormLoad
            fM.Show(); //Mostra o objeto instanciado
            Thread.Sleep(3000); //"Dormir", durante 3s mostra a tela de load e escode a principal
            fM.Hide(); //Esconde o form load
            this.Show(); //Mostra o a tela principal
        }


        private void buttonMaxMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.buttonMaxMin.Image = System.Drawing.Image.FromFile(@"\\Alex\alex divino\Supermecado\Supermecado\public\imagens\minimized.png");
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.buttonMaxMin.Image = System.Drawing.Image.FromFile(@"\\Alex\alex divino\Supermecado\Supermecado\public\imagens\maximazed.png");
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }
        }


        private void buttonGerebciarFuncionario_Click(object sender, EventArgs e)
        {
            new FormFuncionario().Show();
        }

        private void panelNav_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
