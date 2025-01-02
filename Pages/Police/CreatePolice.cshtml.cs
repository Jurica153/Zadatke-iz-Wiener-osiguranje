using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Zadatak1.Pages.Police
{
    public class CreatePoliceModel : PageModel
    {
        public PoliceInfo policeInfo = new PoliceInfo();
        public String errorMessage = "";
        public String successMessage = "";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            policeInfo.BrojPolice = Request.Form["BrojPolice"];
            policeInfo.IznosPolice = Request.Form["IznosPolice"];

            if (policeInfo.BrojPolice.Length == 0 || policeInfo.IznosPolice.Length == 0)
            {
                errorMessage = "All the fields are required!";
                return;
            }

            try
            {
                String connectionString = "Data Source=.\\DESKTOP-8UDK3S7;Initial Catalog=Police;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO Partneri " + "(BrojPolice, IznosPolice) VALUES " + "(@BrojPolice, @IznosPolice)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@BrojPolice", policeInfo.BrojPolice);
                        command.Parameters.AddWithValue("@LastName", policeInfo.IznosPolice);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            policeInfo.BrojPolice = "";
            policeInfo.IznosPolice = "";
            successMessage = "New Police Added Correctly!";

            Response.Redirect("/Police/Index");
        }
    }
}
