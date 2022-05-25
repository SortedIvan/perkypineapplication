using models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace data_layer.Data
{
    public class PerkyPineDB
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;uid=root;database=perkypinedb");

        public PerkyPineDB()
        {
//            SELECT*
//FROM gameidea
//INNER JOIN gamecharacter
//ON gameidea.gameideaid = gamecharacter.gameideaid
//WHERE gameidea.gameideaid = "123";
        }

        public List<GameCharacter> GetAllGameCharactersFromDB()
        {
            string quary = @"SELECT * FROM gamecharacter";
            List<GameCharacter> getAllGameCharacters = new List<GameCharacter>();
            try
            {
                using (connection)
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(quary, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                GameCharacter character = new GameCharacter(reader.GetString(0), reader.GetString(1));
                                getAllGameCharacters.Add(character);
                            }
                            return getAllGameCharacters;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("something went wrong!");
            }
        }

        //public List<GameIdea> GetAllGameIdeasFromDB()
        //{
        //    string query = @"SELECT * FROM gameidea";
        //    List<GameIdea> getAllGameIdeas = new List<GameIdea>();
        //    try
        //    {
        //        using (connection)
        //        {
        //            connection.Open();
        //            using (MySqlCommand command = new MySqlCommand(query, connection))
        //            {
        //                using (MySqlDataReader reader = command.ExecuteReader())
        //                {

        //                    while (reader.Read())
        //                    {
        //                        GameIdea gameIdea = new GameIdea(reader.GetString(0), reader.GetString(1));
        //                        getAllGameIdeas.Add(gameIdea);
        //                    }
        //                    return getAllGameIdeas;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception("something went wrong!");
        //    }
        //}




        public GameIdea GetGameIdea(Guid gameIdeaID)
        {
            string query = @"SELECT * FROM gameidea INNER JOIN gamecharacter ON gameidea.gameideaid = gamecharacter.gameideaid
                             WHERE gameidea.gameideaid = @gameIdeaID";
            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            string gameIdeaName = "";
            try
            {
                using (connection)
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@gameIdeaID", gameIdeaID);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                gameCharacters.Add(new GameCharacter(gameIdeaID,reader.GetString(2), reader.GetString(3)));
                                gameIdeaName = reader.GetString(1);

                            }
                            return new GameIdea(gameIdeaID, gameIdeaName, gameCharacters);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("something went wrong!");
            }
        }
    }
}
