using System;
using System.Data;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Hashing
{
    public class HashSum
    {
        private DataTable dt;
        public HashSum(DataTable dt, String secret = "PZS")
        {
            if (dt.TableName == "")
            {
                dt.TableName = secret;
            }
            this.dt = dt;
        }

        public HashSum(SqlDataReader reader, String secret = "PZS")
        {
            DataTable dt = new DataTable();
            dt.Load(reader);
            dt.TableName = secret;
            this.dt = dt;
        }

        private byte[] SerializeData()
        {
            // Serialize the table
            DataContractSerializer serializer = new DataContractSerializer(typeof(DataTable));
            MemoryStream memoryStream = new MemoryStream();
            XmlWriter writer = XmlDictionaryWriter.CreateBinaryWriter(memoryStream);
            serializer.WriteObject(memoryStream, this.dt);
            byte[] serializedData = memoryStream.ToArray();
            return serializedData;
        }

        private byte[] CalculateHashValue(byte[] SerializedData)
        {
            // Calculte the serialized data's hash value
            SHA1CryptoServiceProvider SHA = new SHA1CryptoServiceProvider();
            byte[] hash = SHA.ComputeHash(SerializedData);
            return hash;
        }

        private String GetHash(byte[] hash)
        {
            return Convert.ToBase64String(hash);
        }

        public String GetHashString()
        {
            byte[] serializedData = this.SerializeData();
            byte[] hashValue = this.CalculateHashValue(serializedData);
            return this.GetHash(hashValue);
        }

    }
}