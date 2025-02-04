﻿
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Genero
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }
        public List<Colaborador> Colaboradores { get; set; }

        public static Genero Criar(int id, string valor)
        {
            Genero genero = new Genero();
            genero.Id = id;
            genero.Valor = valor;
            return genero;
        }

        public void AlterarValor(string valor)
        {
            Valor = valor;
        }
    }
}