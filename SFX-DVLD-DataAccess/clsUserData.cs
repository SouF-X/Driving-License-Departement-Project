using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace SFX_DVLD_DataAccess
{
    public class clsUserData
    {
        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_GetUserInfoByUserID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // The record was found
                            isFound = true;
                            PersonID = Convert.ToInt32(reader["PersonID"]);
                            UserName = reader["UserName"].ToString();
                            Password = reader["Password"].ToString();
                            IsActive = Convert.ToBoolean(reader["IsActive"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log the error silently for debugging purposes
                }
            }

            return isFound;
        }

        public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_GetUserInfoByPersonID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // The record was found
                            isFound = true;
                            UserID = Convert.ToInt32(reader["UserID"]);
                            UserName = reader["UserName"].ToString();
                            Password = reader["Password"].ToString();
                            IsActive = Convert.ToBoolean(reader["IsActive"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log the error silently for debugging purposes
                }
            }

            return isFound;
        }

        public static bool GetUserInfoByUsernameAndPassword(string UserName, string Password, ref int UserID, ref int PersonID, ref bool IsActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_GetUserInfoByUsernameAndPassword", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", UserName);
                command.Parameters.AddWithValue("@Password", Password);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // The record was found
                            isFound = true;
                            UserID = Convert.ToInt32(reader["UserID"]);
                            PersonID = Convert.ToInt32(reader["PersonID"]);
                            IsActive = Convert.ToBoolean(reader["IsActive"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log the error silently for debugging purposes
                }
            }

            return isFound;
        }

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int UserID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@IsActive", IsActive);

                // Output parameter
                SqlParameter outputParam = new SqlParameter("@UserID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    if (outputParam.Value != DBNull.Value)
                        UserID = Convert.ToInt32(outputParam.Value);
                }
                catch (Exception ex)
                {
                    // Log the error silently for debugging purposes
                }
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@IsActive", IsActive);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    isUpdated = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Log the error silently for debugging purposes
                }
            }

            return isUpdated;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
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
                catch (Exception ex)
                {
                    // Log the error silently for debugging purposes
                }
            }

            return dt;
        }

        public static bool DeleteUser(int UserID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); // Get affected row count
                    isDeleted = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Log the error silently for debugging purposes
                }
            }

            return isDeleted;
        }

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_IsUserExist", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);

                // Add parameter to capture return value
                SqlParameter returnValue = new SqlParameter("@ReturnValue", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(returnValue);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve return value
                    isFound = Convert.ToInt32(returnValue.Value) == 1;
                }
                catch (Exception ex)
                {
                    // Consider logging the error for debugging
                }
            }

            return isFound;
        }

        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_IsUserExistByUserName", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", UserName);

                // Add parameter to capture return value
                SqlParameter returnValue = new SqlParameter("@ReturnValue", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(returnValue);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve return value
                    isFound = Convert.ToInt32(returnValue.Value) == 1;
                }
                catch (Exception ex)
                {
                    // Consider logging the error for debugging
                }
            }

            return isFound;
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_IsUserExistForPersonID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);

                // Add parameter to capture return value
                SqlParameter returnValue = new SqlParameter("@ReturnValue", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(returnValue);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve return value
                    isFound = Convert.ToInt32(returnValue.Value) == 1;
                }
                catch (Exception ex)
                {
                    // Log the error silently for debugging purposes
                }
            }

            return isFound;
        }

        public static bool DoesPersonHaveUser(int PersonID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_DoesPersonHaveUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);

                // Define return parameter to capture stored procedure result
                SqlParameter returnParameter = new SqlParameter("@ReturnValue", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                command.Parameters.Add(returnParameter);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve return value
                    isFound = Convert.ToInt32(returnParameter.Value) == 1;
                }
                catch (Exception ex)
                {
                    // Consider logging the error instead of ignoring it
                }
            }

            return isFound;
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_ChangePassword", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@NewPassword", NewPassword);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    isUpdated = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Consider logging the error instead of ignoring it
                }
            }

            return isUpdated;
        }

    }
}
