using Newtonsoft.Json;

namespace Common.Models
{
    public class ErrorModel{
        public int Code {get;set;}
        public string Message { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}