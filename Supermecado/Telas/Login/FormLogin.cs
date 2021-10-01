using Supermecado.Controller;
using System;

using System.Drawing;
using System.Windows.Forms;


namespace Supermecado.Telas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void placeHolder(TextBox input, string text)
        {
            if(input.Text == "") 
            {
                //Coloca os itens nos inputs
                input.Text = text;

                //Muda a cor do texto
                input.ForeColor = Color.Gray;

                //Se for o input de senha os caracteres devem poder ser visualizados
                if (text == "Senha") input.PasswordChar = '\0';
            }
        }

        private void removePlaceHolder(TextBox input, string text)
        {
            if (input.Text == text)
            {
                input.Text = "";
                if (text == "Senha") input.PasswordChar = '*';
            }
        }

        private void send(object sender, KeyPressEventArgs e)
        {
            //Se o usuário apertar a tecla enter o formulário é feita uma tentativa de envio do formulário
            if (e.KeyChar == (char)13)
            {
                this.buttonLogin_Click(sender, e);
            }
        }

        private void changeColorText(TextBox input)
        {
            if (input.ForeColor != Color.Black) //Verifica se a cor está diferente de preto
                input.ForeColor = Color.Black; //Se estiver muda para preto
        }


        /**
         * Como o systema possui um numero muito grande de usuário toda vez que ele for 
         * fechado precisa fazer login novamente para poder ter acesso.
         */


        //Evento de click no botão para executar login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (LoginController.verifyLogin(textEmail.Text, textSenha.Text))
            {
                //Tira a visibilidade da label de erro
                if (labelMensageErro.Visible) labelMensageErro.Visible = false;

                this.Hide(); //Esconde a tela atual

                //Cria uma nova instancia do formulario da tela principal e chama o metodo para mostrar ele
                new FormTelaPrincipal().Show();
            }
            else
            {
                //Monstra mensagem case o email ou senha estejam incorretos
                labelMensageErro.Visible = true;
            }
        }

        //Evento de click
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();//Fecha a janela de execussão
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            placeHolder(textEmail, "Email");
            placeHolder(textSenha, "Senha");

            //Deixa a mensagem de texto não visivel
            labelMensageErro.Visible = false;
        }

        //Evento de click para o form do email
        private void textEmail_Click(object sender, EventArgs e)
        {
            removePlaceHolder(textEmail, "Email");
        }

        //evento de click para o form senha
        private void textSenha_Click(object sender, EventArgs e)
        {
            removePlaceHolder(textSenha, "Senha");
        }

        //evento para quando sair do form de email
        private void textEmail_Leave(object sender, EventArgs e)
        {
            placeHolder(textEmail, "Email");
        }

        //evento para quando sair do form senha
        private void textSenha_Leave(object sender, EventArgs e)
        {
            placeHolder(textSenha, "Senha");
        }

        //Evento para o check do checkbox
        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            //Mudar se senha pode ou não ser vista
            textSenha.PasswordChar = (checkBoxMostrarSenha.Checked || textSenha.Text == "Senha") ? '\0' : '*';
        }

        //Evento para toda vez que uma tecla for precionada no form de email
        private void textEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            changeColorText(textEmail);

            //Mandar o formulário caso o usuario aperte enter
            send(sender, e);
        }

        private void textSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            changeColorText(textSenha);

            //Verifica se o a senha pode ser exibida se o checkBox estiver selecionado
            if(textSenha.Text != "Senha" && textSenha.ForeColor != Color.Gray && checkBoxMostrarSenha.Checked)
            {
                textSenha.PasswordChar = '\0';
            }

            //Mandar o formulário caso o usuário aperte enter
            send(sender, e);

        }
        // MessageBox.Show("Testing KeyPress");
    }
}
