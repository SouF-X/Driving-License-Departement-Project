using System.Configuration;

namespace SFX_DVLD_DataAccess
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
    }
}
