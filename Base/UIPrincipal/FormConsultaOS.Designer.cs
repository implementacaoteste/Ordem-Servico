﻿namespace UIPrincipal
{
    partial class FormConsultaOS
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
            System.Windows.Forms.Label label1CpfCNPJ;
            System.Windows.Forms.Label labelBairro;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label labelUf;
            System.Windows.Forms.Label labelCidade;
            System.Windows.Forms.Label labelCelularDois;
            System.Windows.Forms.Label labelCelularUm;
            System.Windows.Forms.Label labelTelefone;
            System.Windows.Forms.Label labelEmail;
            System.Windows.Forms.Label labelNumCasa;
            System.Windows.Forms.Label labelRua;
            System.Windows.Forms.Label labelDescricao;
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxPrazo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataAbertura = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.textBoxPlano = new System.Windows.Forms.TextBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelIdPessoa = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCelularDois = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxCelularUm = new System.Windows.Forms.MaskedTextBox();
            this.textBoxUf = new System.Windows.Forms.TextBox();
            this.textBoxAtendente = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxNumCasa = new System.Windows.Forms.TextBox();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxProtocolo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuscarOS = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxTipoChamado = new System.Windows.Forms.ComboBox();
            this.comboBoxEstatusOS = new System.Windows.Forms.ComboBox();
            this.comboBoxLigarAntes = new System.Windows.Forms.ComboBox();
            this.comboBoxTecnicoResponsavel = new System.Windows.Forms.ComboBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ordemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.openFileDialogAddFoto = new System.Windows.Forms.OpenFileDialog();
            label1CpfCNPJ = new System.Windows.Forms.Label();
            labelBairro = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            labelUf = new System.Windows.Forms.Label();
            labelCidade = new System.Windows.Forms.Label();
            labelCelularDois = new System.Windows.Forms.Label();
            labelCelularUm = new System.Windows.Forms.Label();
            labelTelefone = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            labelNumCasa = new System.Windows.Forms.Label();
            labelRua = new System.Windows.Forms.Label();
            labelDescricao = new System.Windows.Forms.Label();
            this.groupBoxDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1CpfCNPJ
            // 
            label1CpfCNPJ.AutoSize = true;
            label1CpfCNPJ.ForeColor = System.Drawing.Color.Black;
            label1CpfCNPJ.Location = new System.Drawing.Point(544, 23);
            label1CpfCNPJ.Name = "label1CpfCNPJ";
            label1CpfCNPJ.Size = new System.Drawing.Size(68, 13);
            label1CpfCNPJ.TabIndex = 43;
            label1CpfCNPJ.Text = "CPF / CNPJ:";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.ForeColor = System.Drawing.Color.Black;
            labelBairro.Location = new System.Drawing.Point(286, 63);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new System.Drawing.Size(51, 13);
            labelBairro.TabIndex = 41;
            labelBairro.Text = "BAIRRO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(4, 63);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(31, 13);
            label8.TabIndex = 33;
            label8.Text = "CEP:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(67, 23);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(104, 13);
            label9.TabIndex = 5;
            label9.Text = "NOME COMPLETO:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = System.Drawing.Color.Black;
            label11.Location = new System.Drawing.Point(3, 23);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(52, 13);
            label11.TabIndex = 3;
            label11.Text = "CODIGO:";
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.ForeColor = System.Drawing.Color.Black;
            labelUf.Location = new System.Drawing.Point(505, 63);
            labelUf.Name = "labelUf";
            labelUf.Size = new System.Drawing.Size(24, 13);
            labelUf.TabIndex = 17;
            labelUf.Text = "UF:";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.ForeColor = System.Drawing.Color.Black;
            labelCidade.Location = new System.Drawing.Point(387, 63);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new System.Drawing.Size(50, 13);
            labelCidade.TabIndex = 24;
            labelCidade.Text = "CIDADE:";
            // 
            // labelCelularDois
            // 
            labelCelularDois.AutoSize = true;
            labelCelularDois.ForeColor = System.Drawing.Color.Black;
            labelCelularDois.Location = new System.Drawing.Point(447, 102);
            labelCelularDois.Name = "labelCelularDois";
            labelCelularDois.Size = new System.Drawing.Size(68, 13);
            labelCelularDois.TabIndex = 19;
            labelCelularDois.Text = "CELULAR 2:";
            // 
            // labelCelularUm
            // 
            labelCelularUm.AutoSize = true;
            labelCelularUm.ForeColor = System.Drawing.Color.Black;
            labelCelularUm.Location = new System.Drawing.Point(346, 102);
            labelCelularUm.Name = "labelCelularUm";
            labelCelularUm.Size = new System.Drawing.Size(68, 13);
            labelCelularUm.TabIndex = 22;
            labelCelularUm.Text = "CELULAR 1:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.ForeColor = System.Drawing.Color.Black;
            labelTelefone.Location = new System.Drawing.Point(245, 102);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new System.Drawing.Size(66, 13);
            labelTelefone.TabIndex = 27;
            labelTelefone.Text = "TELEFONE:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.ForeColor = System.Drawing.Color.Black;
            labelEmail.Location = new System.Drawing.Point(3, 102);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(45, 13);
            labelEmail.TabIndex = 30;
            labelEmail.Text = "E-MAIL:";
            // 
            // labelNumCasa
            // 
            labelNumCasa.AutoSize = true;
            labelNumCasa.ForeColor = System.Drawing.Color.Black;
            labelNumCasa.Location = new System.Drawing.Point(245, 63);
            labelNumCasa.Name = "labelNumCasa";
            labelNumCasa.Size = new System.Drawing.Size(22, 13);
            labelNumCasa.TabIndex = 25;
            labelNumCasa.Text = "N°:";
            // 
            // labelRua
            // 
            labelRua.AutoSize = true;
            labelRua.ForeColor = System.Drawing.Color.Black;
            labelRua.Location = new System.Drawing.Point(67, 63);
            labelRua.Name = "labelRua";
            labelRua.Size = new System.Drawing.Size(33, 13);
            labelRua.TabIndex = 32;
            labelRua.Text = "RUA:";
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.ForeColor = System.Drawing.Color.Black;
            labelDescricao.Location = new System.Drawing.Point(10, 274);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new System.Drawing.Size(72, 13);
            labelDescricao.TabIndex = 55;
            labelDescricao.Text = "DESCRIÇÃO:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(298, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "LIGAR ANTES:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "PRAZO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "ABERTURA:";
            // 
            // maskedTextBoxPrazo
            // 
            this.maskedTextBoxPrazo.Location = new System.Drawing.Point(469, 251);
            this.maskedTextBoxPrazo.Mask = "00-00-0000";
            this.maskedTextBoxPrazo.Name = "maskedTextBoxPrazo";
            this.maskedTextBoxPrazo.ReadOnly = true;
            this.maskedTextBoxPrazo.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBoxPrazo.TabIndex = 5;
            // 
            // maskedTextBoxDataAbertura
            // 
            this.maskedTextBoxDataAbertura.Location = new System.Drawing.Point(385, 251);
            this.maskedTextBoxDataAbertura.Mask = "00-00-0000";
            this.maskedTextBoxDataAbertura.Name = "maskedTextBoxDataAbertura";
            this.maskedTextBoxDataAbertura.ReadOnly = true;
            this.maskedTextBoxDataAbertura.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBoxDataAbertura.TabIndex = 57;
            // 
            // groupBoxDadosPessoais
            // 
            this.groupBoxDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxPlano);
            this.groupBoxDadosPessoais.Controls.Add(label1CpfCNPJ);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxCpf);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxBairro);
            this.groupBoxDadosPessoais.Controls.Add(labelBairro);
            this.groupBoxDadosPessoais.Controls.Add(this.labelIdPessoa);
            this.groupBoxDadosPessoais.Controls.Add(label8);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxCep);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxEmail);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxTelefone);
            this.groupBoxDadosPessoais.Controls.Add(label9);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxCelularDois);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxNomeCompleto);
            this.groupBoxDadosPessoais.Controls.Add(this.label6);
            this.groupBoxDadosPessoais.Controls.Add(this.label4);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxCelularUm);
            this.groupBoxDadosPessoais.Controls.Add(label11);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxUf);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxAtendente);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxCidade);
            this.groupBoxDadosPessoais.Controls.Add(labelUf);
            this.groupBoxDadosPessoais.Controls.Add(labelCidade);
            this.groupBoxDadosPessoais.Controls.Add(labelCelularDois);
            this.groupBoxDadosPessoais.Controls.Add(labelCelularUm);
            this.groupBoxDadosPessoais.Controls.Add(labelTelefone);
            this.groupBoxDadosPessoais.Controls.Add(labelEmail);
            this.groupBoxDadosPessoais.Controls.Add(labelNumCasa);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxNumCasa);
            this.groupBoxDadosPessoais.Controls.Add(labelRua);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxRua);
            this.groupBoxDadosPessoais.Location = new System.Drawing.Point(6, 81);
            this.groupBoxDadosPessoais.Name = "groupBoxDadosPessoais";
            this.groupBoxDadosPessoais.Size = new System.Drawing.Size(825, 147);
            this.groupBoxDadosPessoais.TabIndex = 48;
            this.groupBoxDadosPessoais.TabStop = false;
            // 
            // textBoxPlano
            // 
            this.textBoxPlano.Location = new System.Drawing.Point(547, 79);
            this.textBoxPlano.Name = "textBoxPlano";
            this.textBoxPlano.ReadOnly = true;
            this.textBoxPlano.Size = new System.Drawing.Size(272, 20);
            this.textBoxPlano.TabIndex = 68;
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCpf.Location = new System.Drawing.Point(547, 39);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.ReadOnly = true;
            this.textBoxCpf.Size = new System.Drawing.Size(272, 20);
            this.textBoxCpf.TabIndex = 42;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxBairro.Location = new System.Drawing.Point(290, 79);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.ReadOnly = true;
            this.textBoxBairro.Size = new System.Drawing.Size(94, 20);
            this.textBoxBairro.TabIndex = 40;
            // 
            // labelIdPessoa
            // 
            this.labelIdPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIdPessoa.Location = new System.Drawing.Point(6, 39);
            this.labelIdPessoa.Name = "labelIdPessoa";
            this.labelIdPessoa.Size = new System.Drawing.Size(58, 20);
            this.labelIdPessoa.TabIndex = 39;
            this.labelIdPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(6, 79);
            this.maskedTextBoxCep.Mask = "00000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.ReadOnly = true;
            this.maskedTextBoxCep.Size = new System.Drawing.Size(58, 20);
            this.maskedTextBoxCep.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxEmail.Location = new System.Drawing.Point(6, 118);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(236, 20);
            this.textBoxEmail.TabIndex = 12;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(248, 118);
            this.maskedTextBoxTelefone.Mask = "(99) 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.ReadOnly = true;
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxTelefone.TabIndex = 13;
            // 
            // maskedTextBoxCelularDois
            // 
            this.maskedTextBoxCelularDois.Location = new System.Drawing.Point(450, 118);
            this.maskedTextBoxCelularDois.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxCelularDois.Name = "maskedTextBoxCelularDois";
            this.maskedTextBoxCelularDois.ReadOnly = true;
            this.maskedTextBoxCelularDois.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxCelularDois.TabIndex = 15;
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(70, 39);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.ReadOnly = true;
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(471, 20);
            this.textBoxNomeCompleto.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "PLANO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "ATENDENTE:";
            // 
            // maskedTextBoxCelularUm
            // 
            this.maskedTextBoxCelularUm.Location = new System.Drawing.Point(349, 118);
            this.maskedTextBoxCelularUm.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxCelularUm.Name = "maskedTextBoxCelularUm";
            this.maskedTextBoxCelularUm.ReadOnly = true;
            this.maskedTextBoxCelularUm.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxCelularUm.TabIndex = 14;
            // 
            // textBoxUf
            // 
            this.textBoxUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUf.Location = new System.Drawing.Point(508, 79);
            this.textBoxUf.Name = "textBoxUf";
            this.textBoxUf.ReadOnly = true;
            this.textBoxUf.Size = new System.Drawing.Size(33, 20);
            this.textBoxUf.TabIndex = 11;
            // 
            // textBoxAtendente
            // 
            this.textBoxAtendente.Location = new System.Drawing.Point(547, 118);
            this.textBoxAtendente.Name = "textBoxAtendente";
            this.textBoxAtendente.ReadOnly = true;
            this.textBoxAtendente.Size = new System.Drawing.Size(272, 20);
            this.textBoxAtendente.TabIndex = 13;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCidade.Location = new System.Drawing.Point(390, 79);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.ReadOnly = true;
            this.textBoxCidade.Size = new System.Drawing.Size(112, 20);
            this.textBoxCidade.TabIndex = 10;
            // 
            // textBoxNumCasa
            // 
            this.textBoxNumCasa.Location = new System.Drawing.Point(248, 79);
            this.textBoxNumCasa.Name = "textBoxNumCasa";
            this.textBoxNumCasa.ReadOnly = true;
            this.textBoxNumCasa.Size = new System.Drawing.Size(36, 20);
            this.textBoxNumCasa.TabIndex = 9;
            // 
            // textBoxRua
            // 
            this.textBoxRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRua.Location = new System.Drawing.Point(70, 79);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.ReadOnly = true;
            this.textBoxRua.Size = new System.Drawing.Size(172, 20);
            this.textBoxRua.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "TÉCNICO RESPONSÁVEL:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescricao.Location = new System.Drawing.Point(11, 290);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(814, 100);
            this.textBoxDescricao.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "STATUS:";
            // 
            // textBoxProtocolo
            // 
            this.textBoxProtocolo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProtocolo.Location = new System.Drawing.Point(366, 59);
            this.textBoxProtocolo.Name = "textBoxProtocolo";
            this.textBoxProtocolo.ReadOnly = true;
            this.textBoxProtocolo.Size = new System.Drawing.Size(136, 16);
            this.textBoxProtocolo.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "TIPO DE CHAMADO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "PROTOCOLO:";
            // 
            // textBoxBuscarOS
            // 
            this.textBoxBuscarOS.Location = new System.Drawing.Point(13, 12);
            this.textBoxBuscarOS.Name = "textBoxBuscarOS";
            this.textBoxBuscarOS.Size = new System.Drawing.Size(198, 20);
            this.textBoxBuscarOS.TabIndex = 0;
            this.textBoxBuscarOS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscarOS_KeyDown);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(217, 10);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxTipoChamado
            // 
            this.comboBoxTipoChamado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoChamado.FormattingEnabled = true;
            this.comboBoxTipoChamado.Location = new System.Drawing.Point(13, 250);
            this.comboBoxTipoChamado.Name = "comboBoxTipoChamado";
            this.comboBoxTipoChamado.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTipoChamado.TabIndex = 63;
            // 
            // comboBoxEstatusOS
            // 
            this.comboBoxEstatusOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstatusOS.FormattingEnabled = true;
            this.comboBoxEstatusOS.Location = new System.Drawing.Point(179, 250);
            this.comboBoxEstatusOS.Name = "comboBoxEstatusOS";
            this.comboBoxEstatusOS.Size = new System.Drawing.Size(113, 21);
            this.comboBoxEstatusOS.TabIndex = 64;
            // 
            // comboBoxLigarAntes
            // 
            this.comboBoxLigarAntes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLigarAntes.FormattingEnabled = true;
            this.comboBoxLigarAntes.Items.AddRange(new object[] {
            "SIM",
            "NAO"});
            this.comboBoxLigarAntes.Location = new System.Drawing.Point(301, 250);
            this.comboBoxLigarAntes.Name = "comboBoxLigarAntes";
            this.comboBoxLigarAntes.Size = new System.Drawing.Size(78, 21);
            this.comboBoxLigarAntes.TabIndex = 65;
            // 
            // comboBoxTecnicoResponsavel
            // 
            this.comboBoxTecnicoResponsavel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTecnicoResponsavel.FormattingEnabled = true;
            this.comboBoxTecnicoResponsavel.Location = new System.Drawing.Point(553, 250);
            this.comboBoxTecnicoResponsavel.Name = "comboBoxTecnicoResponsavel";
            this.comboBoxTecnicoResponsavel.Size = new System.Drawing.Size(272, 21);
            this.comboBoxTecnicoResponsavel.TabIndex = 66;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(247, 526);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 67;
            this.buttonAtualizar.Text = "EDITAR";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(490, 526);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 68;
            this.buttonFechar.Text = "FECHAR";
            this.buttonFechar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(409, 526);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 69;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 70;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 71;
            this.button2.Text = "SALVAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ordemServicoBindingSource
            // 
            this.ordemServicoBindingSource.DataSource = typeof(Model.OrdemServico);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(166, 526);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(75, 23);
            this.buttonImprimir.TabIndex = 72;
            this.buttonImprimir.Text = "IMPRIMIR";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // openFileDialogAddFoto
            // 
            this.openFileDialogAddFoto.FileName = "openFileDialogAddFoto";
            this.openFileDialogAddFoto.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // FormConsultaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 561);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.comboBoxTecnicoResponsavel);
            this.Controls.Add(this.comboBoxLigarAntes);
            this.Controls.Add(this.comboBoxEstatusOS);
            this.Controls.Add(this.comboBoxTipoChamado);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscarOS);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxPrazo);
            this.Controls.Add(this.maskedTextBoxDataAbertura);
            this.Controls.Add(this.groupBoxDadosPessoais);
            this.Controls.Add(labelDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxProtocolo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(840, 600);
            this.Name = "FormConsultaOS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormConsultaOS_Load);
            this.groupBoxDadosPessoais.ResumeLayout(false);
            this.groupBoxDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrazo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataAbertura;
        private System.Windows.Forms.GroupBox groupBoxDadosPessoais;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label labelIdPessoa;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelularDois;
        private System.Windows.Forms.TextBox textBoxNomeCompleto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelularUm;
        private System.Windows.Forms.TextBox textBoxUf;
        private System.Windows.Forms.TextBox textBoxAtendente;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxNumCasa;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxProtocolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscarOS;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.BindingSource ordemServicoBindingSource;
        private System.Windows.Forms.ComboBox comboBoxTipoChamado;
        private System.Windows.Forms.ComboBox comboBoxEstatusOS;
        private System.Windows.Forms.ComboBox comboBoxLigarAntes;
        private System.Windows.Forms.ComboBox comboBoxTecnicoResponsavel;
        private System.Windows.Forms.TextBox textBoxPlano;
        private System.Windows.Forms.BindingSource planoBindingSource;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.OpenFileDialog openFileDialogAddFoto;
    }
}