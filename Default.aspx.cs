using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();



    }

    protected void ALinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'a%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void BLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'b%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void CLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'c%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void DLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'd%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void ELinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'e%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void FLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'f%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void GLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'g%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void HLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'h%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void ILinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'i%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void JLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'j%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void KLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'k%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void LLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'l%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void MLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'm%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void NLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'n%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void OLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'o%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void PLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'p%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void QLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'q%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void RLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'r%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void SLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 's%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void TLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 't%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void ULinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'u%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void VLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'v%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void XLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'x%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void YLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'y%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void WLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'w%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void ZLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato where nomeContato Like 'z%'");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }

    protected void TodosLinkButton_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string queryPesquisa = string.Format("Select nomeContato,	nascimentoContato,IIF(emailProfContato = '',emailPessContato, emailProfContato) as Email, telefoneContato, tipoTelefoneContato From Contato");

        SqlDataAdapter da = new SqlDataAdapter(queryPesquisa, "Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True");

        da.Fill(ds);
        testeGridView.DataSource = ds.Tables[0];
        testeGridView.DataBind();
    }



    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton lnk = (LinkButton)sender;
        Label1.Text = lnk.Text;

        using (SqlConnection cn = new SqlConnection("Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True"))
        {
            using (SqlCommand cmd = new SqlCommand("Select nomeContato, nascimentoContato, emailPessContato, emailProfContato, telefoneContato, tipoTelefoneContato From Contato where nomeContato = '" + Label1.Text + "'", cn))
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    nomeTextBox.Text = dr["nomeContato"].ToString();
                    nascimentoTextBox.Text = dr["nascimentoContato"].ToString();
                    emailProfTextBox.Text = dr["emailProfContato"].ToString();
                    emailPessTextBox.Text = dr["emailPessContato"].ToString();
                    telefoneTextBox.Text = dr["telefoneContato"].ToString();
                    tipoTelefoneDropDownList.SelectedValue = dr["tipoTelefoneContato"].ToString();

                    cn.Close();
                }
            }
        }

    }

    protected void editarButton_Click(object sender, EventArgs e)
    {
        using (SqlConnection cn = new SqlConnection("Data Source=VAL-PC\\SQLEXPRESS;Initial Catalog=Teste;Integrated Security=True"))
        {
            using (SqlCommand cmd = new SqlCommand("spUpdateContato", cn))
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
    
