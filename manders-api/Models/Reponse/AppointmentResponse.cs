using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manders_api.Models.Reponse {
    public class AppointmentResponse : IResponse {
        public AppointmentResponse(string type, string message, Appointment appointment) {
            Type = type;
            Message = message;
            Appointment = appointment;
        }

        public string Type { get; set; }
        public string Message { get; set; }
        public Appointment Appointment { get; set; }
    }
}