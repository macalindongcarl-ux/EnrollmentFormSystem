using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class GradeLevelRepository
    {
        public List<GradeLevelModel> GetAll(bool includeInactive)
        {
            var list = new List<GradeLevelModel>();

            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_GetAllGradeLevels", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IncludeInactive", includeInactive);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new GradeLevelModel
                {
                    GradeLevelID = Convert.ToInt32(reader["GradeLevelID"]),
                    GradeLevelName = reader["GradeLevelName"].ToString(),
                    TuitionFee = Convert.ToDecimal(reader["TuitionFee"]),
                    MiscellaneousFee = Convert.ToDecimal(reader["MiscellaneousFee"]),
                    IsActive = Convert.ToBoolean(reader["IsActive"])
                });
            }

            return list;
        }

        public void Add(GradeLevelModel gradeLevel)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_AddGradeLevel", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GradeLevelName", gradeLevel.GradeLevelName);
            cmd.Parameters.AddWithValue("@TuitionFee", gradeLevel.TuitionFee);
            cmd.Parameters.AddWithValue("@MiscellaneousFee", gradeLevel.MiscellaneousFee);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Update(GradeLevelModel gradeLevel)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_UpdateGradeLevel", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GradeLevelID", gradeLevel.GradeLevelID);
            cmd.Parameters.AddWithValue("@GradeLevelName", gradeLevel.GradeLevelName);
            cmd.Parameters.AddWithValue("@TuitionFee", gradeLevel.TuitionFee);
            cmd.Parameters.AddWithValue("@MiscellaneousFee", gradeLevel.MiscellaneousFee);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Deactivate(int gradeLevelId)
        {
            using SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_DeactivateGradeLevel", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GradeLevelID", gradeLevelId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}