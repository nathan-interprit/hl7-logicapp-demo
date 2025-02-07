using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Interprit.Demo.HL7
{
    /// <summary>
    /// An A01 event is sent as a result of a patient undergoing the admission process which assigns the patient to a bed. 
    /// It signals the beginning of a patient's stay in a healthcare facility.
    /// </summary>
    public class ADT_A01
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ADT_A01"/> class.
        /// </summary>
        public ADT_A01()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ADT_A01"/> class.
        /// </summary>
        /// <param name="hl7String">The HL7 string.</param>
        public ADT_A01(string hl7String)
        {
        }
    }
}

        