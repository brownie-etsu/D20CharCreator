using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Data;

namespace D20CharCreator
{
    public static class Database
    {
        private const string connectionString = "server=einstein.etsu.edu;uid=yoderna;pwd=12345;database=yoderna;";

        public static void SaveCharacter(Character charToSave)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE dnd_characters " +
                                                "SET lang_one = @lang_one, " +
                                                "lang_two = @lang_two, " +
                                                "bgEquipment = @bgEquipment, " +
                                                "char_one = @char_one, " +
                                                "char_two = @char_two, " +
                                                "char_three = @char_three, " +
                                                "char_four = @char_four, " +
                                                "rerolls = @rerolls, " +
                                                "class = @class, " +
                                                "skill_one = @skill_one, " +
                                                "skill_two = @skill_two, " +
                                                "skill_three = @skill_three, " +
                                                "skill_four = @skill_four, " +
                                                "classEquipment = @classEquipment, " +
                                                "background = @background " +
                                                "WHERE character_id = @character_id",
                                                conn);

            cmd.Parameters.AddWithValue("@lang_one", (int)charToSave.Background.LangOne);
            cmd.Parameters.AddWithValue("@lang_two", (int)charToSave.Background.LangTwo);
            cmd.Parameters.AddWithValue("@bgEquipment", charToSave.Background.Equipment);
            cmd.Parameters.AddWithValue("@char_one", charToSave.Background.Characteristics[0]);
            cmd.Parameters.AddWithValue("@char_two", charToSave.Background.Characteristics[1]);
            cmd.Parameters.AddWithValue("@char_three", charToSave.Background.Characteristics[2]);
            cmd.Parameters.AddWithValue("@char_four", charToSave.Background.Characteristics[3]);
            cmd.Parameters.AddWithValue("@rerolls", charToSave.Background.Rerolls);
            cmd.Parameters.AddWithValue("@class", (int)charToSave.Class.Type);
            cmd.Parameters.AddWithValue("@skill_one", charToSave.Class.Skills[0]);
            cmd.Parameters.AddWithValue("@skill_two", charToSave.Class.Skills[1]);
            cmd.Parameters.AddWithValue("@skill_three", charToSave.Class.Skills[2]);
            cmd.Parameters.AddWithValue("@skill_four", charToSave.Class.Skills[3]);
            cmd.Parameters.AddWithValue("@classEquipment", charToSave.Class.Equipment);
            cmd.Parameters.AddWithValue("@background", (int)charToSave.Background.Type);
            cmd.Parameters.AddWithValue("@character_id", charToSave.CharacterId);

            cmd.ExecuteNonQuery();
        }

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

        public static int GetUserId(string username)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select user_id from dnd_users where username = @username", conn);

            cmd.Parameters.AddWithValue("@username", username);

            return unchecked((int)cmd.ExecuteScalar());
        }

        public static bool UsernameExists(string username)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select count(*) from dnd_users where username = @username", conn);

            cmd.Parameters.AddWithValue("@username", username);

            return (long)cmd.ExecuteScalar() == 1;
        }

        public static bool EmailExists(string email)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select count(*) from dnd_users where email = @email", conn);

            cmd.Parameters.AddWithValue("@email", email);

            return (long)cmd.ExecuteScalar() == 1;
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

        public static Character[] GetCharacterList(int userId)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select count(*) from dnd_characters where user_id = @id", conn);

            cmd.Parameters.AddWithValue("@id", userId);

            Character[] characters = new Character[(long)cmd.ExecuteScalar()];

            cmd = new MySqlCommand("select * from dnd_characters where user_id = @id", conn);

            cmd.Parameters.AddWithValue("@id", userId);

            MySqlDataReader reader = cmd.ExecuteReader();

            for (int i = 0; i < characters.Length; i++)
            {
                reader.Read();
                object[] charData = new object[17];
                reader.GetValues(charData);

                characters[i] = new Character();
                characters[i].Class = new CharacterClass();
                characters[i].Background = new CharacterBackground();

                characters[i].CharacterId = (int)charData[0];

                characters[i].Background.Type = (BackgroundType)charData[16];

                characters[i].Background.LangOne = (Language)charData[2];
                characters[i].Background.LangTwo = (Language)charData[3];

                characters[i].Background.Equipment = (int)charData[4];

                characters[i].Background.Characteristics = new int[4];
                for (int j = 0; j < 4; j++)
                {
                    characters[i].Background.Characteristics[j] = (int)charData[5 + j];
                }

                characters[i].Background.Rerolls = (int)charData[9];

                characters[i].Class.Type = (ClassType)charData[10];

                characters[i].Class.Skills = new int[4];
                for (int j = 0; j < 4; j++)
                {
                    characters[i].Class.Skills[j] = (int)charData[11 + j];
                }

                characters[i].Class.Equipment = (int)charData[15];

                characters[i].Name = "Character " + (int)charData[0];
            }

            return characters;
        }

        public static int CreateCharacter(Character toCreate, int userId)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO dnd_characters(user_id, lang_one, lang_two, bgEquipment, char_one, char_two, char_three, char_four, rerolls, class, skill_one, skill_two, skill_three, skill_four, classEquipment, background) " +
                                                "VALUES(@userId, @lang_one, @lang_two, @bgEquipment, @char_one, @char_two, @char_three, @char_four, @rerolls, @class, @skill_one, @skill_two, @skill_three, @skill_four, @classEquipment, @background)", conn);

            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@lang_one", toCreate.Background.LangOne);
            cmd.Parameters.AddWithValue("@lang_two", toCreate.Background.LangTwo);
            cmd.Parameters.AddWithValue("@bgEquipment", toCreate.Background.Equipment);
            cmd.Parameters.AddWithValue("@char_one", toCreate.Background.Characteristics[0]);
            cmd.Parameters.AddWithValue("@char_two", toCreate.Background.Characteristics[1]);
            cmd.Parameters.AddWithValue("@char_three", toCreate.Background.Characteristics[2]);
            cmd.Parameters.AddWithValue("@char_four", toCreate.Background.Characteristics[3]);
            cmd.Parameters.AddWithValue("@rerolls", toCreate.Background.Rerolls);
            cmd.Parameters.AddWithValue("@class", (int)toCreate.Class.Type);
            cmd.Parameters.AddWithValue("@skill_one", toCreate.Class.Skills[0]);
            cmd.Parameters.AddWithValue("@skill_two", toCreate.Class.Skills[1]);
            cmd.Parameters.AddWithValue("@skill_three", toCreate.Class.Skills[2]);
            cmd.Parameters.AddWithValue("@skill_four", toCreate.Class.Skills[3]);
            cmd.Parameters.AddWithValue("@classEquipment", toCreate.Class.Equipment);
            cmd.Parameters.AddWithValue("@background", (int)toCreate.Background.Type);

            cmd.ExecuteNonQuery();

            //cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);

            return unchecked((int)cmd.LastInsertedId);
        }

        public static void DeleteCharacter(Character toDelete)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("delete from dnd_characters where character_id = @id", conn);

            cmd.Parameters.AddWithValue("@id", toDelete.CharacterId);

            cmd.ExecuteNonQuery();
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
