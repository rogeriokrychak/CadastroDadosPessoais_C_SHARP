using CadastroDadosPessoais.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDadosPessoais
{
    public partial class Form1 : Form
    {

        //cria uma variável global
        string opcao;//esta variável recebe a opção do sexo selecionado.

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalve_Click(object sender, EventArgs e)
        {
            string nome = campoNome.Text;
            string sobrenome = campoSobrenome.Text;
            string endereco = campoEndereco.Text;
            string cidade = campoCidade.Text;
            string cep = campoCEP.Text;
            string uf = comboEstados.SelectedItem.ToString();
            string data = campoData.Value.ToShortDateString();
            string telefone = campoFone.Text;
            string email = CampoEmail.Text;
            MessageBox.Show("Dados digitados:\n" + nome + " " + sobrenome + " " + endereco + " "
                + cep + " " + uf + " " + data + " " + telefone + " " + email + " " + opcao + " ");

            //usando a classe Pessoa para coletar os dados
            Pessoa p = new Pessoa();
            p.nome = campoNome.Text;
            p.sobrenome = campoSobrenome.Text;
            p.endereco = campoEndereco.Text;
            p.cidade = campoCidade.Text;
            p.cep = campoCEP.Text;
            p.uf = comboEstados.SelectedItem.ToString(); 
            p.data = campoData.Value.ToShortDateString();
            p.telefone = campoFone.Text;
            p.email = CampoEmail.Text;
            p.orientacao = opcao;

            //exibir dados do objeto:
            Console.WriteLine(p.nome);
            Console.WriteLine(p.sobrenome);
            Console.WriteLine(p.endereco);
            Console.WriteLine(p.cidade);
            Console.WriteLine(p.cep);
            Console.WriteLine(p.uf);
            Console.WriteLine(p.data);
            Console.WriteLine(p.telefone);
            Console.WriteLine(p.email);
            Console.WriteLine(p.orientacao);
        }

        private void radioMasculino_CheckedChanged(object sender, EventArgs e)
        {
            opcao = "Masculino";
        }

        private void radioFeminino_CheckedChanged(object sender, EventArgs e)
        {
            opcao = "Feminino";
        }

        private void radioOutros_CheckedChanged(object sender, EventArgs e)
        {
            opcao = "Outros";
        }
    }
}
