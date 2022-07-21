using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Exercicio3
{
     class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            SQLiteConnection conexao = new SQLiteConnection("Data Source = C:\\Users\\kaori\\source\repos\\Exercicios\\Exercicio3\\Exercicio3\\Banco\\banco_de_dados_1.db",true);
            conexao.Open();
            return conexao;
        
        }

            public static DataTable ObterTodosUsuarios()
            {
                SQLiteDataAdapter da = null;

                DataTable dt = new DataTable();
                try
                {
                    using (var cmd = ConexaoBanco().CreateCommand()) {

                        cmd.CommandText = "SELECT * FROM tb_usuarios";
                        da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                        da.Fill(dt);
                    ConexaoBanco().Close();
                        return dt;    

                    }            

                } catch (Exception ex)
                {
                    ConexaoBanco().Close();
                    throw ex; 

                }   
                

            }

            public static DataTable consulta(string sql)
            {
                 SQLiteDataAdapter da = null;

                 DataTable dt = new DataTable();
                try
                {
                    using (var cmd = ConexaoBanco().CreateCommand())
                    {

                        cmd.CommandText = sql;
                        da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                        da.Fill(dt);
                        ConexaoBanco().Close();
                        return dt;

                    }

                }
                catch (Exception ex)
                {
                    ConexaoBanco().Close();
                    throw ex;

            
                }



            }


    }
}
