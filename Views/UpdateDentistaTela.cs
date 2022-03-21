using System;
using System.Windows.Forms;
using lib;

namespace Telas
{
    public class UpdateDentistaTela : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblUser;
        Button btnVoltar;
        Button btnSalvar;
        Label IdPaciente;
        Label Nome;
        Label CPF;
        Label Telefone;
        Label Email;
        Label DataNascimento;
        Label Senha;
        Label Registro;
        Label Salario;
        Label EspecialidadeId;
        TextBox txtIdPaciente;
        TextBox txtNome;
        TextBox txtCPF;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtRegistro;
        TextBox txtSalario;
        TextBox txtEspecialidadeId;
 
        public UpdateDentistaTela()
        {
            this.lblUser = new Campos.LabelFieldTam("Atualziar Dentista", 200, 15, 150, 30);

            this.IdPaciente = new Campos.LabelFieldTam("Id do Dentista:", 50, 40, 150, 30);
            this.txtIdPaciente = new Campos.TextBoxField(50, 70, 180, 20);

            this.Nome = new Campos.LabelField("Nome:", 50, 100);
            this.txtNome = new Campos.TextBoxField(50, 130, 180, 20);

            this.CPF = new Campos.LabelFieldTam("CPF:", 50, 160, 150, 30);
            this.txtCPF = new Campos.TextBoxField(50, 190, 180, 20);

            this.Telefone = new Campos.LabelFieldTam("Telefone:", 50, 220, 150, 30);
            this.txtTelefone = new Campos.TextBoxField(50, 250, 180, 20);

            this.Email = new Campos.LabelFieldTam("Email:", 50, 280, 150, 30);
            this.txtEmail = new Campos.TextBoxField(50, 310, 180, 20);

            this.Registro = new Campos.LabelFieldTam("Registro:", 250, 100, 150, 30);
            this.txtRegistro = new Campos.TextBoxField(250, 130, 180, 20);

            this.Salario = new Campos.LabelFieldTam("Salario:", 250, 160, 150, 30);
            this.txtSalario = new Campos.TextBoxField(250, 190, 180, 20);

            this.EspecialidadeId = new Campos.LabelFieldTam("Especialidade Id:", 250, 220, 150, 30);
            this.txtEspecialidadeId = new Campos.TextBoxField(250, 250, 180, 20);

            this.Senha = new Campos.LabelFieldTam("Senha:", 250, 280, 150, 30);
            this.txtSenha = new Campos.TextBoxField(250, 310, 180, 20);

            btnVoltar = new Campos.ButtonField("Voltar", 50, 450, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnSalvar = new Campos.ButtonField("Salvar", 350, 450, 100, 30);
			btnSalvar.Click += new EventHandler(this.btnSalvarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.IdPaciente);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.EspecialidadeId);
            this.Controls.Add(this.txtEspecialidadeId);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Dentista Dentista";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnSalvarClick(object sender, EventArgs e)
        {
            String Message = "Dentista atualizado com sucesso!";
            String Title = "Operação feita!";
            MessageBox.Show(Message, Title);
            this.Close();
        }
    }
}