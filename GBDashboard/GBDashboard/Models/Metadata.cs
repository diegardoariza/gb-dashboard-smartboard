using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GBDashboard.Models
{
    public class FacesheetMetadata
    {
        [Display(Name = "Facesheet Number")]
        public int facesheet_id;
        [Display(Name = "Customer ID")]
        public int customer_id;
        [Display(Name = "Date Of Service")]
        public System.DateTime date_of_service;
        [Display(Name = "Location Name")]
        public string location_name;
        [Display(Name = "Description")]
        public string description;
        [Display(Name = "Time In")]
        public System.DateTime time_in;
        [Display(Name = "Time Out")]
        public System.DateTime time_out;
        [Display(Name = "Notes")]
        public string notes;
        [Display(Name = "Patient Full Name")]
        public string patient;
        [Display(Name = "Insurance Name")]
        public string insurance_name;
        [Display(Name = "Facesheet Status")]
        public string facesheet_status_name;
        [Display(Name = "Payment Type")]
        public string payment_type;
        [Display(Name = "Facesheet Source")]
        public string facesheet_source;
    }
}