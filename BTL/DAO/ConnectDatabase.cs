using System.Data.SqlClient;

namespace BTL.DAO
{
    public class ConnectDatabase
    {
        public SqlConnection Connect()
        {
            return new SqlConnection(
                @"Data Source=TOPXOAN\SQLEXPRESS;Initial Catalog=QLNhaHang;User ID=sa;Password=0384974745"
            );
        }
    }
}
