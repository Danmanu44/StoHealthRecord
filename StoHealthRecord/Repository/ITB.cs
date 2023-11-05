using System.Data;

namespace StoHealthRecord.Repository
{
    public interface ITB
    {
        String DocumentUpload(IFormFile file);
        DataTable TBDataTable(string path);
        void ImportTBData(DataTable tb_data);
    }
}
