﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace D20CharCreator
{
    public static class Database
    {
        private const string connectionString = "server=einstein.etsu.edu;uid=yoderna;pwd=12345;database=yoderna;";

        public static bool LogIn(string username, string password)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            // Read the password hash and salt for this user from the database
            MySqlCommand cmd = new MySqlCommand("SELECT password FROM dnd_users WHERE username = @username", conn);

            cmd.Parameters.AddWithValue("@username", username);

            // If no row was returned, then the username does not exist
            byte[] pwEntry;
            if ((pwEntry = (byte[])cmd.ExecuteScalar()) == null)
                return false;

            // Else, split the password entry into the password and salt parts
            byte[] encryptedPassword = pwEntry.Take(20).ToArray();
            byte[] salt = pwEntry.Skip(20).ToArray();

            // Rehash the password the user entered using the salt
            // If the result is equal to the password hash obtained from the database, it is correct
            return Hash(password, salt).SequenceEqual(encryptedPassword);
        }

        public static bool SignUp(string username, string firstName, string lastName, string email, string password)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO dnd_users(username, first_name, last_name, email, password) " +
                                                "VALUES(@username, @firstName, @lastName, @email, @password)", conn);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", Hash(password));

            return cmd.ExecuteNonQuery() == 1;
        }

        /// <summary>
        /// Hashes the user's password with a randomly generated salt and returns the combination of the two
        /// </summary>
        /// <param name="password">The password to hash</param>
        /// <returns>A 52-byte array, where the first 20 bytes are the password hash and the remaining 32 bytes are the salt</returns>
        private static byte[] Hash(string password)
        {
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, 32, 10000);

            return rfc.GetBytes(20).Concat(rfc.Salt).ToArray();
        }

        /// <summary>
        /// Hashes the user's password with the specified salt and returns the password hash
        /// </summary>
        /// <param name="password">The password to hash</param>
        /// <param name="salt">The salt to use</param>
        /// <returns>The 20 byte password hash</returns>
        private static byte[] Hash(string password, byte[] salt)
        {
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, salt, 10000);

            return rfc.GetBytes(20);
        }
    }
}