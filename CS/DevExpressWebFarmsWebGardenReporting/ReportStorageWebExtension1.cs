using System.Collections.Generic;
using System.IO;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace DevExpressWebFarmsWebGardenReporting {
    public class ReportStorageWebExtension1 : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension {

        readonly string workingDirectory;
        public ReportStorageWebExtension1(string workingDirectory) {
            this.workingDirectory = workingDirectory;
        }
        public override bool IsValidUrl(string url) {
            return true;
        }

        public override string SetNewData(XtraReport report, string defaultUrl) {
            this.SetData(report, defaultUrl);
            return defaultUrl;
        }

        public override byte[] GetData(string url) {
            if(url == "Invoice")
                return SerializeReport(new InvoiceReport());

            url += url.EndsWith(".repx") ? "" : ".repx";
            using(var fileStream = File.OpenRead(Path.Combine(workingDirectory, url))) {
                var report = XtraReport.FromStream(fileStream, true);
                return SerializeReport(report);
            }
        }

        public override Dictionary<string, string> GetUrls() {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("Invoice", "Invoice Report");
            var files = Directory.GetFiles(workingDirectory);
            foreach(var item in files.Where(x => x.Contains(".repx")).Select(x => x.Split('\\').Last())) {
                dictionary.Add(item, item);
            }
            return dictionary;
        }

        public override void SetData(DevExpress.XtraReports.UI.XtraReport report, string url) {
            url += url.EndsWith(".repx") ? "" : ".repx";
            using(var fileStream = File.OpenWrite(Path.Combine(workingDirectory, url))) {
                report.SaveLayoutToXml(fileStream);
            }
        }

        public override bool CanSetData(string url) {
            return true;
        }

        byte[] SerializeReport(XtraReport report) {
            using(MemoryStream stream = new MemoryStream()) {
                report.SaveLayoutToXml(stream);
                stream.Position = 0;
                return stream.GetBuffer();
            }
        }
    }
}
