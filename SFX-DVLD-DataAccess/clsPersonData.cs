using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace SFX_DVLD_DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int? PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, 
                                                    ref string NationalNo, ref DateTime DateOfBirth, ref short Gender, ref string Address, ref string Phone, 
                                                        ref string Email,ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonInfoByID", connection))
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
                                isFound = true;

                                FirstName = reader["FirstName"].ToString();
                                SecondName = reader["SecondName"].ToString();
                                ThirdName = reader["ThirdName"] != DBNull.Value ? reader["ThirdName"].ToString() : "";
                                LastName = reader["LastName"].ToString();
                                NationalNo = reader["NationalNo"].ToString();
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                                Gender = Convert.ToByte(reader["Gender"]);
                                Address = reader["Address"].ToString();
                                Phone = reader["Phone"].ToString();
                                Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "";
                                NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                                ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                }

            }


            return isFound;
        }

        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, 
                                                            ref string LastName, ref DateTime DateOfBirth, ref short Gender, ref string Address, ref string Phone,
                                                                ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonInfoByNationalNo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("NationalNo", NationalNo);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = Convert.ToInt32(reader["PersonID"]);
                                FirstName = reader["FirstName"].ToString();
                                SecondName = reader["SecondName"].ToString();
                                ThirdName = reader["ThirdName"] != DBNull.Value ? reader["ThirdName"].ToString() : "";
                                LastName = reader["LastName"].ToString();
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                                Gender = Convert.ToByte(reader["Gender"]);
                                Address = reader["Address"].ToString();
                                Phone = reader["Phone"].ToString();
                                Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "";
                                NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                                ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                }
            }

            return isFound;
        }

        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth,
                                            short Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("Sp_AddNewPerson", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);

                if (!string.IsNullOrEmpty(ThirdName))
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                else
                    command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Phone", Phone);

                if (!string.IsNullOrEmpty(Email))
                    command.Parameters.AddWithValue("@Email", Email);
                else
                    command.Parameters.AddWithValue("@Email", System.DBNull.Value);

                command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                if (!string.IsNullOrEmpty(ImagePath))
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                else
                    command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


                // Output parameter
                SqlParameter outputParam = new SqlParameter("@PersonID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputParam);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    if (outputParam.Value != DBNull.Value)
                        PersonID = Convert.ToInt32(outputParam.Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return PersonID;
        }

        public static bool UpdatePerson(int? PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth,
                                        short Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);
                command.Parameters.AddWithValue("@ThirdName", string.IsNullOrEmpty(ThirdName) ? (object)DBNull.Value : ThirdName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(Email) ? (object)DBNull.Value : Email);
                command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(ImagePath) ? (object)DBNull.Value : ImagePath);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); // Get affected row count
                    isUpdated = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Log the error silently for debugging purposes
                }
            }

            return isUpdated;
        }

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllPeople", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }

            }

            return dt;
        }

        public static bool DeletePerson(int PersonID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_DeletePerson", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsPersonExist", connection))
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
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return isFound;
        }

        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsPersonExistByNationalNo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

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
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return isFound;
        }

    }
}
