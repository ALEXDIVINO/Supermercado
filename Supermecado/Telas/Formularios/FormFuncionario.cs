using Supermecado.Controller;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Supermecado.Telas
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        //Permite fazer captura de tela, para pode arrastar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void placeHolder(MaskedTextBox input, string text)
        {
            if (input.Text == "")
            {
                //Coloca os itens nos inputs
                input.Text = text;

                //Muda a cor do texto
                input.ForeColor = Color.Gray;
            }
        }

        private void removePlaceHolder(MaskedTextBox input, string text)
        {
            if (input.Text == text)
            {
                input.Text = "";
                input.ForeColor = Color.Black;
            }
        }

        private void Formulario_Fucionarios_Load(object sender, EventArgs e)
        {
            placeHolder(maskedTextBoxNome, "Nome");
            placeHolder(maskedTextBoxCpf, "CPF");
            placeHolder(maskedTextBoxRg, "Rg");
            placeHolder(maskedTextBoxEndereco, "Endereço");
            placeHolder(maskedTextBoxCep, "Cep");
            placeHolder(maskedTextBoxEstado, "Estado");
            placeHolder(maskedTextBoxCidade, "Cidade");
            placeHolder(maskedTextBoxEmail, "Email");
            placeHolder(maskedTextBoxTelefone, "Telefone");
            placeHolder(maskedTextBoxDataNascimento, "Data nascimento");
            placeHolder(maskedTextBoxGenero, "Genero");
            placeHolder(maskedTextBoxCor, "Cor");
            placeHolder(maskedTextBoxCargo, "Cargo");
            placeHolder(maskedTextBoxPis, "Pis");
            placeHolder(maskedTextBoxSalario, "Salário");
            placeHolder(maskedTextBoxCargaHoraria, "Carga Horária");
            placeHolder(maskedTextBoxSetor, "Setor");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Application.Exit();//Fecha a janela de execussão
        }

        private void panelNav_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Nome
        private void maskedTextBoxNome_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxNome, "Nome");
        }

        private void maskedTextBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxNome, "Nome");
        }

        private void maskedTextBoxNome_Leave(object sender, EventArgs e)
        {
            placeHolder(maskedTextBoxNome, "Nome");
            /*if (maskedTextBoxNome.Text == "Nome" || maskedTextBoxNome.Text.Length <= 2)
            {
                maskedTextBoxNome.ForeColor = Color.DarkRed;
            }*/
        }

        //Cpf
        private void maskedTextBoxCpf_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxCpf, "CPF");
        }

        private void maskedTextBoxCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxCpf, "CPF");
            if(maskedTextBoxCpf.Mask == "")
            {
                maskedTextBoxCpf.Mask = "000.000.000 - 00";
            }
        }

        private void maskedTextBoxCpf_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxCpf.Text == "   ,   ,    - ") maskedTextBoxCpf.Mask = "";
            placeHolder(maskedTextBoxCpf, "CPF");
        }

        //Rg
        private void maskedTextBoxRg_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxRg, "Rg");
        }

        private void maskedTextBoxRg_Leave(object sender, EventArgs e)
        {
            placeHolder(maskedTextBoxRg, "Rg");
        }

        private void maskedTextBoxRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxRg, "Rg");
        }

        //Cep
        private void maskedTextBoxCep_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxCep, "Cep");
        }

        private void maskedTextBoxCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxCep, "Cep");
            maskedTextBoxCep.Mask = "00.000-000";
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxCep.Text == "  ,   -") maskedTextBoxCep.Mask = "";
            placeHolder(maskedTextBoxCep, "Cep");
        }

        //Endereco
        private void maskedTextBoxEndereco_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxEndereco, "Endereço");
        }

        private void maskedTextBoxEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxEndereco, "Endereço");
        }

        private void maskedTextBoxEndereco_Leave(object sender, EventArgs e)
        {
            placeHolder(maskedTextBoxEndereco, "Endereço");
        }

        //Estado
        private void maskedTextBoxEstado_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxEstado, "Estado");
        }

        private void maskedTextBoxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxEstado, "Estado");
            maskedTextBoxEstado.Mask = "aa";
        }

        private void maskedTextBoxEstado_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxEstado.Text == "") maskedTextBoxEstado.Mask = "";
            placeHolder(maskedTextBoxEstado, "Estado");
        }

        //Cidade
        private void maskedTextBoxCidade_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxCidade, "Cidade");
        }

        private void maskedTextBoxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxCidade, "Cidade");
        }

        private void maskedTextBoxCidade_Leave(object sender, EventArgs e)
        {
            placeHolder(maskedTextBoxCidade, "Cidade");
        }

        //Email
        private void maskedTextBoxEmail_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxEmail, "Email");
        }

        private void maskedTextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxEmail, "Email");
        }

        private void maskedTextBoxEmail_Leave(object sender, EventArgs e)
        {
            placeHolder(maskedTextBoxEmail, "Email");
        }

        //Telefone
        private void maskedTextBoxTelefone_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxTelefone, "Telefone");
        }

        private void maskedTextBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxTelefone, "Telefone");
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
        }

        private void maskedTextBoxTelefone_Leave(object sender, EventArgs e)
        {
           if(maskedTextBoxTelefone.Text == "(  )      -") maskedTextBoxTelefone.Mask = "";
            placeHolder(maskedTextBoxTelefone, "Telefone");
        }

        //Nascimento
        private void maskedTextBoxDataNascimento_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxDataNascimento, "Data nascimento");
        }

        private void maskedTextBoxDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxDataNascimento, "Data nascimento");
            maskedTextBoxDataNascimento.Mask = "00/00/0000";
        }

        private void maskedTextBoxDataNascimento_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDataNascimento.Text == "  /  /") maskedTextBoxDataNascimento.Mask = "";
            placeHolder(maskedTextBoxDataNascimento, "Data nascimento");
        }

        //Genero
        private void maskedTextBoxGenero_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxGenero, "Genero");
        }

        private void maskedTextBoxGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxGenero, "Genero");
        }

        private void maskedTextBoxGenero_Leave(object sender, EventArgs e)
        {
            placeHolder(maskedTextBoxGenero, "Genero");
        }

        //Cor
        private void maskedTextBoxCor_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxCor, "Cor");
        }

        private void maskedTextBoxCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxCor, "Cor");
        }

        private void maskedTextBoxCor_Leave(object sender, EventArgs e)
        {
            placeHolder(maskedTextBoxCor, "Cor");
        }

        //Setor
        private void maskedTextBoxSetor_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxSetor, "Setor");
        }

        private void maskedTextBoxSetor_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxSetor, "Setor");
        }

        private void maskedTextBoxSetor_Leave(object sender, EventArgs e)
        {
            placeHolder(maskedTextBoxSetor, "Setor");
        }

        //Cargo
        private void maskedTextBoxCargo_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxCargo, "Cargo");
        }

        private void maskedTextBoxCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxCargo, "Cargo");
        }

        private void maskedTextBoxCargo_Leave(object sender, EventArgs e)
        {
            placeHolder(maskedTextBoxCargo, "Cargo");
        }

        //Carga Horária
        private void maskedTextBoxCargaHoraria_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxCargaHoraria, "Carga Horária");
        }

        private void maskedTextBoxCargaHoraria_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxCargaHoraria, "Carga Horária");
        }

        private void maskedTextBoxCargaHoraria_Leave(object sender, EventArgs e)
        {
            placeHolder(maskedTextBoxCargaHoraria, "Carga Horária");
        }

        //Pis
        private void maskedTextBoxPis_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxPis, "Pis");
        }

        private void maskedTextBoxPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxPis, "Pis");
            maskedTextBoxPis.Mask = "000.00000.00-0";
        }

        private void maskedTextBoxPis_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxPis.Text == "   ,     ,  -") maskedTextBoxPis.Mask = "";
            placeHolder(maskedTextBoxPis, "Pis");
        }

        //Salário
        private void maskedTextBoxSalario_Click(object sender, EventArgs e)
        {
            removePlaceHolder(maskedTextBoxSalario, "Salário");
        }

        private void maskedTextBoxSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            removePlaceHolder(maskedTextBoxSalario, "Salário");
        }

        private void maskedTextBoxSalario_Leave(object sender, EventArgs e)
        {
            placeHolder(maskedTextBoxSalario, "Salário");
        }

        //Button Cadastro
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //TODO: implementar verificação de campos
            if (FuncionarioController.Cadastrar(maskedTextBoxNome.Text, maskedTextBoxCpf.Text, maskedTextBoxDataNascimento.Text))
                this.Close();
        }
    }
}
