using System;

namespace RegistryService.DTOs
{
    public class ApiInfoDTO
    {
        public long ID { get; set; }
        public string ControllerName { get; set; }
        public string ServiceName { get; set; }
        public string Url { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
