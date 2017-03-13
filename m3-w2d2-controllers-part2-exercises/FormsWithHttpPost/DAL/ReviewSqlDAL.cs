using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        string connectionString = @"Data Source=DESKTOP-58F8CH1\SQLEXPRESS;Initial Catalog=ReviewDB;Integrated Security=True";
        string SQL_selectAllFromReview = @"SELECT * FROM reviews;";
        string SQL_insertStatement = @"insert into reviews values(@user_name,@rating,@title,@msg, @review_date);";

        public List<Review> GetAllReviews()
        {
            List<Review> reviews = new List<Review>();
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_selectAllFromReview, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        Review r = new Review();
                        r.Id = Convert.ToInt32(reader["review_id"]);
                        r.Username = Convert.ToString(reader["username"]);
                        r.Rating = Convert.ToInt32(reader["rating"]);
                        r.Title = Convert.ToString(reader["review_title"]);
                        r.Message = Convert.ToString(reader["review_text"]);
                        r.ReviewDate = Convert.ToDateTime(reader["review_date"]);

                        reviews.Add(r);
                    }

                }

            } catch(SqlException errorMessage)
            {
                throw errorMessage;
            }

            return reviews;
        }

        public bool SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_insertStatement, conn);

                    cmd.Parameters.AddWithValue("@user_name", newReview.Username);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@title", newReview.Title);
                    cmd.Parameters.AddWithValue("@msg", newReview.Message);

                    newReview.ReviewDate = DateTime.UtcNow;
                    cmd.Parameters.AddWithValue("@review_date", newReview.ReviewDate);

                    int rowsReturned = cmd.ExecuteNonQuery();

                    return rowsReturned > 0;

                }

            }
            catch (SqlException errorMessage)
            {
                throw errorMessage;
            }

        }
    }
}