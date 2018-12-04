using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp8
{
    class Passageiros

    {

        string nome;
        string sobrenome;
        string cpf;
        string endereco;
        string telefone;
        string passagem;
        string vooNum;
        string vooHor;
        int poltrona = 0;

        ArrayList Passageiro = new ArrayList();

        public Passageiros()
        {
            cpf = null;
            nome = null;
            sobrenome = null;
            endereco = null;
            telefone = null;
            passagem = null;
            vooNum = null;
            vooHor = null;
            poltrona = 0;

        }

        public Passageiros(string nome, string sobrenome, string cpf, string endereco, string telefone, string passagem, string vooNum, string vooHor, int poltrona)
        { 
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefone = telefone;
            this.passagem = passagem;
            this.vooNum = vooNum;
            this.vooHor = vooHor;
            this.poltrona = poltrona;

        }



        public void Cadastrar()
        {
            Passageiro.Add(nome);
            Passageiro.Add(sobrenome);
            Passageiro.Add(cpf);
            Passageiro.Add(endereco);
            Passageiro.Add(telefone);
            Passageiro.Add(passagem);
            Passageiro.Add(vooNum);
            Passageiro.Add(vooHor);
            Passageiro.Add(poltrona);
        }



        public string Consulta1()
        {
           string dados = " CPF: " + Passageiro[2] + " \n Nome: " + Passageiro[0] + "\n Numero da Passagem: " + Passageiro[5] + " \n Poltrona: " + Passageiro[8];
           return dados;
        }

        public string Consulta2()
        {


            string dados = " CPF: " + Passageiro[2] + " \n Nome: " + Passageiro[0] + "\n Sobrenome: " + Passageiro[1] + " \n Endereço: " + Passageiro[3]

                + " \n Telefone: " + Passageiro[4] + " \n Número da passagem: " + Passageiro[5] + " \n Número do Voo: " + Passageiro[6]

                + " \n Horário: " + Passageiro[7] + " \n Poltrona: " + Passageiro[8];

            return dados;

        }

        internal string Contem(string solicitaCpf)
        {
            solicitaCpf = Convert.ToString(Passageiro[0]);
            return solicitaCpf;

        }

    }
}
