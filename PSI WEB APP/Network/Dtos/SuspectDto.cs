using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PSI_WEB_APP.Network.Dtos
{
    public class SuspectDto
    {
        public int NationalID { get; set; }
        
        public int PassPortNo { get; set; }
        
        public String Allegation { get; set; }
        
        public String Description { get; set; }
        
        public String AllegationDate { get; set; }

    }
}
