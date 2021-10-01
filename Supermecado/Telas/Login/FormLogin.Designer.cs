
namespace Supermecado.Telas
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button buttonClose;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelMensageErro = new System.Windows.Forms.Label();
            this.checkBoxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            buttonClose.BackColor = System.Drawing.Color.Transparent;
            buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(43)))));
            buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonClose.ForeColor = System.Drawing.Color.Transparent;
            buttonClose.Location = new System.Drawing.Point(309, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(28, 26);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "X";
            buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(72)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(131, 362);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(72, 30);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textSenha
            // 
            this.textSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSenha.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.textSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textSenha.Location = new System.Drawing.Point(25, 268);
            this.textSenha.Margin = new System.Windows.Forms.Padding(4);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(289, 20);
            this.textSenha.TabIndex = 2;
            this.textSenha.Click += new System.EventHandler(this.textSenha_Click);
            this.textSenha.Enter += new System.EventHandler(this.textSenha_Click);
            this.textSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSenha_KeyPress);
            this.textSenha.Leave += new System.EventHandler(this.textSenha_Leave);
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmail.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.textEmail.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEmail.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textEmail.Location = new System.Drawing.Point(25, 224);
            this.textEmail.Margin = new System.Windows.Forms.Padding(20);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(289, 20);
            this.textEmail.TabIndex = 1;
            this.textEmail.Click += new System.EventHandler(this.textEmail_Click);
            this.textEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmail_KeyPress);
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelMensageErro
            // 
            this.labelMensageErro.AutoSize = true;
            this.labelMensageErro.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.labelMensageErro.ForeColor = System.Drawing.Color.Red;
            this.labelMensageErro.Location = new System.Drawing.Point(87, 330);
            this.labelMensageErro.Name = "labelMensageErro";
            this.labelMensageErro.Size = new System.Drawing.Size(183, 17);
            this.labelMensageErro.TabIndex = 20;
            this.labelMensageErro.Text = "Email ou senha incorretos!";
            this.labelMensageErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxMostrarSenha
            // 
            this.checkBoxMostrarSenha.AutoSize = true;
            this.checkBoxMostrarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBoxMostrarSenha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrarSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxMostrarSenha.Location = new System.Drawing.Point(35, 308);
            this.checkBoxMostrarSenha.Name = "checkBoxMostrarSenha";
            this.checkBoxMostrarSenha.Size = new System.Drawing.Size(105, 19);
            this.checkBoxMostrarSenha.TabIndex = 3;
            this.checkBoxMostrarSenha.Text = "Mostrar Senha";
            this.checkBoxMostrarSenha.UseVisualStyleBackColor = true;
            this.checkBoxMostrarSenha.CheckedChanged += new System.EventHandler(this.checkBoxMostrarSenha_CheckedChanged);
            this.checkBoxMostrarSenha.Click += new System.EventHandler(this.checkBoxMostrarSenha_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(72)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Controls.Add(buttonClose);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 35);
            this.panel1.TabIndex = 17;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(12, 6);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(89, 19);
            this.labelTitulo.TabIndex = 21;
            this.labelTitulo.Text = "AgroLucro$";
            // 
            // pictureLogin
            // 
            this.pictureLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogin.Image")));
            this.pictureLogin.Location = new System.Drawing.Point(60, 63);
            this.pictureLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(222, 137);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogin.TabIndex = 9;
            this.pictureLogin.TabStop = false;
            this.pictureLogin.UseWaitCursor = true;
            // 
            // FormLogin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelMensageErro);
            this.Controls.Add(this.checkBoxMostrarSenha);
            this.Controls.Add(this.pictureLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelMensageErro;
        private System.Windows.Forms.CheckBox checkBoxMostrarSenha;
        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitulo;
    }
}