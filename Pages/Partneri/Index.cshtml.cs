using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Zadatak1.Pages.Partneri
{
    public class IndexModel : PageModel
    {
        public List<ClientInfo> listClients = new List<ClientInfo>();  
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=.\\DESKTOP-8UDK3S7;Initial Catalog=Partneri2;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM Partneri2";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClientInfo clientInfo = new ClientInfo();
                                clientInfo.id = reader.GetString(0);
                                clientInfo.FirstName = reader.GetString(1);
                                clientInfo.LastName = reader.GetString(2);
                                clientInfo.Address = reader.GetString(3);
                                clientInfo.PartnerNumber = reader.GetString(4);
                                clientInfo.CroatianPIN = reader.GetString(5);
                                clientInfo.PartnerTypeID = "" + reader.GetString(6);
                                clientInfo.CreatedAtUtc = reader.GetDateTime(7).ToString();
                                clientInfo.CreatedByUser = reader.GetDateTime(8).ToString();
                                clientInfo.IsForeign = reader.GetString(9);
                                clientInfo.ExternalCode = reader.GetString(10);
                                clientInfo.Gender = reader.GetString(11);

                                listClients.Add(clientInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }

    public class ClientInfo
    {
        public String id;
        public String FirstName;
        public String LastName;
        public String Address;
        public String PartnerNumber;
        public String CroatianPIN;
        public String PartnerTypeID;
        public String CreatedAtUtc;
        public String CreatedByUser;
        public String IsForeign;
        public String ExternalCode;
        public String Gender;
    }
}
