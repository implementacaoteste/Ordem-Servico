﻿using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        private bool inserindoNovo;

        public FormCadastroUsuario()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
        }

        public FormCadastroUsuario(object _current)
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = _current;
            inserindoNovo = false;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();
                Inserir();
                MessageBox.Show("OPERAÇÃO REALIZADO COM SUCESSO!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("OCORREU UM ERRO! " + ex.Message);
            }
        }

        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();

            //usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.NomeUsuario = textBoxNomeUsuario.Text;
            usuario.Senha = textBoxSenha.Text;
            usuario.NomeCompleto = textBoxNomeCompleto.Text;
            usuario.Cpf = maskedTextBoxCpf.Text;
            usuario.Ativo = ativoCheckBox.Checked;
            usuario.Rg = textBoxRg.Text;
            usuario.OrgaoExpeditor = textBoxOrgExpeditor.Text;
            usuario.DataNascimento = maskedTextBoxDataNascimento.Text;
            usuario.Rua = textBoxRua.Text;
            usuario.NumCasa = textBoxNumCasa.Text;
            usuario.EstadoCivil = textBoxEstadoCivil.Text;
            usuario.Nacionalidade = textBoxNacionalidade.Text;
            usuario.Email = textBoxEmail.Text;
            usuario.Telefone = maskedTextBoxTelefone.Text;
            usuario.CelularUm = maskedTextBoxCelularUm.Text;
            usuario.CelularDois = maskedTextBoxCelularDois.Text;
            usuario.Cidade = textBoxCidade.Text;
            usuario.Uf = textBoxUf.Text;
            //usuario.Id = Convert.ToInt32(idTextBox.Text);
            //usuario.Ativo = ativoCheckBox.Checked;
            /*/@Id_Permissao,--###############
            int idpermissao = 0;
            foreach (int i in checkedListBoxNivelFuncionario.CheckedItems)
            {
                idpermissao += i;
            }
            usuario.Id_Permissao = Convert.ToInt32(idpermissao);
            ////////////////////////////////*/
            usuario.Id_Permissao = 2;

            usuario.Salario = textBoxSalario.Text;
            usuario.Cargo = textBoxCargo.Text;
            usuario.DataAdmissao = maskedTextBoxDataAdmissao.Text;
            usuario.DataDemissao = maskedTextBoxDataDemissao.Text;

            if (inserindoNovo)
                usuarioBLL.Inserir(usuario);
            else
                usuarioBLL.Alterar(usuario);
        }

        private void buttonSalvarECadastrarNovo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();
            Inserir();
            MessageBox.Show("CADASTRO REALIZADO COM SUCESSO - INSERINDO NOVO!");
            usuarioBindingSource.DataSource = typeof(Usuario);
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
            textBoxNomeUsuario.Focus();
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
