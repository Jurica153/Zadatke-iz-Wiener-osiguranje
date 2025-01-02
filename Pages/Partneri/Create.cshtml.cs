using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Data.SqlClient;

namespace Zadatak1.Pages.Partneri
{
    public class CreateModel : PageModel
    {
        public ClientInfo clientInfo = new ClientInfo();
        public String errorMessage = "";
        public String successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            clientInfo.FirstName = Request.Form["FirstName"];
            clientInfo.FirstName = Request.Form["LastName"];
            clientInfo.FirstName = Request.Form["Address"];
            clientInfo.FirstName = Request.Form["PartnerNumber"];
            clientInfo.FirstName = Request.Form["CroatianPIN"];
            clientInfo.FirstName = Request.Form["PartnerTypeID"];
            clientInfo.FirstName = Request.Form["CreatedAtUtc"];
            clientInfo.FirstName = Request.Form["CreatedByUser"];
            clientInfo.FirstName = Request.Form["IsForeign"];
            clientInfo.FirstName = Request.Form["ExternalCode"];
            clientInfo.FirstName = Request.Form["Gender"];

            if (clientInfo.FirstName.Length == 0 && clientInfo.LastName.Length == 0 &&
                clientInfo.Address.Length == 0 && clientInfo.PartnerNumber.Length == 0 &&
                clientInfo.CroatianPIN.Length == 0 && clientInfo.PartnerTypeID.Length == 0 &&
                clientInfo.CreatedAtUtc.Length == 0 && clientInfo.CreatedByUser.Length == 0 &&
                clientInfo.IsForeign.Length == 0 && clientInfo.ExternalCode.Length == 0 &&
                clientInfo.Gender.Length == 0)
            {
                errorMessage = "All the fields are required!";
                return;
            }

            try
            {
                String connectionString = "Data Source=.\\DESKTOP-8UDK3S7;Initial Catalog=Partneri2;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO Partneri2 " + "(FirstName, LastName, Address, PartnerNumber, CroatianPIN, PartnerTypeID, CreatedAtUtc, CreatedByUser, IsForeign, ExternalCode, Gender) VALUES " + "(@FirstName, @LastName, @Address, @PartnerNumber, @CroatianPIN, @PartnerTypeID, @CreatedAtUtc, @CreatedByUser, @IsForeign, @ExternalCode, @Gender)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", clientInfo.FirstName);
                        command.Parameters.AddWithValue("@LastName", clientInfo.LastName);
                        command.Parameters.AddWithValue("@Address", clientInfo.Address);
                        command.Parameters.AddWithValue("@PartnerNumber", clientInfo.PartnerNumber);
                        command.Parameters.AddWithValue("@CroatianPIN", clientInfo.CroatianPIN);
                        command.Parameters.AddWithValue("@PartnerTypeID", clientInfo.PartnerTypeID);
                        command.Parameters.AddWithValue("@CreatedAtUtc", clientInfo.CreatedAtUtc);
                        command.Parameters.AddWithValue("@CreatedByUser", clientInfo.CreatedByUser);
                        command.Parameters.AddWithValue("@IsForeign", clientInfo.IsForeign);
                        command.Parameters.AddWithValue("@ExternalCode", clientInfo.ExternalCode);
                        command.Parameters.AddWithValue("@Gender", clientInfo.Gender);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            clientInfo.FirstName = "";
            clientInfo.LastName = "";
            clientInfo.Address = "";
            clientInfo.PartnerNumber = "";
            clientInfo.CroatianPIN = "";
            clientInfo.PartnerTypeID = "";
            clientInfo.CreatedAtUtc = "";
            clientInfo.CreatedByUser = "";
            clientInfo.IsForeign = "";
            clientInfo.ExternalCode = "";
            clientInfo.Gender = "";
            successMessage = "New Partneri Added Correctly!";

            Response.Redirect("/Partneri/Index");
        }
    }
}
