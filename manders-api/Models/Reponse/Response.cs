using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manders_api.Models.Reponse {
    public class Response : IResponse {
        public Response(string type, string message) {
            Type = type;
            Message = message;
        }

        public string Type { get; set; }
        public string Message { get; set; }
    }
}
