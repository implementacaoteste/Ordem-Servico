﻿using BLL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormConsultaUsuario : Form
    {
        public FormConsultaUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
                
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA EXCLUIR O CADASTRO?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            int id = Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["Id"]);
            File.Delete((string)((DataRowView)usuarioBindingSource.Current).Row["Foto"]);// EXCLUSAO DA FOTO NO DIRETORIO
            usuarioBLL.Excluir(id);// EXCLUSÃO DO CADASTRO NO BANCO
            usuarioBindingSource.RemoveCurrent();// ATUALIZAÇÃO DA GRID VIEW REMOVENDO O ITEM EXCLUIDO
            MessageBox.Show("CADASTRO EXCLUIDO COM SUCESSO!");
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario(usuarioBindingSource.Current))
            {
                frm.ShowDialog();
            }
        }
        private void FormConsultaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonSair_Click(null, null);
            }
        }
    }
}
