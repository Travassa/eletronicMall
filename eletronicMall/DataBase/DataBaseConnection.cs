using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eletronicMall.DataBase
{
    public class DataBaseConnection
    {
        private IMongoDatabase _database;
        private void InitializeMongoDB()
        {
            try
            {
                // Connection string (modify as needed for your MongoDB setup)
                //"mongodb+srv://<db_username>:<db_password>@projectipca.qsiry.mongodb.net/?retryWrites=true&w=majority&appName=projectIpca"; // Change to your connection string
                string connectionString = "mongodb+srv://sandro:afa321321987654@projectipca.qsiry.mongodb.net/?retryWrites=true&w=majority&appName=projectIpca"; // Change to your connection string
                var client = new MongoClient(connectionString);

                // Get the database (replace 'testdb' with your database name)
                _database = client.GetDatabase("testdb");

                MessageBox.Show("Connected to MongoDB successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"MongoDB connection failed: {ex.Message}");
            }
        }
        private void FetchData()
        {
            try
            {
                // Replace 'collectionName' with your actual collection name
                var collection = _database.GetCollection<BsonDocument>("collectionName");

                // Fetch all documents in the collection
                var documents = collection.Find(new BsonDocument()).ToList();

                // Display data (for demonstration)
                foreach (var doc in documents)
                {
                    MessageBox.Show(doc.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
            }
        }
    }

}
