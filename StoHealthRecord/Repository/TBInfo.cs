﻿using System.Data;
using System.Data.OleDb;

namespace StoHealthRecord.Repository
{
    public class TBInfo : ITB
    {
        private IConfiguration config;
        private IWebHostEnvironment client;

        public TBInfo(IConfiguration configuration,IWebHostEnvironment web_environment)

        {
            this.config = configuration;
            this.client = web_environment;
            
        }
        public string DocumentUpload(IFormFile file)
        {
           
        }

        public void ImportTBData(DataTable tb_data)
        {
            throw new NotImplementedException();
        }

        public DataTable TBDataTable(string path)
        {
            var constr = config.GetConnectionString("excelconnection");
            DataTable dt = new DataTable();
            constr = string.Format(constr, path);
            using(OleDbConnection conn = new OleDbConnection(constr))
            {
                using(OleDbCommand cmd = conn.CreateCommand())
                {
                    using(OleDbDataAdapter adapter = new OleDbDataAdapter)
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        DataTable excel_schema;
                        excel_schema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,null);

                    }
                }
            }
           
        }
    }
}
