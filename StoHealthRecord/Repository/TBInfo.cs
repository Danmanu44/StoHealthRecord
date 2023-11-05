using System.Data;
using System.Data.OleDb;

namespace StoHealthRecord.Repository
{
    public class TBInfo : TBInfoBase, ITB
    {
        private IConfiguration config;
        private IWebHostEnvironment client;

        public TBInfo(IConfiguration configuration,IWebHostEnvironment web_environment)

        {
            this.config = configuration;
            this.client = web_environment;
            
        }
        public string DocumentUpload(IFormFile formFile)
        {
            string uploadPath = client.WebRootPath;
            string dest_path = Path.Combine(uploadPath, "excel_uploaded");

            if(!Directory.Exists(dest_path))
            {
                Directory.CreateDirectory(dest_path);
            }
            string sourceFile = Path.GetFileName(formFile.FileName);
            string path = Path.Combine(uploadPath, sourceFile);
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                formFile.CopyTo(fs);
            }
            return path;

        }

        public void ImportTBData(DataTable tb_data)
        {
            throw new NotImplementedException();

        }
    }
}
