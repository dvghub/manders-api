using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manders_api.Models.Reponse {
    public interface IResponse {
        string Type { get; set; }
        string Message { get; set; }
    }
}
