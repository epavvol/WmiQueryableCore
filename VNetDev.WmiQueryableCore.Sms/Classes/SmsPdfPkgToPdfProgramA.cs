using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PDFPkgToPDFProgram_a
    /// </summary>
    [WmiClass(Name = "SMS_PDFPkgToPDFProgram_a")]
    public class SmsPdfPkgToPdfProgramA
    {
        /// <summary>
        /// WMI Property PDF_Package
        /// </summary>
        [WmiProperty(Name = "PDF_Package")]
        public object PdfPackage { get; set; }
        /// <summary>
        /// WMI Property PDF_Program
        /// </summary>
        [WmiProperty(Name = "PDF_Program")]
        public object PdfProgram { get; set; }
    }
}
