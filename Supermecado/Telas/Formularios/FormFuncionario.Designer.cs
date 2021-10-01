
namespace Supermecado.Telas
{
    partial class FormFuncionario
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.FormularioFuncionarios = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.maskedTextBoxNome = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEndereco = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEstado = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCidade = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxGenero = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCor = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCargo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCargaHoraria = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPis = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSalario = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSetor = new System.Windows.Forms.MaskedTextBox();
            this.panelNav.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(72)))));
            this.panelNav.Controls.Add(this.buttonClose);
            this.panelNav.Controls.Add(this.FormularioFuncionarios);
            this.panelNav.Location = new System.Drawing.Point(-2, -2);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(755, 34);
            this.panelNav.TabIndex = 0;
            this.panelNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(72)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 11.25F);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.Location = new System.Drawing.Point(718, 5);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(40, 39, 40, 26);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(28, 26);
            this.buttonClose.TabIndex = 17;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "X\r\n";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormularioFuncionarios
            // 
            this.FormularioFuncionarios.AutoSize = true;
            this.FormularioFuncionarios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormularioFuncionarios.ForeColor = System.Drawing.Color.White;
            this.FormularioFuncionarios.Location = new System.Drawing.Point(3, 9);
            this.FormularioFuncionarios.Name = "FormularioFuncionarios";
            this.FormularioFuncionarios.Size = new System.Drawing.Size(171, 19);
            this.FormularioFuncionarios.TabIndex = 3;
            this.FormularioFuncionarios.Text = "Formulario Funcionarios";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(72)))));
            this.panelBottom.Controls.Add(this.buttonCadastrar);
            this.panelBottom.Location = new System.Drawing.Point(-1, 375);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(754, 53);
            this.panelBottom.TabIndex = 0;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(82)))));
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.ForeColor = System.Drawing.Color.White;
            this.buttonCadastrar.Location = new System.Drawing.Point(318, 13);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(115, 28);
            this.buttonCadastrar.TabIndex = 17;
            this.buttonCadastrar.TabStop = false;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // maskedTextBoxNome
            // 
            this.maskedTextBoxNome.Location = new System.Drawing.Point(45, 71);
            this.maskedTextBoxNome.Name = "maskedTextBoxNome";
            this.maskedTextBoxNome.Size = new System.Drawing.Size(655, 22);
            this.maskedTextBoxNome.TabIndex = 0;
            this.maskedTextBoxNome.Click += new System.EventHandler(this.maskedTextBoxNome_Click);
            this.maskedTextBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxNome_KeyPress);
            this.maskedTextBoxNome.Leave += new System.EventHandler(this.maskedTextBoxNome_Leave);
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(45, 109);
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(127, 22);
            this.maskedTextBoxCpf.TabIndex = 1;
            this.maskedTextBoxCpf.Click += new System.EventHandler(this.maskedTextBoxCpf_Click);
            this.maskedTextBoxCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCpf_KeyPress);
            this.maskedTextBoxCpf.Leave += new System.EventHandler(this.maskedTextBoxCpf_Leave);
            // 
            // maskedTextBoxRg
            // 
            this.maskedTextBoxRg.Location = new System.Drawing.Point(255, 109);
            this.maskedTextBoxRg.Name = "maskedTextBoxRg";
            this.maskedTextBoxRg.Size = new System.Drawing.Size(177, 22);
            this.maskedTextBoxRg.TabIndex = 2;
            this.maskedTextBoxRg.Click += new System.EventHandler(this.maskedTextBoxRg_Click);
            this.maskedTextBoxRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxRg_KeyPress);
            this.maskedTextBoxRg.Leave += new System.EventHandler(this.maskedTextBoxRg_Leave);
            // 
            // maskedTextBoxEndereco
            // 
            this.maskedTextBoxEndereco.Location = new System.Drawing.Point(45, 150);
            this.maskedTextBoxEndereco.Name = "maskedTextBoxEndereco";
            this.maskedTextBoxEndereco.Size = new System.Drawing.Size(414, 22);
            this.maskedTextBoxEndereco.TabIndex = 4;
            this.maskedTextBoxEndereco.Click += new System.EventHandler(this.maskedTextBoxEndereco_Click);
            this.maskedTextBoxEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxEndereco_KeyPress);
            this.maskedTextBoxEndereco.Leave += new System.EventHandler(this.maskedTextBoxEndereco_Leave);
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(512, 109);
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(185, 22);
            this.maskedTextBoxCep.TabIndex = 3;
            this.maskedTextBoxCep.Click += new System.EventHandler(this.maskedTextBoxCep_Click);
            this.maskedTextBoxCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCep_KeyPress);
            this.maskedTextBoxCep.Leave += new System.EventHandler(this.maskedTextBoxCep_Leave);
            // 
            // maskedTextBoxEstado
            // 
            this.maskedTextBoxEstado.Location = new System.Drawing.Point(480, 150);
            this.maskedTextBoxEstado.Name = "maskedTextBoxEstado";
            this.maskedTextBoxEstado.Size = new System.Drawing.Size(67, 22);
            this.maskedTextBoxEstado.TabIndex = 5;
            this.maskedTextBoxEstado.Click += new System.EventHandler(this.maskedTextBoxEstado_Click);
            this.maskedTextBoxEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxEstado_KeyPress);
            this.maskedTextBoxEstado.Leave += new System.EventHandler(this.maskedTextBoxEstado_Leave);
            // 
            // maskedTextBoxCidade
            // 
            this.maskedTextBoxCidade.Location = new System.Drawing.Point(572, 150);
            this.maskedTextBoxCidade.Name = "maskedTextBoxCidade";
            this.maskedTextBoxCidade.Size = new System.Drawing.Size(125, 22);
            this.maskedTextBoxCidade.TabIndex = 6;
            this.maskedTextBoxCidade.Click += new System.EventHandler(this.maskedTextBoxCidade_Click);
            this.maskedTextBoxCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCidade_KeyPress);
            this.maskedTextBoxCidade.Leave += new System.EventHandler(this.maskedTextBoxCidade_Leave);
            // 
            // maskedTextBoxEmail
            // 
            this.maskedTextBoxEmail.Location = new System.Drawing.Point(45, 192);
            this.maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            this.maskedTextBoxEmail.Size = new System.Drawing.Size(346, 22);
            this.maskedTextBoxEmail.TabIndex = 7;
            this.maskedTextBoxEmail.Click += new System.EventHandler(this.maskedTextBoxEmail_Click);
            this.maskedTextBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxEmail_KeyPress);
            this.maskedTextBoxEmail.Leave += new System.EventHandler(this.maskedTextBoxEmail_Leave);
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(480, 192);
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(217, 22);
            this.maskedTextBoxTelefone.TabIndex = 8;
            this.maskedTextBoxTelefone.Click += new System.EventHandler(this.maskedTextBoxTelefone_Click);
            this.maskedTextBoxTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxTelefone_KeyPress);
            this.maskedTextBoxTelefone.Leave += new System.EventHandler(this.maskedTextBoxTelefone_Leave);
            // 
            // maskedTextBoxDataNascimento
            // 
            this.maskedTextBoxDataNascimento.Location = new System.Drawing.Point(45, 232);
            this.maskedTextBoxDataNascimento.Name = "maskedTextBoxDataNascimento";
            this.maskedTextBoxDataNascimento.Size = new System.Drawing.Size(127, 22);
            this.maskedTextBoxDataNascimento.TabIndex = 9;
            this.maskedTextBoxDataNascimento.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataNascimento.Click += new System.EventHandler(this.maskedTextBoxDataNascimento_Click);
            this.maskedTextBoxDataNascimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxDataNascimento_KeyPress);
            this.maskedTextBoxDataNascimento.Leave += new System.EventHandler(this.maskedTextBoxDataNascimento_Leave);
            // 
            // maskedTextBoxGenero
            // 
            this.maskedTextBoxGenero.Location = new System.Drawing.Point(255, 232);
            this.maskedTextBoxGenero.Name = "maskedTextBoxGenero";
            this.maskedTextBoxGenero.Size = new System.Drawing.Size(177, 22);
            this.maskedTextBoxGenero.TabIndex = 10;
            this.maskedTextBoxGenero.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxGenero.Click += new System.EventHandler(this.maskedTextBoxGenero_Click);
            this.maskedTextBoxGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxGenero_KeyPress);
            this.maskedTextBoxGenero.Leave += new System.EventHandler(this.maskedTextBoxGenero_Leave);
            // 
            // maskedTextBoxCor
            // 
            this.maskedTextBoxCor.Location = new System.Drawing.Point(480, 232);
            this.maskedTextBoxCor.Name = "maskedTextBoxCor";
            this.maskedTextBoxCor.Size = new System.Drawing.Size(217, 22);
            this.maskedTextBoxCor.TabIndex = 11;
            this.maskedTextBoxCor.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxCor.Click += new System.EventHandler(this.maskedTextBoxCor_Click);
            this.maskedTextBoxCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCor_KeyPress);
            this.maskedTextBoxCor.Leave += new System.EventHandler(this.maskedTextBoxCor_Leave);
            // 
            // maskedTextBoxCargo
            // 
            this.maskedTextBoxCargo.Location = new System.Drawing.Point(45, 275);
            this.maskedTextBoxCargo.Name = "maskedTextBoxCargo";
            this.maskedTextBoxCargo.Size = new System.Drawing.Size(267, 22);
            this.maskedTextBoxCargo.TabIndex = 12;
            this.maskedTextBoxCargo.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCargo_KeyPress);
            this.maskedTextBoxCargo.Leave += new System.EventHandler(this.maskedTextBoxCargo_Leave);
            // 
            // maskedTextBoxCargaHoraria
            // 
            this.maskedTextBoxCargaHoraria.Location = new System.Drawing.Point(558, 275);
            this.maskedTextBoxCargaHoraria.Name = "maskedTextBoxCargaHoraria";
            this.maskedTextBoxCargaHoraria.Size = new System.Drawing.Size(139, 22);
            this.maskedTextBoxCargaHoraria.TabIndex = 14;
            this.maskedTextBoxCargaHoraria.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxCargaHoraria.Click += new System.EventHandler(this.maskedTextBoxCargaHoraria_Click);
            this.maskedTextBoxCargaHoraria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCargaHoraria_KeyPress);
            this.maskedTextBoxCargaHoraria.Leave += new System.EventHandler(this.maskedTextBoxCargaHoraria_Leave);
            // 
            // maskedTextBoxPis
            // 
            this.maskedTextBoxPis.Location = new System.Drawing.Point(45, 316);
            this.maskedTextBoxPis.Name = "maskedTextBoxPis";
            this.maskedTextBoxPis.Size = new System.Drawing.Size(267, 22);
            this.maskedTextBoxPis.TabIndex = 15;
            this.maskedTextBoxPis.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxPis.Click += new System.EventHandler(this.maskedTextBoxPis_Click);
            this.maskedTextBoxPis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxPis_KeyPress);
            this.maskedTextBoxPis.Leave += new System.EventHandler(this.maskedTextBoxPis_Leave);
            // 
            // maskedTextBoxSalario
            // 
            this.maskedTextBoxSalario.Location = new System.Drawing.Point(430, 316);
            this.maskedTextBoxSalario.Name = "maskedTextBoxSalario";
            this.maskedTextBoxSalario.Size = new System.Drawing.Size(267, 22);
            this.maskedTextBoxSalario.TabIndex = 16;
            this.maskedTextBoxSalario.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxSalario.Click += new System.EventHandler(this.maskedTextBoxSalario_Click);
            this.maskedTextBoxSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxSalario_KeyPress);
            this.maskedTextBoxSalario.Leave += new System.EventHandler(this.maskedTextBoxSalario_Leave);
            // 
            // maskedTextBoxSetor
            // 
            this.maskedTextBoxSetor.Location = new System.Drawing.Point(398, 275);
            this.maskedTextBoxSetor.Name = "maskedTextBoxSetor";
            this.maskedTextBoxSetor.Size = new System.Drawing.Size(139, 22);
            this.maskedTextBoxSetor.TabIndex = 13;
            this.maskedTextBoxSetor.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxSetor.Click += new System.EventHandler(this.maskedTextBoxSetor_Click);
            this.maskedTextBoxSetor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxSetor_KeyPress);
            this.maskedTextBoxSetor.Leave += new System.EventHandler(this.maskedTextBoxSetor_Leave);
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 426);
            this.Controls.Add(this.maskedTextBoxSetor);
            this.Controls.Add(this.maskedTextBoxSalario);
            this.Controls.Add(this.maskedTextBoxPis);
            this.Controls.Add(this.maskedTextBoxCargaHoraria);
            this.Controls.Add(this.maskedTextBoxCargo);
            this.Controls.Add(this.maskedTextBoxCor);
            this.Controls.Add(this.maskedTextBoxGenero);
            this.Controls.Add(this.maskedTextBoxDataNascimento);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.maskedTextBoxEmail);
            this.Controls.Add(this.maskedTextBoxCidade);
            this.Controls.Add(this.maskedTextBoxEstado);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.maskedTextBoxEndereco);
            this.Controls.Add(this.maskedTextBoxRg);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.maskedTextBoxNome);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelNav);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Fucionarios";
            this.Load += new System.EventHandler(this.Formulario_Fucionarios_Load);
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label FormularioFuncionarios;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNome;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRg;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndereco;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEstado;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataNascimento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGenero;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCargo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCargaHoraria;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPis;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSalario;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSetor;
    }
}