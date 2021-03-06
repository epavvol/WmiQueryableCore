using System;
using System.Collections.Generic;
using VNetDev.WmiQueryableCore.Attributes;

namespace VNetDev.WmiQueryableCore.Sms.Classes
{
    /// <summary>
    /// Namespace: root\sms\site_EIC
    /// WMI Class: SMS_PDF_Package
    /// </summary>
    [WmiClass(Name = "SMS_PDF_Package")]
    public class SmsPdfPackage
    {
        /// <summary>
        /// WMI static method <c>ProcessInBox</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint ProcessInBoxDelegate(WmiContext wmiContext);
        /// <summary>
        /// WMI static method <c>ProcessInBox</c>.
        /// </summary>
        public static ProcessInBoxDelegate ProcessInBox;
        
        /// <summary>
        /// WMI static method <c>LoadPDF</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="pdfFile">WMI Property <c>PDFFile</c> of type <c>string</c>.</param>
        /// <param name="pdfFileName">WMI Property <c>PDFFileName</c> of type <c>string</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint LoadPdfDelegate(WmiContext wmiContext, string pdfFile = default, string pdfFileName = default);
        /// <summary>
        /// WMI static method <c>LoadPDF</c>.
        /// </summary>
        public static LoadPdfDelegate LoadPdf;
        
        /// <summary>
        /// WMI static method <c>LoadIconForPDF</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="icon">WMI Property <c>Icon</c> of type <c>ICollection{byte}</c>.</param>
        /// <param name="iconFileName">WMI Property <c>IconFileName</c> of type <c>string</c>.</param>
        /// <param name="pdfid">WMI Property <c>PDFID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint LoadIconForPdfDelegate(WmiContext wmiContext, ICollection<byte> icon = default, string iconFileName = default, uint pdfid = default);
        /// <summary>
        /// WMI static method <c>LoadIconForPDF</c>.
        /// </summary>
        public static LoadIconForPdfDelegate LoadIconForPdf;
        
        /// <summary>
        /// WMI static method <c>GetPDFData</c> describing delegate.
        /// <param name="wmiContext">Context object for static method execution.</param>
        /// <param name="pdfid">WMI Property <c>PDFID</c> of type <c>uint</c>.</param>
        /// <returns>Result of type <c>int</c>.</returns>
        /// </summary>
        public delegate uint GetPdfDataDelegate(WmiContext wmiContext, uint pdfid = default);
        /// <summary>
        /// WMI static method <c>GetPDFData</c>.
        /// </summary>
        public static GetPdfDataDelegate GetPdfData;
        /// <summary>
        /// WMI Property Icon
        /// </summary>
        public ICollection<byte> Icon { get; set; }
        /// <summary>
        /// WMI Property IconSize
        /// </summary>
        public uint IconSize { get; set; }
        /// <summary>
        /// WMI Property Language
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// WMI Property Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// WMI Property PDFFileName
        /// </summary>
        public string PdfFileName { get; set; }
        /// <summary>
        /// WMI Property PDFID
        /// </summary>
        public uint Pdfid { get; set; }
        /// <summary>
        /// WMI Property Publisher
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// WMI Property RequiredIconNames
        /// </summary>
        public ICollection<string> RequiredIconNames { get; set; }
        /// <summary>
        /// WMI Property Status
        /// </summary>
        public uint Status { get; set; }
        /// <summary>
        /// WMI Property Version
        /// </summary>
        public string Version { get; set; }
    }
}
