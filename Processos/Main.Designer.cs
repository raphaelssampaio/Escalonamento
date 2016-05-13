namespace Processos
{
    partial class EscalonamentoDeProcessos
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
            this.pProcessos = new System.Windows.Forms.Panel();
            this.tbxQuantum = new System.Windows.Forms.TextBox();
            this.chkbxQuantum = new System.Windows.Forms.CheckBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gbxProcessos = new System.Windows.Forms.GroupBox();
            this.tbxEsperaP4 = new System.Windows.Forms.TextBox();
            this.lbTempoEsperaP4 = new System.Windows.Forms.Label();
            this.tbxEsperaP3 = new System.Windows.Forms.TextBox();
            this.lbTempoEsperaP3 = new System.Windows.Forms.Label();
            this.tbxEsperaP2 = new System.Windows.Forms.TextBox();
            this.lbTempoEsperaP2 = new System.Windows.Forms.Label();
            this.tbxEsperaP1 = new System.Windows.Forms.TextBox();
            this.lbTempoEsperaP1 = new System.Windows.Forms.Label();
            this.lbTempoTurnAroundMedio = new System.Windows.Forms.Label();
            this.lbTempoMedioEspera = new System.Windows.Forms.Label();
            this.tbxChegadaP4 = new System.Windows.Forms.TextBox();
            this.tbxChegadaP3 = new System.Windows.Forms.TextBox();
            this.tbxChegadaP2 = new System.Windows.Forms.TextBox();
            this.tbxChegadaP1 = new System.Windows.Forms.TextBox();
            this.lbChegadaP4 = new System.Windows.Forms.Label();
            this.lbChegadaP3 = new System.Windows.Forms.Label();
            this.lbChegadaP2 = new System.Windows.Forms.Label();
            this.lbChegadaP1 = new System.Windows.Forms.Label();
            this.lbPico4 = new System.Windows.Forms.Label();
            this.lbPico3 = new System.Windows.Forms.Label();
            this.lbPico2 = new System.Windows.Forms.Label();
            this.lbPico1 = new System.Windows.Forms.Label();
            this.tbxP4 = new System.Windows.Forms.TextBox();
            this.tbxP3 = new System.Windows.Forms.TextBox();
            this.tbxP2 = new System.Windows.Forms.TextBox();
            this.tbxP1 = new System.Windows.Forms.TextBox();
            this.lbP4 = new System.Windows.Forms.Label();
            this.lbP3 = new System.Windows.Forms.Label();
            this.lbP2 = new System.Windows.Forms.Label();
            this.lbP1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxProcessos = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pProcessos.SuspendLayout();
            this.gbxProcessos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pProcessos
            // 
            this.pProcessos.BackColor = System.Drawing.Color.GhostWhite;
            this.pProcessos.Controls.Add(this.btnCalcular);
            this.pProcessos.Controls.Add(this.tbxQuantum);
            this.pProcessos.Controls.Add(this.chkbxQuantum);
            this.pProcessos.Controls.Add(this.btnExcluir);
            this.pProcessos.Controls.Add(this.btnNovo);
            this.pProcessos.Controls.Add(this.gbxProcessos);
            this.pProcessos.Controls.Add(this.label1);
            this.pProcessos.Controls.Add(this.cbxProcessos);
            this.pProcessos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pProcessos.Location = new System.Drawing.Point(0, 0);
            this.pProcessos.Name = "pProcessos";
            this.pProcessos.Size = new System.Drawing.Size(555, 308);
            this.pProcessos.TabIndex = 2;
            // 
            // tbxQuantum
            // 
            this.tbxQuantum.Enabled = false;
            this.tbxQuantum.Location = new System.Drawing.Point(341, 32);
            this.tbxQuantum.Name = "tbxQuantum";
            this.tbxQuantum.Size = new System.Drawing.Size(37, 20);
            this.tbxQuantum.TabIndex = 8;
            // 
            // chkbxQuantum
            // 
            this.chkbxQuantum.AutoSize = true;
            this.chkbxQuantum.Location = new System.Drawing.Point(276, 35);
            this.chkbxQuantum.Name = "chkbxQuantum";
            this.chkbxQuantum.Size = new System.Drawing.Size(69, 17);
            this.chkbxQuantum.TabIndex = 7;
            this.chkbxQuantum.Text = "Quantum";
            this.chkbxQuantum.UseVisualStyleBackColor = true;
            this.chkbxQuantum.CheckedChanged += new System.EventHandler(this.chkbxQuantum_CheckedChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(470, 110);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(73, 30);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(470, 74);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(73, 30);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gbxProcessos
            // 
            this.gbxProcessos.Controls.Add(this.tbxEsperaP4);
            this.gbxProcessos.Controls.Add(this.lbTempoEsperaP4);
            this.gbxProcessos.Controls.Add(this.tbxEsperaP3);
            this.gbxProcessos.Controls.Add(this.lbTempoEsperaP3);
            this.gbxProcessos.Controls.Add(this.tbxEsperaP2);
            this.gbxProcessos.Controls.Add(this.lbTempoEsperaP2);
            this.gbxProcessos.Controls.Add(this.tbxEsperaP1);
            this.gbxProcessos.Controls.Add(this.lbTempoEsperaP1);
            this.gbxProcessos.Controls.Add(this.lbTempoTurnAroundMedio);
            this.gbxProcessos.Controls.Add(this.lbTempoMedioEspera);
            this.gbxProcessos.Controls.Add(this.tbxChegadaP4);
            this.gbxProcessos.Controls.Add(this.tbxChegadaP3);
            this.gbxProcessos.Controls.Add(this.tbxChegadaP2);
            this.gbxProcessos.Controls.Add(this.tbxChegadaP1);
            this.gbxProcessos.Controls.Add(this.lbChegadaP4);
            this.gbxProcessos.Controls.Add(this.lbChegadaP3);
            this.gbxProcessos.Controls.Add(this.lbChegadaP2);
            this.gbxProcessos.Controls.Add(this.lbChegadaP1);
            this.gbxProcessos.Controls.Add(this.lbPico4);
            this.gbxProcessos.Controls.Add(this.lbPico3);
            this.gbxProcessos.Controls.Add(this.lbPico2);
            this.gbxProcessos.Controls.Add(this.lbPico1);
            this.gbxProcessos.Controls.Add(this.tbxP4);
            this.gbxProcessos.Controls.Add(this.tbxP3);
            this.gbxProcessos.Controls.Add(this.tbxP2);
            this.gbxProcessos.Controls.Add(this.tbxP1);
            this.gbxProcessos.Controls.Add(this.lbP4);
            this.gbxProcessos.Controls.Add(this.lbP3);
            this.gbxProcessos.Controls.Add(this.lbP2);
            this.gbxProcessos.Controls.Add(this.lbP1);
            this.gbxProcessos.Location = new System.Drawing.Point(21, 68);
            this.gbxProcessos.Name = "gbxProcessos";
            this.gbxProcessos.Size = new System.Drawing.Size(443, 237);
            this.gbxProcessos.TabIndex = 4;
            this.gbxProcessos.TabStop = false;
            // 
            // tbxEsperaP4
            // 
            this.tbxEsperaP4.Location = new System.Drawing.Point(358, 122);
            this.tbxEsperaP4.Name = "tbxEsperaP4";
            this.tbxEsperaP4.Size = new System.Drawing.Size(60, 20);
            this.tbxEsperaP4.TabIndex = 29;
            this.tbxEsperaP4.Visible = false;
            // 
            // lbTempoEsperaP4
            // 
            this.lbTempoEsperaP4.AutoSize = true;
            this.lbTempoEsperaP4.Location = new System.Drawing.Point(262, 127);
            this.lbTempoEsperaP4.Name = "lbTempoEsperaP4";
            this.lbTempoEsperaP4.Size = new System.Drawing.Size(90, 13);
            this.lbTempoEsperaP4.TabIndex = 28;
            this.lbTempoEsperaP4.Text = "Tempo de espera";
            this.lbTempoEsperaP4.Visible = false;
            // 
            // tbxEsperaP3
            // 
            this.tbxEsperaP3.Location = new System.Drawing.Point(358, 87);
            this.tbxEsperaP3.Name = "tbxEsperaP3";
            this.tbxEsperaP3.Size = new System.Drawing.Size(60, 20);
            this.tbxEsperaP3.TabIndex = 27;
            this.tbxEsperaP3.Visible = false;
            // 
            // lbTempoEsperaP3
            // 
            this.lbTempoEsperaP3.AutoSize = true;
            this.lbTempoEsperaP3.Location = new System.Drawing.Point(262, 92);
            this.lbTempoEsperaP3.Name = "lbTempoEsperaP3";
            this.lbTempoEsperaP3.Size = new System.Drawing.Size(90, 13);
            this.lbTempoEsperaP3.TabIndex = 26;
            this.lbTempoEsperaP3.Text = "Tempo de espera";
            this.lbTempoEsperaP3.Visible = false;
            // 
            // tbxEsperaP2
            // 
            this.tbxEsperaP2.Location = new System.Drawing.Point(358, 52);
            this.tbxEsperaP2.Name = "tbxEsperaP2";
            this.tbxEsperaP2.Size = new System.Drawing.Size(60, 20);
            this.tbxEsperaP2.TabIndex = 25;
            this.tbxEsperaP2.Visible = false;
            // 
            // lbTempoEsperaP2
            // 
            this.lbTempoEsperaP2.AutoSize = true;
            this.lbTempoEsperaP2.Location = new System.Drawing.Point(262, 57);
            this.lbTempoEsperaP2.Name = "lbTempoEsperaP2";
            this.lbTempoEsperaP2.Size = new System.Drawing.Size(90, 13);
            this.lbTempoEsperaP2.TabIndex = 24;
            this.lbTempoEsperaP2.Text = "Tempo de espera";
            this.lbTempoEsperaP2.Visible = false;
            // 
            // tbxEsperaP1
            // 
            this.tbxEsperaP1.Location = new System.Drawing.Point(358, 17);
            this.tbxEsperaP1.Name = "tbxEsperaP1";
            this.tbxEsperaP1.Size = new System.Drawing.Size(60, 20);
            this.tbxEsperaP1.TabIndex = 23;
            this.tbxEsperaP1.Visible = false;
            // 
            // lbTempoEsperaP1
            // 
            this.lbTempoEsperaP1.AutoSize = true;
            this.lbTempoEsperaP1.Location = new System.Drawing.Point(262, 22);
            this.lbTempoEsperaP1.Name = "lbTempoEsperaP1";
            this.lbTempoEsperaP1.Size = new System.Drawing.Size(90, 13);
            this.lbTempoEsperaP1.TabIndex = 22;
            this.lbTempoEsperaP1.Text = "Tempo de espera";
            this.lbTempoEsperaP1.Visible = false;
            // 
            // lbTempoTurnAroundMedio
            // 
            this.lbTempoTurnAroundMedio.AutoSize = true;
            this.lbTempoTurnAroundMedio.Location = new System.Drawing.Point(242, 184);
            this.lbTempoTurnAroundMedio.Name = "lbTempoTurnAroundMedio";
            this.lbTempoTurnAroundMedio.Size = new System.Drawing.Size(140, 13);
            this.lbTempoTurnAroundMedio.TabIndex = 21;
            this.lbTempoTurnAroundMedio.Text = "Tempo de turnaround médio";
            // 
            // lbTempoMedioEspera
            // 
            this.lbTempoMedioEspera.AutoSize = true;
            this.lbTempoMedioEspera.Location = new System.Drawing.Point(23, 184);
            this.lbTempoMedioEspera.Name = "lbTempoMedioEspera";
            this.lbTempoMedioEspera.Size = new System.Drawing.Size(121, 13);
            this.lbTempoMedioEspera.TabIndex = 20;
            this.lbTempoMedioEspera.Text = "Tempo de espera médio";
            // 
            // tbxChegadaP4
            // 
            this.tbxChegadaP4.Location = new System.Drawing.Point(196, 122);
            this.tbxChegadaP4.Name = "tbxChegadaP4";
            this.tbxChegadaP4.Size = new System.Drawing.Size(60, 20);
            this.tbxChegadaP4.TabIndex = 19;
            this.tbxChegadaP4.Visible = false;
            // 
            // tbxChegadaP3
            // 
            this.tbxChegadaP3.Location = new System.Drawing.Point(196, 87);
            this.tbxChegadaP3.Name = "tbxChegadaP3";
            this.tbxChegadaP3.Size = new System.Drawing.Size(60, 20);
            this.tbxChegadaP3.TabIndex = 18;
            this.tbxChegadaP3.Visible = false;
            // 
            // tbxChegadaP2
            // 
            this.tbxChegadaP2.Location = new System.Drawing.Point(196, 52);
            this.tbxChegadaP2.Name = "tbxChegadaP2";
            this.tbxChegadaP2.Size = new System.Drawing.Size(60, 20);
            this.tbxChegadaP2.TabIndex = 17;
            this.tbxChegadaP2.Visible = false;
            // 
            // tbxChegadaP1
            // 
            this.tbxChegadaP1.Location = new System.Drawing.Point(196, 17);
            this.tbxChegadaP1.Name = "tbxChegadaP1";
            this.tbxChegadaP1.Size = new System.Drawing.Size(60, 20);
            this.tbxChegadaP1.TabIndex = 16;
            this.tbxChegadaP1.Visible = false;
            // 
            // lbChegadaP4
            // 
            this.lbChegadaP4.AutoSize = true;
            this.lbChegadaP4.Location = new System.Drawing.Point(140, 127);
            this.lbChegadaP4.Name = "lbChegadaP4";
            this.lbChegadaP4.Size = new System.Drawing.Size(50, 13);
            this.lbChegadaP4.TabIndex = 15;
            this.lbChegadaP4.Text = "Chegada";
            this.lbChegadaP4.Visible = false;
            // 
            // lbChegadaP3
            // 
            this.lbChegadaP3.AutoSize = true;
            this.lbChegadaP3.Location = new System.Drawing.Point(140, 92);
            this.lbChegadaP3.Name = "lbChegadaP3";
            this.lbChegadaP3.Size = new System.Drawing.Size(50, 13);
            this.lbChegadaP3.TabIndex = 14;
            this.lbChegadaP3.Text = "Chegada";
            this.lbChegadaP3.Visible = false;
            // 
            // lbChegadaP2
            // 
            this.lbChegadaP2.AutoSize = true;
            this.lbChegadaP2.Location = new System.Drawing.Point(140, 57);
            this.lbChegadaP2.Name = "lbChegadaP2";
            this.lbChegadaP2.Size = new System.Drawing.Size(50, 13);
            this.lbChegadaP2.TabIndex = 13;
            this.lbChegadaP2.Text = "Chegada";
            this.lbChegadaP2.Visible = false;
            // 
            // lbChegadaP1
            // 
            this.lbChegadaP1.AutoSize = true;
            this.lbChegadaP1.Location = new System.Drawing.Point(140, 22);
            this.lbChegadaP1.Name = "lbChegadaP1";
            this.lbChegadaP1.Size = new System.Drawing.Size(50, 13);
            this.lbChegadaP1.TabIndex = 12;
            this.lbChegadaP1.Text = "Chegada";
            this.lbChegadaP1.Visible = false;
            // 
            // lbPico4
            // 
            this.lbPico4.AutoSize = true;
            this.lbPico4.Location = new System.Drawing.Point(40, 127);
            this.lbPico4.Name = "lbPico4";
            this.lbPico4.Size = new System.Drawing.Size(28, 13);
            this.lbPico4.TabIndex = 11;
            this.lbPico4.Text = "Pico";
            this.lbPico4.Visible = false;
            // 
            // lbPico3
            // 
            this.lbPico3.AutoSize = true;
            this.lbPico3.Location = new System.Drawing.Point(40, 92);
            this.lbPico3.Name = "lbPico3";
            this.lbPico3.Size = new System.Drawing.Size(28, 13);
            this.lbPico3.TabIndex = 10;
            this.lbPico3.Text = "Pico";
            this.lbPico3.Visible = false;
            // 
            // lbPico2
            // 
            this.lbPico2.AutoSize = true;
            this.lbPico2.Location = new System.Drawing.Point(40, 57);
            this.lbPico2.Name = "lbPico2";
            this.lbPico2.Size = new System.Drawing.Size(28, 13);
            this.lbPico2.TabIndex = 9;
            this.lbPico2.Text = "Pico";
            this.lbPico2.Visible = false;
            // 
            // lbPico1
            // 
            this.lbPico1.AutoSize = true;
            this.lbPico1.Location = new System.Drawing.Point(40, 22);
            this.lbPico1.Name = "lbPico1";
            this.lbPico1.Size = new System.Drawing.Size(28, 13);
            this.lbPico1.TabIndex = 8;
            this.lbPico1.Text = "Pico";
            this.lbPico1.Visible = false;
            // 
            // tbxP4
            // 
            this.tbxP4.Location = new System.Drawing.Point(70, 122);
            this.tbxP4.Name = "tbxP4";
            this.tbxP4.Size = new System.Drawing.Size(60, 20);
            this.tbxP4.TabIndex = 7;
            this.tbxP4.Visible = false;
            // 
            // tbxP3
            // 
            this.tbxP3.Location = new System.Drawing.Point(70, 87);
            this.tbxP3.Name = "tbxP3";
            this.tbxP3.Size = new System.Drawing.Size(60, 20);
            this.tbxP3.TabIndex = 6;
            this.tbxP3.Visible = false;
            // 
            // tbxP2
            // 
            this.tbxP2.Location = new System.Drawing.Point(70, 52);
            this.tbxP2.Name = "tbxP2";
            this.tbxP2.Size = new System.Drawing.Size(60, 20);
            this.tbxP2.TabIndex = 5;
            this.tbxP2.Visible = false;
            // 
            // tbxP1
            // 
            this.tbxP1.Location = new System.Drawing.Point(70, 17);
            this.tbxP1.Name = "tbxP1";
            this.tbxP1.Size = new System.Drawing.Size(60, 20);
            this.tbxP1.TabIndex = 4;
            this.tbxP1.Visible = false;
            // 
            // lbP4
            // 
            this.lbP4.AutoSize = true;
            this.lbP4.Location = new System.Drawing.Point(14, 127);
            this.lbP4.Name = "lbP4";
            this.lbP4.Size = new System.Drawing.Size(20, 13);
            this.lbP4.TabIndex = 3;
            this.lbP4.Text = "P4";
            this.lbP4.Visible = false;
            // 
            // lbP3
            // 
            this.lbP3.AutoSize = true;
            this.lbP3.Location = new System.Drawing.Point(14, 92);
            this.lbP3.Name = "lbP3";
            this.lbP3.Size = new System.Drawing.Size(20, 13);
            this.lbP3.TabIndex = 2;
            this.lbP3.Text = "P3";
            this.lbP3.Visible = false;
            // 
            // lbP2
            // 
            this.lbP2.AutoSize = true;
            this.lbP2.Location = new System.Drawing.Point(14, 57);
            this.lbP2.Name = "lbP2";
            this.lbP2.Size = new System.Drawing.Size(20, 13);
            this.lbP2.TabIndex = 1;
            this.lbP2.Text = "P2";
            this.lbP2.Visible = false;
            // 
            // lbP1
            // 
            this.lbP1.AutoSize = true;
            this.lbP1.Location = new System.Drawing.Point(14, 22);
            this.lbP1.Name = "lbP1";
            this.lbP1.Size = new System.Drawing.Size(20, 13);
            this.lbP1.TabIndex = 0;
            this.lbP1.Text = "P1";
            this.lbP1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de processo";
            // 
            // cbxProcessos
            // 
            this.cbxProcessos.FormattingEnabled = true;
            this.cbxProcessos.Items.AddRange(new object[] {
            "FIFO",
            "SJF com preempção",
            "SJF sem preempção",
            "Round Robin",
            "Prioridade Windows",
            "Prioridade LINUX"});
            this.cbxProcessos.Location = new System.Drawing.Point(122, 32);
            this.cbxProcessos.Name = "cbxProcessos";
            this.cbxProcessos.Size = new System.Drawing.Size(121, 21);
            this.cbxProcessos.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(470, 206);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(73, 30);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // EscalonamentoDeProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 308);
            this.Controls.Add(this.pProcessos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EscalonamentoDeProcessos";
            this.Text = "Escalonamento de Processos";
            this.pProcessos.ResumeLayout(false);
            this.pProcessos.PerformLayout();
            this.gbxProcessos.ResumeLayout(false);
            this.gbxProcessos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pProcessos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProcessos;
        private System.Windows.Forms.GroupBox gbxProcessos;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox tbxP4;
        private System.Windows.Forms.TextBox tbxP3;
        private System.Windows.Forms.TextBox tbxP2;
        private System.Windows.Forms.TextBox tbxP1;
        private System.Windows.Forms.Label lbP4;
        private System.Windows.Forms.Label lbP3;
        private System.Windows.Forms.Label lbP2;
        private System.Windows.Forms.Label lbP1;
        private System.Windows.Forms.Label lbPico4;
        private System.Windows.Forms.Label lbPico3;
        private System.Windows.Forms.Label lbPico2;
        private System.Windows.Forms.Label lbPico1;
        private System.Windows.Forms.Label lbChegadaP2;
        private System.Windows.Forms.Label lbChegadaP1;
        private System.Windows.Forms.Label lbChegadaP4;
        private System.Windows.Forms.Label lbChegadaP3;
        private System.Windows.Forms.TextBox tbxChegadaP3;
        private System.Windows.Forms.TextBox tbxChegadaP2;
        private System.Windows.Forms.TextBox tbxChegadaP1;
        private System.Windows.Forms.TextBox tbxChegadaP4;
        private System.Windows.Forms.TextBox tbxQuantum;
        private System.Windows.Forms.CheckBox chkbxQuantum;
        private System.Windows.Forms.Label lbTempoEsperaP1;
        private System.Windows.Forms.Label lbTempoTurnAroundMedio;
        private System.Windows.Forms.Label lbTempoMedioEspera;
        private System.Windows.Forms.TextBox tbxEsperaP1;
        private System.Windows.Forms.TextBox tbxEsperaP4;
        private System.Windows.Forms.Label lbTempoEsperaP4;
        private System.Windows.Forms.Label lbTempoEsperaP3;
        private System.Windows.Forms.TextBox tbxEsperaP2;
        private System.Windows.Forms.Label lbTempoEsperaP2;
        private System.Windows.Forms.TextBox tbxEsperaP3;
        private System.Windows.Forms.Button btnCalcular;
    }
}

