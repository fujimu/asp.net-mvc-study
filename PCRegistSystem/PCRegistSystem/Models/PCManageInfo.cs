using System.Data.Entity;

namespace PCRegistSystem.Models
{
    public class PCManageInfo
    {
        public int ID { get; set; }
        public string IPAdress { get; set; }
        public Const.UsetCategory UserCategory { get; set; }
        public string MachineType { get; set; }
        public string ModelNumber { get; set; }
        public string UserName { get; set; }
        public string PCName { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }
    }

    public class PCManageInfoDBContext : DbContext
    {
        public DbSet<PCManageInfo> PCManageInfos { get; set; }
    }
}