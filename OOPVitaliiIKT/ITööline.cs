using System;
using System.Collections.Generic;
using System.Text;

namespace OOPVitaliiIKT
{
    
    public enum TööTüüp
    {
        Palk,
        Toetus
    }
    public interface ITööline
    {
        TööTüüp VäljamakseTüüp { get; set; }
        double ArvutaPalk(); // Ainult meetodi allkiri
    }
}
