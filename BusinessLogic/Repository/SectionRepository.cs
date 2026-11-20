using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class SectionRepository
    {
        public List<SectionModel> GetAll(bool includeInactive)
        {
            var list = new List<SectionModel>();

            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_GetAllSections", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IncludeInactive", includeInactive);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new SectionModel
                {
                    SectionID = Convert.ToInt32(reader["SectionID"]),
                    SectionName = reader["SectionName"].ToString(),
                    GradeLevelID = Convert.ToInt32(reader["GradeLevelID"]),
                    GradeLevelName = reader["GradeLevelName"].ToString(),
                    SchoolYear = reader["SchoolYear"].ToString(),
                    Adviser = reader["Adviser"] == DBNull.Value ? string.Empty : reader["Adviser"].ToString(),
                    MaxCapacity = reader["MaxCapacity"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["MaxCapacity"]),
                    IsActive = Convert.ToBoolean(reader["IsActive"])
                });
            }

            return list;
        }

        public void Add(SectionModel section)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_AddSection", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SectionName", section.SectionName);
            cmd.Parameters.AddWithValue("@GradeLevelID", section.GradeLevelID);
            cmd.Parameters.AddWithValue("@SchoolYear", section.SchoolYear);
            cmd.Parameters.AddWithValue("@Adviser", string.IsNullOrWhiteSpace(section.Adviser) ? (object)DBNull.Value : section.Adviser);
            cmd.Parameters.AddWithValue("@MaxCapacity", section.MaxCapacity.HasValue ? (object)section.MaxCapacity.Value : DBNull.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Update(SectionModel section)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_UpdateSection", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SectionID", section.SectionID);
            cmd.Parameters.AddWithValue("@SectionName", section.SectionName);
            cmd.Parameters.AddWithValue("@GradeLevelID", section.GradeLevelID);
            cmd.Parameters.AddWithValue("@SchoolYear", section.SchoolYear);
            cmd.Parameters.AddWithValue("@Adviser", string.IsNullOrWhiteSpace(section.Adviser) ? (object)DBNull.Value : section.Adviser);
            cmd.Parameters.AddWithValue("@MaxCapacity", section.MaxCapacity.HasValue ? (object)section.MaxCapacity.Value : DBNull.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Deactivate(int sectionId)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_DeactivateSection", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SectionID", sectionId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}