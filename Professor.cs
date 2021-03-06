﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioDoProfessor
{
    class Professor
    {
        private string nome;
        private int codigo;
        private long contacto;
        private string curso;
        private string turma;
        private double horas;
        private double salario;
        private string nivel;



        public Professor(string nome,int codigo, long contacto, string curso, string turma, double horas, double salario, string nivel)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.contacto = contacto;
            this.curso = curso;
            this.horas = horas;
            this.salario = salario;
            this.nivel = nivel;
        }

        public Professor()
        {

        }

        public string GetNome()
        { 
            return nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public long GetContacto()
        {
            return contacto;
        }

        public void SetContacto(long contacto)
        {
            this.contacto = contacto;
        }

        public void SetCurso(string curso)
        {
            this.curso = curso;
        }
        public string GetCurso()
        {
            return curso;
        }

        public double GetHoras()
        {
            return horas;
        }

        public void SetHoras(double horas)
        {
            this.horas = horas;
        }

        public double GetSalario()
        {
            return salario;
        }

        public void SetSalario(double salario)
        {
            this.salario = salario;
        }

        public string GetNivel()
        {
            return nivel;
        }

        public void SetNivel(string nivel)
        {
            this.nivel = nivel;
        }

        public override string ToString() => "Nome: " + nome + "\n" +
                                             "Codigo: " + codigo + "\n" +
                                             "Contacto: " + contacto + "\n" +
                                             "Curso: " + curso + "\n" +
                                             "Turma: " + turma + "\n" +
                                             "Horas de trabalho: " + horas + "\n" +
                                             "Salario: " + salario + "\n" +
                                             "Nivel: " + this.nivel + "\n";

        public double valor()
        {
            double salario = this.salario * this.horas;

            return salario;

        }

        public void imprimir()
        {
            Console.WriteLine("Salario por hora, " + valor());
        }


        public static void Main(String[] args)
        {
            MetodosDoProfessor z = new MetodosDoProfessor();
            z.menu();
        }
    }
}
