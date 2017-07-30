using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace WebApplication2
{
   public partial class _Default : Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {

      }

      protected void Button1_Click(object sender, EventArgs e)
      {
         SqlConnection conn = new SqlConnection(@"Server=WINDOWS-2AVHH68\SQL2012;Initial Catalog=CustomerDetails;uid=Test;pwd=Elji771799");
         SqlCommand insert = new SqlCommand("insert into CustomerDetails(firstName, lastName, accountNumber) values(@firstName,@lastName,@accountNumber)", conn);
         insert.Parameters.AddWithValue("@firstName", firstName.Text);
         insert.Parameters.AddWithValue("@lastName", lastName.Text);
         insert.Parameters.AddWithValue("@accountNumber", accountNumber.Text);

         try
         {
            conn.Open();
            insert.ExecuteNonQuery();
            MessageBox.Show("Details Saved");
         }
         catch
         {
            conn.Close();
            MessageBox.Show("Error in saving");
         }
      }

      protected void lastName_TextChanged(object sender, EventArgs e)
      {

      }
   }
}