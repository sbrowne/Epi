using EPiServer.Core;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Episerver9.Models.Pages
{
    [ContentType]
    public class StartPage : PageData
    { 
        public virtual string Heading { get; set; }  // test changed username
        public virtual XhtmlString MainBody { get; set; }   
    }
}