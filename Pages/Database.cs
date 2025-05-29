
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace PrisonManagment
{
    public static class Database
    {
        private static readonly string connectionString = "Server=localhost;Database=PrisonManagementSystem;Trusted_Connection=True;";

        // STAFF OPERATIONS
        public static DataTable     GetAllStaff()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Staff", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void AddStaff(int id, string role, string name, int age, decimal wage, int? supervisor, int? assignedBlock)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Staff (ID, Role, Name, Age, Wage, Supervisor, AssignedBlock) VALUES (@ID, @Role, @Name, @Age, @Wage, @Supervisor, @AssignedBlock)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Wage", wage);
                cmd.Parameters.AddWithValue("@Supervisor", (object)supervisor ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AssignedBlock", (object)assignedBlock ?? DBNull.Value);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateStaff(int id, string role, string name, int age, decimal wage, int? supervisor, int? assignedBlock)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Staff SET Role=@Role, Name=@Name, Age=@Age, Wage=@Wage, Supervisor=@Supervisor, AssignedBlock=@AssignedBlock WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Wage", wage);
                cmd.Parameters.AddWithValue("@Supervisor", (object)supervisor ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AssignedBlock", (object)assignedBlock ?? DBNull.Value);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteStaff(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Staff WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // INVENTORY OPERATIONS
        public static DataTable GetAllInventory()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inventory", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void AddInventory(int id, string name, int amount, DateTime? lastRestock)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Inventory (ID, Name, Amount, LastRestock) VALUES (@ID, @Name, @Amount, @LastRestock)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@LastRestock", (object)lastRestock ?? DBNull.Value);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateInventory(int id, string name, int amount, DateTime? lastRestock)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Inventory SET Name=@Name, Amount=@Amount, LastRestock=@LastRestock WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@LastRestock", (object)lastRestock ?? DBNull.Value);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteInventory(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Inventory WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // INMATES OPERATIONS
        public static DataTable GetAllInmates()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inmates", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void AddInmate(int id, string name, string gender, int age, DateTime dob, DateTime entryDate, DateTime? releaseDate, string crime)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Inmates (ID, Name, Gender, Age, DateOfBirth,entryDate, ReleaseDate, Crime) VALUES (@ID, @Name, @Gender, @Age, @DateOfBirth,@entryDate, @ReleaseDate, @Crime)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                cmd.Parameters.AddWithValue("@EntryDate", entryDate);
                cmd.Parameters.AddWithValue("@ReleaseDate", (object)releaseDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Crime", crime);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateInmate(int id, string name, string gender, int age, DateTime dob, DateTime? releaseDate, string crime)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Inmates SET Name=@Name, Gender=@Gender, Age=@Age, DateOfBirth=@DateOfBirth, ReleaseDate=@ReleaseDate, Crime=@Crime WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                cmd.Parameters.AddWithValue("@ReleaseDate", (object)releaseDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Crime", crime);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteInmate(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Inmates WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
