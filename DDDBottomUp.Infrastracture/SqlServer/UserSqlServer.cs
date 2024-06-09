using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DDDBottomUp.Entities;
using DDDBottomUp.Repositories;
using DDDBottomUp.ValueObjects;

namespace DDDBottomUp.Infrastracture.SqlServer
{
    public class UserSqlServer : IUserRepository
    {
        public User Find(UserName userName)
        {
            using (var connection = new SqlConnection(SqlServerHelper.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = @"
                    SELECT id, name
                    FROM users
                    WHERE name = @name
                ";
                command.Parameters.Add(new SqlParameter("@name", userName.Value));

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var id = reader["id"] as string;
                        var name = reader["name"] as string;

                        return new User(
                            new UserId(id),
                            new UserName(name)
                           );
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public void Save(User user)
        {
            using (var connection = new SqlConnection(SqlServerHelper.ConnectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = @"
                    INSERT INTO users (id, name)
                    VALUES (@id, @name)
                ";
                command.Parameters.Add(new SqlParameter("@id", user.UserId.Value));
                command.Parameters.Add(new SqlParameter("@name", user.UserName.Value));
                command.ExecuteNonQuery();
            }
        }
    }
}
