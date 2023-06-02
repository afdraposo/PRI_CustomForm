using Primavera.Extensibility.CustomForm;
using System;
using System.Data.SqlClient;

namespace ExtensibilityProject1
{
    public partial class FDU_ArtigoDescricao : CustomForm
    {
        private string _codigoArtigo;

        public FDU_ArtigoDescricao()
        {
            InitializeComponent();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tb_codigoArtigo.Text))
                {
                    string connStr = this.PSO.BaseDados.DaConnectionStringNET(this.PSO.BaseDados.DaNomeBDdaEmpresa(this.BSO.Contexto.CodEmp), this.BSO.Contexto.Instancia);

                    using (SqlConnection con = new SqlConnection(connStr))
                    {
                        string query = "SELECT * from Artigo " +
                                       $"where Artigo = '{tb_codigoArtigo.Text}'";

                        SqlCommand selectCommand = new SqlCommand(query, con);

                        con.Open();

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                tb_descricao.Enabled = true;
                                btn_inserir.Enabled = true;
                                _codigoArtigo = reader["Artigo"].ToString();
                                tb_descricao.Text = reader["Descricao"].ToString();
                            }
                            else
                            {
                                PSO.Dialogos.MostraAviso("Código de Artigo não existe!", StdPlatBS100.StdBSTipos.IconId.PRI_Exclama);
                            }
                        }
                        con.Close();
                    }
                }
                else
                {
                    PSO.Dialogos.MostraAviso("Campo do Código de Artigo Vazio!", StdPlatBS100.StdBSTipos.IconId.PRI_Exclama);
                }
            }
            catch (Exception ex)
            {
                PSO.Dialogos.MostraAviso("Error: " + ex.Message, StdPlatBS100.StdBSTipos.IconId.PRI_Critico);
            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tb_descricao.Text))
                {
                    string connStr = this.PSO.BaseDados.DaConnectionStringNET(this.PSO.BaseDados.DaNomeBDdaEmpresa(this.BSO.Contexto.CodEmp), this.BSO.Contexto.Instancia);

                    using (SqlConnection con = new SqlConnection(connStr))
                    {
                        con.Open();

                        SqlCommand updateCommand = con.CreateCommand();

                        updateCommand.CommandText = "UPDATE Artigo " +
                            $"set Descricao = '{tb_descricao.Text}' " +
                            $"where Artigo = '{_codigoArtigo}'";

                        updateCommand.ExecuteNonQuery();

                        con.Close();
                    }

                    PSO.Dialogos.MostraAviso("Descrição editada com sucesso!", StdPlatBS100.StdBSTipos.IconId.PRI_Informativo);
                }
                else
                {
                    PSO.Dialogos.MostraAviso("Campo da Descrição Vazio!", StdPlatBS100.StdBSTipos.IconId.PRI_Exclama);
                }
            }
            catch (Exception ex)
            {
                PSO.Dialogos.MostraAviso("Error: " + ex.Message, StdPlatBS100.StdBSTipos.IconId.PRI_Critico);
            }
        }

        private void PriCustomForm1_Load(object sender, EventArgs e)
        {
            tb_descricao.Enabled = false;
            btn_inserir.Enabled = false;
        }
    }
}
