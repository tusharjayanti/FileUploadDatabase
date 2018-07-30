using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;


namespace FileUploadDatabase.Models
{
    public class FileModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}