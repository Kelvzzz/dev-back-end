using Cars.Classes.Contextos;
using Cars.Classes.Entidades;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Cars.Classes.Services
{
    internal static class Pesquisa
    {
        //Campo
        static EstoqueContexto contexto = new EstoqueContexto();

        //Métodos
        public static void Pesquisas(bool moto, bool carro, string texto, DataGridView dataGridView1 string filtro)
        {
            if (moto.Equals(false) & carro.Equals(false) | moto.Equals(true) & carro.Equals(true))
            {
                
            }

            else if (moto)
            {
                //Pesquisa por moto
                dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Tipo == 1));
               
            }
            else if (carro)
            {
                //Pesquisa por carro
                dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Tipo == 2));
                
            }
        }

        private static void Filtro(string texto, DataGridView dataGridView1, string filtro)
        {
            if (texto.IsNullOrEmpty())
            {
                dataGridView1.DataSource = Projetar(contexto.Estoque);

            }
            else if (filtro.Equals("Contém")) ;
            {
                dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Modelo.Contains(texto)));
            } 
        

            else if (filtro.Equals("Inicia"))
            {
                dataGridView1.DataSource = Projetar(contexto.Estoque.Where(e => e.Modelo.Contains(texto)));
                    
            }
        }

        /// <summary>
        /// Método auxiliar responsável pela projeção em todas as pesquisas
        /// </summary>

        private static object Projetar(IQueryable<Estoque> consulta)
            {
            return consulta.Select(e => new
                    {
            e.Tipo,
                        e.Modelo,
                        e.Quantidade,
                        Valor = e.Valor.ToString("C"),
                    }).ToList();
}
            


        

    }
}

        