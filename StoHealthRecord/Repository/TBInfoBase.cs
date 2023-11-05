using System.Data;
using System.Data.OleDb;

namespace StoHealthRecord.Repository
{
    public class TBInfoBase
    {

        public DataTable TBDataTable(string path)
        {
            var constr = config.GetConnectionString("excelconnection");
            DataTable dt = new DataTable();
            constr = string.Format(constr, path);
            using (OleDbConnection conn = new OleDbConnection(constr))
            {
                using (OleDbCommand cmd = conn.CreateCommand())
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter)
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        DataTable excel_schema;
                        excel_schema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        var sheetName = excel_schema.Rows[0]["Table_Name"].ToString();
                        conn.Close();
                        cmd.CommandText = $"Select * from [ {sheetName} ]";
                        adapter.SelectCommand = cmd;

                    }
                }
            }

        }
    }
}