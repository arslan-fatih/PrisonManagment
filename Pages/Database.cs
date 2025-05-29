
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace PrisonManagment
{
    public static class Database
    {
        public static DataTable GetAllSuppliers()
        {
            using var con = new SqlConnection(connectionString);
            var da = new SqlDataAdapter("SELECT * FROM Supplier", con);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void AddSupplier(string name, string phoneNum, string email)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand(
                "INSERT INTO Supplier (Name, PhoneNum, Email) VALUES (@Name, @Phone, @Email)", con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Phone", (object)phoneNum ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static void UpdateSupplier(string name, string phoneNum, string email)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand(
                "UPDATE Supplier SET PhoneNum=@Phone, Email=@Email WHERE Name=@Name", con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Phone", (object)phoneNum ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static void DeleteSupplier(string name)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("DELETE FROM Supplier WHERE Name=@Name", con);
            cmd.Parameters.AddWithValue("@Name", name);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        // ─────────────────────────────────── BLOCK ────────────────────────────────────
        public static DataTable GetAllBlocks()
        {
            using var con = new SqlConnection(connectionString);
            var da = new SqlDataAdapter("SELECT * FROM Block", con);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void AddBlock(int id, int securityLv, string type, string garden, int? managerId)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand(
                "INSERT INTO Block (ID, SecurityLV, [Type], Garden, ManagerID) " +
                "VALUES (@ID, @Sec, @Type, @Garden, @Mgr)", con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Sec", securityLv);
            cmd.Parameters.AddWithValue("@Type", (object)type ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Garden", (object)garden ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Mgr", (object)managerId ?? DBNull.Value);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static void UpdateBlock(int id, int securityLv, string type, string garden, int? managerId)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand(
                "UPDATE Block SET SecurityLV=@Sec, [Type]=@Type, Garden=@Garden, ManagerID=@Mgr WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Sec", securityLv);
            cmd.Parameters.AddWithValue("@Type", (object)type ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Garden", (object)garden ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Mgr", (object)managerId ?? DBNull.Value);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static void DeleteBlock(int id)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("DELETE FROM Block WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", id);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        // ─────────────────────────────────── CELL ──────────────────────────────────────
        public static DataTable GetAllCells()
        {
            using var con = new SqlConnection(connectionString);
            var da = new SqlDataAdapter("SELECT * FROM Cell", con);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void AddCell(int number, bool? solitary, int blockId)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand(
                "INSERT INTO Cell (Number, Solitary, BlockID) VALUES (@Num, @Sol, @Block)", con);
            cmd.Parameters.AddWithValue("@Num", number);
            cmd.Parameters.AddWithValue("@Sol", (object)solitary ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Block", blockId);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static void UpdateCell(int number, bool? solitary, int blockId)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand(
                "UPDATE Cell SET Solitary=@Sol, BlockID=@Block WHERE Number=@Num", con);
            cmd.Parameters.AddWithValue("@Num", number);
            cmd.Parameters.AddWithValue("@Sol", (object)solitary ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Block", blockId);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static void DeleteCell(int number)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("DELETE FROM Cell WHERE Number=@Num", con);
            cmd.Parameters.AddWithValue("@Num", number);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        // ─────────────────────────────────── HOUSES ────────────────────────────────────
        public static DataTable GetAllHouses()
        {
            using var con = new SqlConnection(connectionString);
            var da = new SqlDataAdapter("SELECT * FROM Houses", con);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void AddHouse(int inmateId, int? cellNumber)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand(
                "INSERT INTO Houses (InmateID, CellNumber) VALUES (@Inmate, @Cell)", con);
            cmd.Parameters.AddWithValue("@Inmate", inmateId);
            cmd.Parameters.AddWithValue("@Cell", (object)cellNumber ?? DBNull.Value);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static void UpdateHouse(int inmateId, int? cellNumber)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand(
                "UPDATE Houses SET CellNumber=@Cell WHERE InmateID=@Inmate", con);
            cmd.Parameters.AddWithValue("@Inmate", inmateId);
            cmd.Parameters.AddWithValue("@Cell", (object)cellNumber ?? DBNull.Value);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static void DeleteHouse(int inmateId)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("DELETE FROM Houses WHERE InmateID=@Inmate", con);
            cmd.Parameters.AddWithValue("@Inmate", inmateId);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        // ─────────────────────────────────── MEDICAL RECORD ────────────────────────────
        public static DataTable GetAllMedicalRecords()
        {
            using var con = new SqlConnection(connectionString);
            var da = new SqlDataAdapter("SELECT * FROM MedicalRecord", con);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void AddMedicalRecord(int id, int? inmateId, string conditions,
                                            string medications, DateTime? lastCheckup, string notes)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand(
                "INSERT INTO MedicalRecord " +
                "(ID, InmateID, Conditions, Medications, LastCheckup, Notes) " +
                "VALUES (@ID, @Inmate, @Cond, @Meds, @Check, @Notes)", con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Inmate", (object)inmateId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Cond", conditions);
            cmd.Parameters.AddWithValue("@Meds", (object)medications ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Check", (object)lastCheckup ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Notes", (object)notes ?? DBNull.Value);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static void UpdateMedicalRecord(int id, int? inmateId, string conditions,
                                               string medications, DateTime? lastCheckup, string notes)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand(
                "UPDATE MedicalRecord SET InmateID=@Inmate, Conditions=@Cond, Medications=@Meds, " +
                "LastCheckup=@Check, Notes=@Notes WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Inmate", (object)inmateId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Cond", conditions);
            cmd.Parameters.AddWithValue("@Meds", (object)medications ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Check", (object)lastCheckup ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Notes", (object)notes ?? DBNull.Value);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static void DeleteMedicalRecord(int id)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("DELETE FROM MedicalRecord WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", id);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        // ─────────────────────────────────── SUPPLIES ──────────────────────────────────
        public static DataTable GetAllSupplies()
        {
            using var con = new SqlConnection(connectionString);
            var da = new SqlDataAdapter("SELECT * FROM Supplies", con);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void AddSupplies(int inventoryId, int? staffId, string supplier)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand(
                "INSERT INTO Supplies (InventoryID, StaffID, Supplier) VALUES (@Inv, @Staff, @Supp)", con);
            cmd.Parameters.AddWithValue("@Inv", inventoryId);
            cmd.Parameters.AddWithValue("@Staff", (object)staffId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Supp", (object)supplier ?? DBNull.Value);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static void UpdateSupplies(int inventoryId, int? staffId, string supplier)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand(
                "UPDATE Supplies SET StaffID=@Staff, Supplier=@Supp WHERE InventoryID=@Inv", con);
            cmd.Parameters.AddWithValue("@Inv", inventoryId);
            cmd.Parameters.AddWithValue("@Staff", (object)staffId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Supp", (object)supplier ?? DBNull.Value);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static void DeleteSupplies(int inventoryId)
        {
            using var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("DELETE FROM Supplies WHERE InventoryID=@Inv", con);
            cmd.Parameters.AddWithValue("@Inv", inventoryId);
            con.Open();
            cmd.ExecuteNonQuery();
        }

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
