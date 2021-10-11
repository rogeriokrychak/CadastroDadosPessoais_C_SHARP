
namespace CadastroDadosPessoais
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboEstados = new System.Windows.Forms.ComboBox();
            this.campoData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.campoSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.campoEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoCEP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.campoFone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CampoEmail = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.radioFeminino = new System.Windows.Forms.RadioButton();
            this.radioOutros = new System.Windows.Forms.RadioButton();
            this.btnSalve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboEstados
            // 
            this.comboEstados.FormattingEnabled = true;
            this.comboEstados.Items.AddRange(new object[] {
            "AC",
            "AM",
            "RR",
            "PA",
            "TO",
            "DF",
            "MS",
            "MT",
            "MG",
            "RJ",
            "ES",
            "SP",
            "RG",
            "PR"});
            this.comboEstados.Location = new System.Drawing.Point(455, 210);
            this.comboEstados.Name = "comboEstados";
            this.comboEstados.Size = new System.Drawing.Size(151, 28);
            this.comboEstados.TabIndex = 0;
            // 
            // campoData
            // 
            this.campoData.Location = new System.Drawing.Point(75, 274);
            this.campoData.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.campoData.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.campoData.Name = "campoData";
            this.campoData.Size = new System.Drawing.Size(312, 27);
            this.campoData.TabIndex = 1;
            this.campoData.Value = new System.DateTime(2021, 10, 11, 20, 35, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOME";
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(75, 69);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(262, 27);
            this.campoNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SOBRENOME";
            // 
            // campoSobrenome
            // 
            this.campoSobrenome.Location = new System.Drawing.Point(372, 69);
            this.campoSobrenome.Name = "campoSobrenome";
            this.campoSobrenome.Size = new System.Drawing.Size(262, 27);
            this.campoSobrenome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "CADASTRO DE DADOS PESSOAIS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ENDEREÇO";
            // 
            // campoEndereco
            // 
            this.campoEndereco.Location = new System.Drawing.Point(75, 141);
            this.campoEndereco.Name = "campoEndereco";
            this.campoEndereco.Size = new System.Drawing.Size(406, 27);
            this.campoEndereco.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "CIDADE";
            // 
            // campoCidade
            // 
            this.campoCidade.Location = new System.Drawing.Point(504, 141);
            this.campoCidade.Name = "campoCidade";
            this.campoCidade.Size = new System.Drawing.Size(262, 27);
            this.campoCidade.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "CEP";
            // 
            // campoCEP
            // 
            this.campoCEP.Location = new System.Drawing.Point(75, 211);
            this.campoCEP.Name = "campoCEP";
            this.campoCEP.Size = new System.Drawing.Size(262, 27);
            this.campoCEP.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "DATA DE NASC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "ORIENTAÇÃO SEXUAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "TELEFONE";
            // 
            // campoFone
            // 
            this.campoFone.Location = new System.Drawing.Point(75, 346);
            this.campoFone.Name = "campoFone";
            this.campoFone.Size = new System.Drawing.Size(262, 27);
            this.campoFone.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "EMAIL";
            // 
            // CampoEmail
            // 
            this.CampoEmail.Location = new System.Drawing.Point(455, 346);
            this.CampoEmail.Name = "CampoEmail";
            this.CampoEmail.Size = new System.Drawing.Size(262, 27);
            this.CampoEmail.TabIndex = 22;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(609, 466);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 59);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Location = new System.Drawing.Point(455, 277);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(113, 24);
            this.radioMasculino.TabIndex = 25;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "MASCULINO";
            this.radioMasculino.UseVisualStyleBackColor = true;
            this.radioMasculino.CheckedChanged += new System.EventHandler(this.radioMasculino_CheckedChanged);
            // 
            // radioFeminino
            // 
            this.radioFeminino.AutoSize = true;
            this.radioFeminino.Location = new System.Drawing.Point(578, 277);
            this.radioFeminino.Name = "radioFeminino";
            this.radioFeminino.Size = new System.Drawing.Size(99, 24);
            this.radioFeminino.TabIndex = 26;
            this.radioFeminino.TabStop = true;
            this.radioFeminino.Text = "FEMININO";
            this.radioFeminino.UseVisualStyleBackColor = true;
            this.radioFeminino.CheckedChanged += new System.EventHandler(this.radioFeminino_CheckedChanged);
            // 
            // radioOutros
            // 
            this.radioOutros.AutoSize = true;
            this.radioOutros.Location = new System.Drawing.Point(679, 277);
            this.radioOutros.Name = "radioOutros";
            this.radioOutros.Size = new System.Drawing.Size(87, 24);
            this.radioOutros.TabIndex = 27;
            this.radioOutros.TabStop = true;
            this.radioOutros.Text = "OUTROS";
            this.radioOutros.UseVisualStyleBackColor = true;
            this.radioOutros.CheckedChanged += new System.EventHandler(this.radioOutros_CheckedChanged);
            // 
            // btnSalve
            // 
            this.btnSalve.Location = new System.Drawing.Point(434, 466);
            this.btnSalve.Name = "btnSalve";
            this.btnSalve.Size = new System.Drawing.Size(158, 59);
            this.btnSalve.TabIndex = 29;
            this.btnSalve.Text = "SALVAR";
            this.btnSalve.UseVisualStyleBackColor = true;
            this.btnSalve.Click += new System.EventHandler(this.btnSalve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.btnSalve);
            this.Controls.Add(this.radioOutros);
            this.Controls.Add(this.radioFeminino);
            this.Controls.Add(this.radioMasculino);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.CampoEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.campoFone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.campoCEP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.campoSobrenome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoData);
            this.Controls.Add(this.comboEstados);
            this.Name = "Form1";
            this.Text = "FORMULÁRIO DE DADOS PESSOAIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEstados;
        private System.Windows.Forms.DateTimePicker campoData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoCEP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox campoFone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CampoEmail;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.RadioButton radioFeminino;
        private System.Windows.Forms.RadioButton radioOutros;
        private System.Windows.Forms.Button btnSalve;
    }
}

