using System.Collections.Generic;

namespace DomainDriven.CleanArchitecture.Contracts.v1
{
    public class BaseResponse
    {
        public List<string> Errors { get; set; }


        public BaseResponse()
        {
            Errors = new List<string>();
        }
    }
}
