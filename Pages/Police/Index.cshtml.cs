using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Zadatak1.Pages.Police
{
    public class IndexModel : PageModel
    {
        public List<PoliceInfo> listPolice = new List<PoliceInfo>();
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=.\\DESKTOP-8UDK3S7;Initial Catalog=Police;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM Police";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PoliceInfo policeInfo = new PoliceInfo();
                                policeInfo.BrojPolice = reader.GetString(0);
                                policeInfo.IznosPolice = reader.GetString(1);

                                listPolice.Add(policeInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex.ToString());
            }
        }
    }

    public class PoliceInfo
    {
        public String BrojPolice;
        public String IznosPolice;
    }
}
