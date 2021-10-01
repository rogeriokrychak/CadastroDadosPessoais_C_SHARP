
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
            this.campoUF = new System.Windows.Forms.ComboBox();
            this.campoData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.campoSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.campoEndereço = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoCEP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CampoEmail = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campoUF
            // 
            this.campoUF.FormattingEnabled = true;
            this.campoUF.Items.AddRange(new object[] {
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
            this.campoUF.Location = new System.Drawing.Point(455, 210);
            this.campoUF.Name = "campoUF";
            this.campoUF.Size = new System.Drawing.Size(151, 28);
            this.campoUF.TabIndex = 0;
            // 
            // campoData
            // 
            this.campoData.Location = new System.Drawing.Point(75, 274);
            this.campoData.Name = "campoData";
            this.campoData.Size = new System.Drawing.Size(312, 27);
            this.campoData.TabIndex = 1;
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
            // campoEndereço
            // 
            this.campoEndereço.Location = new System.Drawing.Point(75, 141);
            this.campoEndereço.Name = "campoEndereço";
            this.campoEndereço.Size = new System.Drawing.Size(406, 27);
            this.campoEndereço.TabIndex = 8;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(455, 274);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "MASCULINO";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(575, 274);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 24);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "FEMININO";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(681, 274);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 24);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "OUTROS";
            this.checkBox3.UseVisualStyleBackColor = true;
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
            // campoTelefone
            // 
            this.campoTelefone.Location = new System.Drawing.Point(75, 346);
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(262, 27);
            this.campoTelefone.TabIndex = 20;
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
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(609, 466);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(160, 59);
            this.btnEnviar.TabIndex = 23;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(425, 466);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 59);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.CampoEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.campoTelefone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.campoCEP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoEndereço);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.campoSobrenome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoData);
            this.Controls.Add(this.campoUF);
            this.Name = "Form1";
            this.Text = "FORMULÁRIO DE DADOS PESSOAIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox campoUF;
        private System.Windows.Forms.DateTimePicker campoData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoEndereço;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoCEP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CampoEmail;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

