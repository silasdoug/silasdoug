using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cadastro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        using (SqlConnection cn = new SqlConnection("Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True"))
        {
            using (SqlCommand cmd = new SqlCommand("spInsertContato", cn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nomeContato", nomeTextBox.Text);
                cmd.Parameters.AddWithValue("@nascimentoContato", Convert.ToDateTime(nascimentoTextBox.Text));
                cmd.Parameters.AddWithValue("@emailProfContato", emailProfTextBox.Text);
                cmd.Parameters.AddWithValue("@emailPessContato", emailPessTextBox.Text);
                cmd.Parameters.AddWithValue("@telefoneContato", telefoneTextBox.Text);
                cmd.Parameters.AddWithValue("@tipoTelefoneContato", tipoTelefoneDropDownList.SelectedValue);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                nomeTextBox.Text = "";
                nascimentoTextBox.Text = "";
                emailProfTextBox.Text = "";
                emailPessTextBox.Text = "";
                telefoneTextBox.Text = "";
                tipoTelefoneDropDownList.SelectedIndex = 0;
                Response.Redirect("~/Default.aspx");



            }
        }
    }
}
