using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace WinFormsAppFoto
{
    public class Foto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string foto { get; set; }

        MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;database=aula;user id=root;password=;charset=utf8");

        public List<Foto> listafoto()
        {
            List<Foto> li = new List<Foto>();
            string sql = "SELECT * FROM aluno";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Foto foto = new Foto();
                foto.id = (int)dr["id"];
                foto.nome = dr["nome"].ToString();
                foto.foto = dr["foto"].ToString();
                li.Add(foto);
            }
            dr.Close();
            con.Close();
            return li;
        }
        public void Inserir(string nome, string foto)
        {
            try
            {
                string sql = "INSERT INTO aluno(nome, foto) VALUES ('" + nome + "','" + foto + "')";
                if (con.State != ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Atualizar(string nome, string foto)
        {
            try
            {
                string sql = "UPDATE aluno SET nome='" + nome + "','" + foto + "' WHERE id ='" + id + "'";
                if (con.State != ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Excluir(string nome, string foto)
        {
            try
            {
                string sql = "DELETE FROM aluno WHERE id ='" + id + "'";
                if (con.State != ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
