using System;

namespace WebServices.Models
{
    internal class WebServiceAttribute : Attribute
    {
        public string Namespace { get; set; }
    }
}