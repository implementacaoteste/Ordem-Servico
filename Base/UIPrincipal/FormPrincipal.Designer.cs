﻿
namespace UIPrincipal
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gRUPODEUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIPODECHAMADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLANOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deligarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.buttonFecharAba = new System.Windows.Forms.Button();
            this.textBoxBuscarCadastro = new System.Windows.Forms.TextBox();
            this.buttonBuscarCadastro = new System.Windows.Forms.Button();
            this.tabControlConsulta = new System.Windows.Forms.TabControl();
            this.tabPageOSPendentes = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxFechada = new System.Windows.Forms.CheckBox();
            this.checkBoxEncaminhado = new System.Windows.Forms.CheckBox();
            this.checkBoxAberto = new System.Windows.Forms.CheckBox();
            this.dataGridViewOSAbertas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoChamadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrazoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPBuscarOSPendenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDEMSERVICODataSetOsPendente = new UIPrincipal.ORDEMSERVICODataSetOsPendente();
            this.tabPageCadastrados = new System.Windows.Forms.TabPage();
            this.panelFiltroPessoa = new System.Windows.Forms.Panel();
            this.labelFilto = new System.Windows.Forms.Label();
            this.groupBoxFiltroCadastro = new System.Windows.Forms.GroupBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.checkBoxCliente = new System.Windows.Forms.CheckBox();
            this.checkBoxFuncionario = new System.Windows.Forms.CheckBox();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clienteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripAbaDois = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarAbaDoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sP_BuscarOSPendenteTableAdapter = new UIPrincipal.ORDEMSERVICODataSetOsPendenteTableAdapters.SP_BuscarOSPendenteTableAdapter();
            this.contextMenuStripAbaUm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.visualizarDetalhesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressãoDiretaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.tabControlConsulta.SuspendLayout();
            this.tabPageOSPendentes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOSAbertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBuscarOSPendenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDEMSERVICODataSetOsPendente)).BeginInit();
            this.tabPageCadastrados.SuspendLayout();
            this.panelFiltroPessoa.SuspendLayout();
            this.groupBoxFiltroCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.contextMenuStripAbaDois.SuspendLayout();
            this.contextMenuStripAbaUm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gRUPODEUSUARIOToolStripMenuItem,
            this.aJUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gRUPODEUSUARIOToolStripMenuItem
            // 
            this.gRUPODEUSUARIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.tIPODECHAMADOToolStripMenuItem,
            this.pLANOToolStripMenuItem});
            this.gRUPODEUSUARIOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gRUPODEUSUARIOToolStripMenuItem.Name = "gRUPODEUSUARIOToolStripMenuItem";
            this.gRUPODEUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.gRUPODEUSUARIOToolStripMenuItem.Text = "&CADASTRO";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.uSUARIOSToolStripMenuItem.Text = "&FUNCIONARIO/CLIENTE";
            this.uSUARIOSToolStripMenuItem.Click += new System.EventHandler(this.uSUARIOSToolStripMenuItem_Click);
            // 
            // tIPODECHAMADOToolStripMenuItem
            // 
            this.tIPODECHAMADOToolStripMenuItem.Name = "tIPODECHAMADOToolStripMenuItem";
            this.tIPODECHAMADOToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.tIPODECHAMADOToolStripMenuItem.Text = "TIPO DE CHAMADO";
            this.tIPODECHAMADOToolStripMenuItem.Click += new System.EventHandler(this.tIPODECHAMADOToolStripMenuItem_Click);
            // 
            // pLANOToolStripMenuItem
            // 
            this.pLANOToolStripMenuItem.Name = "pLANOToolStripMenuItem";
            this.pLANOToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.pLANOToolStripMenuItem.Text = "&PLANO";
            this.pLANOToolStripMenuItem.Click += new System.EventHandler(this.pLANOToolStripMenuItem_Click);
            // 
            // aJUDAToolStripMenuItem
            // 
            this.aJUDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sOBREToolStripMenuItem,
            this.sAIRToolStripMenuItem,
            this.deligarToolStripMenuItem});
            this.aJUDAToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aJUDAToolStripMenuItem.Name = "aJUDAToolStripMenuItem";
            this.aJUDAToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aJUDAToolStripMenuItem.Text = "&AJUDA";
            // 
            // sOBREToolStripMenuItem
            // 
            this.sOBREToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.sOBREToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            this.sOBREToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sOBREToolStripMenuItem.Text = "&SOBRE";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sAIRToolStripMenuItem.Text = "&LOGOFF";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // deligarToolStripMenuItem
            // 
            this.deligarToolStripMenuItem.Name = "deligarToolStripMenuItem";
            this.deligarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deligarToolStripMenuItem.Text = "DESLIGAR";
            this.deligarToolStripMenuItem.Click += new System.EventHandler(this.deligarToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUsuario,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(854, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUsuario
            // 
            this.toolStripStatusLabelUsuario.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelUsuario.Name = "toolStripStatusLabelUsuario";
            this.toolStripStatusLabelUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
            this.toolStripStatusLabelUsuario.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabelUsuario.Text = "USUARIO";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = " :LOGADO COMO";
            // 
            // panelCentro
            // 
            this.panelCentro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCentro.BackColor = System.Drawing.Color.Black;
            this.panelCentro.Controls.Add(this.buttonFecharAba);
            this.panelCentro.Controls.Add(this.textBoxBuscarCadastro);
            this.panelCentro.Controls.Add(this.buttonBuscarCadastro);
            this.panelCentro.Controls.Add(this.tabControlConsulta);
            this.panelCentro.Controls.Add(this.menuStrip2);
            this.panelCentro.Location = new System.Drawing.Point(0, 27);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(854, 551);
            this.panelCentro.TabIndex = 3;
            // 
            // buttonFecharAba
            // 
            this.buttonFecharAba.BackColor = System.Drawing.Color.Transparent;
            this.buttonFecharAba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFecharAba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFecharAba.FlatAppearance.BorderSize = 0;
            this.buttonFecharAba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonFecharAba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFecharAba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFecharAba.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFecharAba.Image = ((System.Drawing.Image)(resources.GetObject("buttonFecharAba.Image")));
            this.buttonFecharAba.Location = new System.Drawing.Point(181, 35);
            this.buttonFecharAba.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFecharAba.Name = "buttonFecharAba";
            this.buttonFecharAba.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonFecharAba.Size = new System.Drawing.Size(13, 13);
            this.buttonFecharAba.TabIndex = 7;
            this.buttonFecharAba.UseVisualStyleBackColor = false;
            this.buttonFecharAba.Click += new System.EventHandler(this.buttonFecharAba_Click);
            // 
            // textBoxBuscarCadastro
            // 
            this.textBoxBuscarCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBuscarCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxBuscarCadastro.Location = new System.Drawing.Point(634, 2);
            this.textBoxBuscarCadastro.Name = "textBoxBuscarCadastro";
            this.textBoxBuscarCadastro.Size = new System.Drawing.Size(189, 20);
            this.textBoxBuscarCadastro.TabIndex = 0;
            this.textBoxBuscarCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscarCadastro_KeyDown);
            // 
            // buttonBuscarCadastro
            // 
            this.buttonBuscarCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBuscarCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBuscarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarCadastro.FlatAppearance.BorderSize = 0;
            this.buttonBuscarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCadastro.Image = global::UIPrincipal.Properties.Resources.magnifier;
            this.buttonBuscarCadastro.Location = new System.Drawing.Point(824, 0);
            this.buttonBuscarCadastro.Name = "buttonBuscarCadastro";
            this.buttonBuscarCadastro.Size = new System.Drawing.Size(23, 23);
            this.buttonBuscarCadastro.TabIndex = 1;
            this.buttonBuscarCadastro.UseVisualStyleBackColor = true;
            this.buttonBuscarCadastro.Click += new System.EventHandler(this.buttonBuscarCadastro_Click);
            // 
            // tabControlConsulta
            // 
            this.tabControlConsulta.Controls.Add(this.tabPageOSPendentes);
            this.tabControlConsulta.Controls.Add(this.tabPageCadastrados);
            this.tabControlConsulta.Location = new System.Drawing.Point(3, 31);
            this.tabControlConsulta.Name = "tabControlConsulta";
            this.tabControlConsulta.SelectedIndex = 0;
            this.tabControlConsulta.Size = new System.Drawing.Size(848, 517);
            this.tabControlConsulta.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlConsulta.TabIndex = 1;
            this.tabControlConsulta.SelectedIndexChanged += new System.EventHandler(this.tabControlConsulta_SelectedIndexChanged);
            // 
            // tabPageOSPendentes
            // 
            this.tabPageOSPendentes.Controls.Add(this.panel1);
            this.tabPageOSPendentes.Controls.Add(this.dataGridViewOSAbertas);
            this.tabPageOSPendentes.Location = new System.Drawing.Point(4, 22);
            this.tabPageOSPendentes.Name = "tabPageOSPendentes";
            this.tabPageOSPendentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOSPendentes.Size = new System.Drawing.Size(840, 491);
            this.tabPageOSPendentes.TabIndex = 0;
            this.tabPageOSPendentes.Text = "O.S Pendentes";
            this.tabPageOSPendentes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 25);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "FILTRO DE BUSCA:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxFechada);
            this.groupBox1.Controls.Add(this.checkBoxEncaminhado);
            this.groupBox1.Controls.Add(this.checkBoxAberto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(113, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 27);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxFechada
            // 
            this.checkBoxFechada.AutoSize = true;
            this.checkBoxFechada.ForeColor = System.Drawing.Color.Black;
            this.checkBoxFechada.Location = new System.Drawing.Point(150, 8);
            this.checkBoxFechada.Name = "checkBoxFechada";
            this.checkBoxFechada.Size = new System.Drawing.Size(68, 17);
            this.checkBoxFechada.TabIndex = 11;
            this.checkBoxFechada.Text = "Fechada";
            this.checkBoxFechada.UseVisualStyleBackColor = true;
            this.checkBoxFechada.CheckedChanged += new System.EventHandler(this.checkBoxFechada_CheckedChanged);
            // 
            // checkBoxEncaminhado
            // 
            this.checkBoxEncaminhado.AutoSize = true;
            this.checkBoxEncaminhado.ForeColor = System.Drawing.Color.Black;
            this.checkBoxEncaminhado.Location = new System.Drawing.Point(61, 8);
            this.checkBoxEncaminhado.Name = "checkBoxEncaminhado";
            this.checkBoxEncaminhado.Size = new System.Drawing.Size(91, 17);
            this.checkBoxEncaminhado.TabIndex = 10;
            this.checkBoxEncaminhado.Text = "Encaminhada";
            this.checkBoxEncaminhado.UseVisualStyleBackColor = true;
            this.checkBoxEncaminhado.CheckedChanged += new System.EventHandler(this.checkBoxEncaminhado_CheckedChanged);
            // 
            // checkBoxAberto
            // 
            this.checkBoxAberto.AutoSize = true;
            this.checkBoxAberto.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAberto.Location = new System.Drawing.Point(6, 8);
            this.checkBoxAberto.Name = "checkBoxAberto";
            this.checkBoxAberto.Size = new System.Drawing.Size(57, 17);
            this.checkBoxAberto.TabIndex = 0;
            this.checkBoxAberto.Text = "Aberta";
            this.checkBoxAberto.UseVisualStyleBackColor = true;
            this.checkBoxAberto.CheckedChanged += new System.EventHandler(this.checkBoxAberto_CheckedChanged);
            // 
            // dataGridViewOSAbertas
            // 
            this.dataGridViewOSAbertas.AllowUserToResizeColumns = false;
            this.dataGridViewOSAbertas.AllowUserToResizeRows = false;
            this.dataGridViewOSAbertas.AutoGenerateColumns = false;
            this.dataGridViewOSAbertas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOSAbertas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewOSAbertas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOSAbertas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewOSAbertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOSAbertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.protocoloDataGridViewTextBoxColumn,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.tipoChamadoDataGridViewTextBoxColumn,
            this.estatusOSDataGridViewTextBoxColumn,
            this.dataAberturaDataGridViewTextBoxColumn,
            this.dataPrazoDataGridViewTextBoxColumn});
            this.dataGridViewOSAbertas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewOSAbertas.DataSource = this.sPBuscarOSPendenteBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOSAbertas.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewOSAbertas.Location = new System.Drawing.Point(3, 29);
            this.dataGridViewOSAbertas.MinimumSize = new System.Drawing.Size(814, 386);
            this.dataGridViewOSAbertas.Name = "dataGridViewOSAbertas";
            this.dataGridViewOSAbertas.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOSAbertas.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewOSAbertas.RowHeadersVisible = false;
            this.dataGridViewOSAbertas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewOSAbertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOSAbertas.Size = new System.Drawing.Size(834, 459);
            this.dataGridViewOSAbertas.TabIndex = 3;
            this.dataGridViewOSAbertas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOSAbertas_CellClick);
            this.dataGridViewOSAbertas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOSAbertas_CellDoubleClick);
            this.dataGridViewOSAbertas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewOSAbertas_MouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "COD";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // protocoloDataGridViewTextBoxColumn
            // 
            this.protocoloDataGridViewTextBoxColumn.DataPropertyName = "Protocolo";
            this.protocoloDataGridViewTextBoxColumn.HeaderText = "PROTOCOLO";
            this.protocoloDataGridViewTextBoxColumn.Name = "protocoloDataGridViewTextBoxColumn";
            this.protocoloDataGridViewTextBoxColumn.ReadOnly = true;
            this.protocoloDataGridViewTextBoxColumn.Width = 105;
            // 
            // nomeCompletoDataGridViewTextBoxColumn
            // 
            this.nomeCompletoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "CLIENTE";
            this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
            this.nomeCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoChamadoDataGridViewTextBoxColumn
            // 
            this.tipoChamadoDataGridViewTextBoxColumn.DataPropertyName = "TipoChamado";
            this.tipoChamadoDataGridViewTextBoxColumn.HeaderText = "TIPO DE CHAMADO";
            this.tipoChamadoDataGridViewTextBoxColumn.Name = "tipoChamadoDataGridViewTextBoxColumn";
            this.tipoChamadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoChamadoDataGridViewTextBoxColumn.Width = 155;
            // 
            // estatusOSDataGridViewTextBoxColumn
            // 
            this.estatusOSDataGridViewTextBoxColumn.DataPropertyName = "EstatusOS";
            this.estatusOSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.estatusOSDataGridViewTextBoxColumn.Name = "estatusOSDataGridViewTextBoxColumn";
            this.estatusOSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAberturaDataGridViewTextBoxColumn
            // 
            this.dataAberturaDataGridViewTextBoxColumn.DataPropertyName = "DataAbertura";
            this.dataAberturaDataGridViewTextBoxColumn.HeaderText = "ABERTURA";
            this.dataAberturaDataGridViewTextBoxColumn.Name = "dataAberturaDataGridViewTextBoxColumn";
            this.dataAberturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataAberturaDataGridViewTextBoxColumn.Width = 70;
            // 
            // dataPrazoDataGridViewTextBoxColumn
            // 
            this.dataPrazoDataGridViewTextBoxColumn.DataPropertyName = "DataPrazo";
            this.dataPrazoDataGridViewTextBoxColumn.HeaderText = "PRAZO";
            this.dataPrazoDataGridViewTextBoxColumn.Name = "dataPrazoDataGridViewTextBoxColumn";
            this.dataPrazoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataPrazoDataGridViewTextBoxColumn.Width = 70;
            // 
            // sPBuscarOSPendenteBindingSource
            // 
            this.sPBuscarOSPendenteBindingSource.DataMember = "SP_BuscarOSPendente";
            this.sPBuscarOSPendenteBindingSource.DataSource = this.oRDEMSERVICODataSetOsPendente;
            // 
            // oRDEMSERVICODataSetOsPendente
            // 
            this.oRDEMSERVICODataSetOsPendente.DataSetName = "ORDEMSERVICODataSetOsPendente";
            this.oRDEMSERVICODataSetOsPendente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageCadastrados
            // 
            this.tabPageCadastrados.AllowDrop = true;
            this.tabPageCadastrados.Controls.Add(this.panelFiltroPessoa);
            this.tabPageCadastrados.Controls.Add(this.usuarioDataGridView);
            this.tabPageCadastrados.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastrados.Name = "tabPageCadastrados";
            this.tabPageCadastrados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastrados.Size = new System.Drawing.Size(840, 491);
            this.tabPageCadastrados.TabIndex = 1;
            this.tabPageCadastrados.Text = "Cadastros";
            this.tabPageCadastrados.UseVisualStyleBackColor = true;
            // 
            // panelFiltroPessoa
            // 
            this.panelFiltroPessoa.BackColor = System.Drawing.Color.DarkGray;
            this.panelFiltroPessoa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFiltroPessoa.Controls.Add(this.labelFilto);
            this.panelFiltroPessoa.Controls.Add(this.groupBoxFiltroCadastro);
            this.panelFiltroPessoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltroPessoa.Location = new System.Drawing.Point(3, 3);
            this.panelFiltroPessoa.Name = "panelFiltroPessoa";
            this.panelFiltroPessoa.Size = new System.Drawing.Size(834, 25);
            this.panelFiltroPessoa.TabIndex = 4;
            // 
            // labelFilto
            // 
            this.labelFilto.AutoSize = true;
            this.labelFilto.ForeColor = System.Drawing.Color.Black;
            this.labelFilto.Location = new System.Drawing.Point(5, 4);
            this.labelFilto.Name = "labelFilto";
            this.labelFilto.Size = new System.Drawing.Size(105, 13);
            this.labelFilto.TabIndex = 10;
            this.labelFilto.Text = "FILTRO DE BUSCA:";
            // 
            // groupBoxFiltroCadastro
            // 
            this.groupBoxFiltroCadastro.Controls.Add(this.checkBoxAtivo);
            this.groupBoxFiltroCadastro.Controls.Add(this.checkBoxCliente);
            this.groupBoxFiltroCadastro.Controls.Add(this.checkBoxFuncionario);
            this.groupBoxFiltroCadastro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxFiltroCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltroCadastro.ForeColor = System.Drawing.Color.Brown;
            this.groupBoxFiltroCadastro.Location = new System.Drawing.Point(113, -6);
            this.groupBoxFiltroCadastro.Name = "groupBoxFiltroCadastro";
            this.groupBoxFiltroCadastro.Size = new System.Drawing.Size(205, 27);
            this.groupBoxFiltroCadastro.TabIndex = 8;
            this.groupBoxFiltroCadastro.TabStop = false;
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAtivo.Location = new System.Drawing.Point(154, 8);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAtivo.TabIndex = 11;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // checkBoxCliente
            // 
            this.checkBoxCliente.AutoSize = true;
            this.checkBoxCliente.ForeColor = System.Drawing.Color.Black;
            this.checkBoxCliente.Location = new System.Drawing.Point(92, 8);
            this.checkBoxCliente.Name = "checkBoxCliente";
            this.checkBoxCliente.Size = new System.Drawing.Size(58, 17);
            this.checkBoxCliente.TabIndex = 10;
            this.checkBoxCliente.Text = "Cliente";
            this.checkBoxCliente.UseVisualStyleBackColor = true;
            // 
            // checkBoxFuncionario
            // 
            this.checkBoxFuncionario.AutoSize = true;
            this.checkBoxFuncionario.ForeColor = System.Drawing.Color.Black;
            this.checkBoxFuncionario.Location = new System.Drawing.Point(6, 8);
            this.checkBoxFuncionario.Name = "checkBoxFuncionario";
            this.checkBoxFuncionario.Size = new System.Drawing.Size(81, 17);
            this.checkBoxFuncionario.TabIndex = 0;
            this.checkBoxFuncionario.Text = "Funcionario";
            this.checkBoxFuncionario.UseVisualStyleBackColor = true;
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToResizeColumns = false;
            this.usuarioDataGridView.AllowUserToResizeRows = false;
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.usuarioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usuarioDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.usuarioDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomeCompletoDataGridViewTextBoxColumn1,
            this.cpfDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.funcionarioDataGridViewCheckBoxColumn,
            this.clienteDataGridViewCheckBoxColumn,
            this.ativoDataGridViewCheckBoxColumn});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuarioDataGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.usuarioDataGridView.Location = new System.Drawing.Point(3, 29);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuarioDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.usuarioDataGridView.RowHeadersVisible = false;
            this.usuarioDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.usuarioDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.usuarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.usuarioDataGridView.Size = new System.Drawing.Size(834, 459);
            this.usuarioDataGridView.TabIndex = 6;
            this.usuarioDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuarioDataGridView_CellClick);
            this.usuarioDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuarioDataGridView_CellDoubleClick);
            this.usuarioDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usuarioDataGridView_MouseClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "COD";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 50;
            // 
            // nomeCompletoDataGridViewTextBoxColumn1
            // 
            this.nomeCompletoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeCompletoDataGridViewTextBoxColumn1.DataPropertyName = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn1.HeaderText = "NOME";
            this.nomeCompletoDataGridViewTextBoxColumn1.Name = "nomeCompletoDataGridViewTextBoxColumn1";
            this.nomeCompletoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-MAIL";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // funcionarioDataGridViewCheckBoxColumn
            // 
            this.funcionarioDataGridViewCheckBoxColumn.DataPropertyName = "Funcionario";
            this.funcionarioDataGridViewCheckBoxColumn.HeaderText = "FUNCIONARIO";
            this.funcionarioDataGridViewCheckBoxColumn.Name = "funcionarioDataGridViewCheckBoxColumn";
            this.funcionarioDataGridViewCheckBoxColumn.ReadOnly = true;
            this.funcionarioDataGridViewCheckBoxColumn.Width = 85;
            // 
            // clienteDataGridViewCheckBoxColumn
            // 
            this.clienteDataGridViewCheckBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewCheckBoxColumn.HeaderText = "CLIENTE";
            this.clienteDataGridViewCheckBoxColumn.Name = "clienteDataGridViewCheckBoxColumn";
            this.clienteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.clienteDataGridViewCheckBoxColumn.Width = 55;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "ATIVO";
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn.Width = 45;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Model.Usuario);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Black;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarToolStripMenuItem,
            this.toolStripMenuItemNovo,
            this.imprimirToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.cadastrarPessoaToolStripMenuItem,
            this.deletarPessoaToolStripMenuItem,
            this.editarPessoaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 2, 0, 6);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.ShowItemToolTips = true;
            this.menuStrip2.Size = new System.Drawing.Size(854, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Image = global::UIPrincipal.Properties.Resources.table_refresh;
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.atualizarToolStripMenuItem.ToolTipText = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // toolStripMenuItemNovo
            // 
            this.toolStripMenuItemNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemNovo.Image = global::UIPrincipal.Properties.Resources.page_add;
            this.toolStripMenuItemNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItemNovo.Name = "toolStripMenuItemNovo";
            this.toolStripMenuItemNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItemNovo.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItemNovo.Text = "&Novo";
            this.toolStripMenuItemNovo.ToolTipText = "Nova O.S";
            this.toolStripMenuItemNovo.Click += new System.EventHandler(this.toolStripMenuItemNovo_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripMenuItem.Image = global::UIPrincipal.Properties.Resources.page_white_magnify;
            this.imprimirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imprimirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.imprimirToolStripMenuItem.ToolTipText = "Visualizar Impressão";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::UIPrincipal.Properties.Resources.user;
            this.clientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.clientesToolStripMenuItem.ToolTipText = "Consultar Cadastros";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // cadastrarPessoaToolStripMenuItem
            // 
            this.cadastrarPessoaToolStripMenuItem.Image = global::UIPrincipal.Properties.Resources.user_add;
            this.cadastrarPessoaToolStripMenuItem.Name = "cadastrarPessoaToolStripMenuItem";
            this.cadastrarPessoaToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.cadastrarPessoaToolStripMenuItem.ToolTipText = "Cadastrar Pessoa";
            this.cadastrarPessoaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPessoaToolStripMenuItem_Click);
            // 
            // deletarPessoaToolStripMenuItem
            // 
            this.deletarPessoaToolStripMenuItem.Image = global::UIPrincipal.Properties.Resources.user_delete;
            this.deletarPessoaToolStripMenuItem.Name = "deletarPessoaToolStripMenuItem";
            this.deletarPessoaToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.deletarPessoaToolStripMenuItem.ToolTipText = "Deletar Cadastro";
            this.deletarPessoaToolStripMenuItem.Visible = false;
            this.deletarPessoaToolStripMenuItem.Click += new System.EventHandler(this.deletarPessoaToolStripMenuItem_Click);
            // 
            // editarPessoaToolStripMenuItem
            // 
            this.editarPessoaToolStripMenuItem.Image = global::UIPrincipal.Properties.Resources.user_edit;
            this.editarPessoaToolStripMenuItem.Name = "editarPessoaToolStripMenuItem";
            this.editarPessoaToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.editarPessoaToolStripMenuItem.ToolTipText = "Editar Cadastro";
            this.editarPessoaToolStripMenuItem.Visible = false;
            this.editarPessoaToolStripMenuItem.Click += new System.EventHandler(this.editarPessoaToolStripMenuItem_Click);
            // 
            // contextMenuStripAbaDois
            // 
            this.contextMenuStripAbaDois.AccessibleRole = System.Windows.Forms.AccessibleRole.Cell;
            this.contextMenuStripAbaDois.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirOSToolStripMenuItem,
            this.editarCadastroToolStripMenuItem,
            this.copiarAbaDoisToolStripMenuItem});
            this.contextMenuStripAbaDois.Name = "contextMenuStripTelaPrincipal";
            this.contextMenuStripAbaDois.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripAbaDois.Size = new System.Drawing.Size(155, 70);
            // 
            // abrirOSToolStripMenuItem
            // 
            this.abrirOSToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Cell;
            this.abrirOSToolStripMenuItem.Name = "abrirOSToolStripMenuItem";
            this.abrirOSToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.abrirOSToolStripMenuItem.Text = "Abrir O.S";
            this.abrirOSToolStripMenuItem.Click += new System.EventHandler(this.abrirOSToolStripMenuItem_Click);
            // 
            // editarCadastroToolStripMenuItem
            // 
            this.editarCadastroToolStripMenuItem.Name = "editarCadastroToolStripMenuItem";
            this.editarCadastroToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editarCadastroToolStripMenuItem.Text = "Editar Cadastro";
            this.editarCadastroToolStripMenuItem.Click += new System.EventHandler(this.editarCadastroToolStripMenuItem_Click);
            // 
            // copiarAbaDoisToolStripMenuItem
            // 
            this.copiarAbaDoisToolStripMenuItem.Name = "copiarAbaDoisToolStripMenuItem";
            this.copiarAbaDoisToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.copiarAbaDoisToolStripMenuItem.Text = "Copiar";
            this.copiarAbaDoisToolStripMenuItem.Click += new System.EventHandler(this.copiarAbaDoisToolStripMenuItem_Click);
            // 
            // sP_BuscarOSPendenteTableAdapter
            // 
            this.sP_BuscarOSPendenteTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStripAbaUm
            // 
            this.contextMenuStripAbaUm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarDetalhesToolStripMenuItem,
            this.impressãoDiretaToolStripMenuItem,
            this.copiarToolStripMenuItem});
            this.contextMenuStripAbaUm.Name = "contextMenuStripAbaUm";
            this.contextMenuStripAbaUm.Size = new System.Drawing.Size(172, 70);
            // 
            // visualizarDetalhesToolStripMenuItem
            // 
            this.visualizarDetalhesToolStripMenuItem.Name = "visualizarDetalhesToolStripMenuItem";
            this.visualizarDetalhesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.visualizarDetalhesToolStripMenuItem.Text = "Visualizar Detalhes";
            this.visualizarDetalhesToolStripMenuItem.Click += new System.EventHandler(this.visualizarDetalhesToolStripMenuItem_Click);
            // 
            // impressãoDiretaToolStripMenuItem
            // 
            this.impressãoDiretaToolStripMenuItem.Name = "impressãoDiretaToolStripMenuItem";
            this.impressãoDiretaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.impressãoDiretaToolStripMenuItem.Text = "Impressão Direta";
            this.impressãoDiretaToolStripMenuItem.Click += new System.EventHandler(this.impressãoDiretaToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(854, 600);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(854, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA O.S";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            this.tabControlConsulta.ResumeLayout(false);
            this.tabPageOSPendentes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOSAbertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBuscarOSPendenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDEMSERVICODataSetOsPendente)).EndInit();
            this.tabPageCadastrados.ResumeLayout(false);
            this.panelFiltroPessoa.ResumeLayout(false);
            this.panelFiltroPessoa.PerformLayout();
            this.groupBoxFiltroCadastro.ResumeLayout(false);
            this.groupBoxFiltroCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.contextMenuStripAbaDois.ResumeLayout(false);
            this.contextMenuStripAbaUm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gRUPODEUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJUDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOBREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsuario;
        private System.Windows.Forms.ToolStripMenuItem pLANOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIPODECHAMADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNovo;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deligarToolStripMenuItem;
        private ORDEMSERVICODataSetOsPendente oRDEMSERVICODataSetOsPendente;
        private System.Windows.Forms.BindingSource sPBuscarOSPendenteBindingSource;
        private ORDEMSERVICODataSetOsPendenteTableAdapters.SP_BuscarOSPendenteTableAdapter sP_BuscarOSPendenteTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.Button buttonBuscarCadastro;
        private System.Windows.Forms.TextBox textBoxBuscarCadastro;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAbaDois;
        private System.Windows.Forms.ToolStripMenuItem abrirOSToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlConsulta;
        private System.Windows.Forms.TabPage tabPageOSPendentes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxEncaminhado;
        private System.Windows.Forms.CheckBox checkBoxAberto;
        private System.Windows.Forms.DataGridView dataGridViewOSAbertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoChamadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrazoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPageCadastrados;
        private System.Windows.Forms.Panel panelFiltroPessoa;
        private System.Windows.Forms.Label labelFilto;
        private System.Windows.Forms.GroupBox groupBoxFiltroCadastro;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.CheckBox checkBoxCliente;
        private System.Windows.Forms.CheckBox checkBoxFuncionario;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn funcionarioDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clienteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button buttonFecharAba;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAbaUm;
        private System.Windows.Forms.ToolStripMenuItem visualizarDetalhesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressãoDiretaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarAbaDoisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPessoaToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxFechada;
    }
}