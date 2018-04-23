using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using DevExpress.XtraReports.UI;

namespace DevExpressWebGardenReporting {
    public class ReportStorageWebExtension1 : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension {
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
            using(var fileStream = File.OpenRead(HttpContext.Current.Server.MapPath("~\\Reports\\" + url))) {
                var report = XtraReport.FromStream(fileStream, true);
                return SerializeReport(report);
            }
        }

        public override Dictionary<string, string> GetUrls() {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("Invoice", "Invoice Report");
            var files = Directory.GetFiles(HttpContext.Current.Server.MapPath("~\\Reports\\"));
            foreach(var item in files.Where(x => x.Contains(".repx")).Select(x => x.Split('\\').Last())) {
                dictionary.Add(item, item);
            }
            return dictionary;
        }

        public override void SetData(DevExpress.XtraReports.UI.XtraReport report, string url) {
            url += url.EndsWith(".repx") ? "" : ".repx";
            using(var fileStream = File.OpenWrite(HttpContext.Current.Server.MapPath("~\\Reports\\" + url))) {
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
