using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class User : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayCity();
        dispCountry();
        dispState();
    }
    protected void Unnamed11_Click(object sender, EventArgs e)
    {
        proc();

    }

    private void DisplayCity()
    {
        SqlConnection con = new SqlConnection(cs);
        con.Open();
        SqlCommand cmd = new SqlCommand("select CityId,CityName from City", con);
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        ddlCity.DataTextField = "CityName";
        ddlCity.DataValueField = "CityId";
        ddlCity.DataSource = dt;
       
        ddlCity.DataBind();
        con.Close();
    }

    private void dispCountry()
    {
        SqlConnection con = new SqlConnection(cs);
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT CounId,Cname FROM Country ", con);
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        ddlCountry.DataTextField = "Cname";
        ddlCountry.DataValueField = "CounId";
        ddlCountry.DataSource = dt;

        ddlCountry.DataBind();
        con.Close();
    }

    private void dispState()
    {
        //SqlConnection con = new SqlConnection(cs);
        //con.Open();
        //SqlCommand cmd = new SqlCommand("SELECT StId,StateName FROM CState where CounId="+ddlCountry.SelectedValue, con);
        //DataTable dt = new DataTable();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //da.Fill(dt);
        //ddlState.DataTextField = "StateName";
        //ddlState.DataValueField = "StId";
        //ddlState.DataSource = dt;

        //ddlState.DataBind();
        //con.Close();
    }


    private void proc()
    {
        
        SqlConnection con = new SqlConnection(cs);
        con.Open();
        SqlCommand cmd = new SqlCommand("insDetails", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@name", txtName.Text);
        cmd.Parameters.AddWithValue("@mobile", txtMob.Text);
        cmd.Parameters.AddWithValue("@city", ddlCity.SelectedValue);
        cmd.Parameters.AddWithValue("@date", txtDate.Text);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        proc();
    }
    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(cs);
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT StId,StateName FROM CState where CounId=" + ddlCountry.SelectedValue, con);
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        ddlState.DataTextField = "StateName";
        ddlState.DataValueField = "StId";
        ddlState.DataSource = dt;

        ddlState.DataBind();
        con.Close();
    }
}