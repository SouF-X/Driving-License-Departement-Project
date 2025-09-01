using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace SFX_DVLD_DataAccess
{
    public class clsLicenseClassesData
    {
        public static bool GetLicenseClassInfoByID(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref float ClassFees)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_GetLicenseClassInfoByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            ClassName = (string)reader["ClassName"];
                            ClassDescription = (string)reader["ClassDescription"];
                            MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                            DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                            ClassFees = Convert.ToSingle(reader["ClassFees"]);
                        }
                    }
                }
                catch (Exception)
                {
                    isFound = false;
                }
            }

            return isFound;
        }

        public static bool GetLicenseClassInfoByClassName(string ClassName, ref int LicenseClassID, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref float ClassFees)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_GetLicenseClassInfoByClassName", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ClassName", ClassName);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            LicenseClassID = (int)reader["LicenseClassID"];
                            ClassDescription = (string)reader["ClassDescription"];
                            MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                            DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                            ClassFees = Convert.ToSingle(reader["ClassFees"]);
                        }
                    }
                }
                catch (Exception)
                {
                    isFound = false;
                }
            }

            return isFound;
        }

        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_GetAllLicenseClasses", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception)
                {
                    // Optional: log the exception or handle as needed
                }
            }

            return dt;
        }

        public static int AddNewLicenseClass(string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
        {
            int LicenseClassID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_AddNewLicenseClass", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ClassName", ClassName);
                command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
                command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
                command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
                command.Parameters.AddWithValue("@ClassFees", ClassFees);

                SqlParameter outputID = new SqlParameter("@LicenseClassID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputID);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    LicenseClassID = Convert.ToInt32(outputID.Value);
                }
                catch (Exception)
                {
                    LicenseClassID = -1;
                }
            }

            return LicenseClassID;
        }

        public static bool UpdateLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_UpdateLicenseClass", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                command.Parameters.AddWithValue("@ClassName", ClassName);
                command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
                command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
                command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
                command.Parameters.AddWithValue("@ClassFees", ClassFees);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    isUpdated = (rowsAffected > 0);
                }
                catch (Exception)
                {
                    isUpdated = false;
                }
            }

            return isUpdated;
        }

    }
}
