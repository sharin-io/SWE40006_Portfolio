using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Runtime.InteropServices;

namespace SWE40006_Task3_Web.Pages
{
    public class IndexModel : PageModel
    {
        // Core Academic Properties
        public string StudentName { get; private set; } = "Shin Thant Thi Ri";
        public string StudentID { get; private set; } = "104842811";
        public string UnitCode { get; private set; } = "SWE40006 Software Deployment and Evolution";

        // Dynamic Telemetry Metrics
        public string ServerTimeUtc { get; private set; } = string.Empty;
        public string TargetOS { get; private set; } = string.Empty;
        public string DotNetVersion { get; private set; } = string.Empty;
        public string AppStatus { get; private set; } = "Active Production Environment Build";

        public void OnGet()
        {
            // Execute runtime diagnostics tracking
            ServerTimeUtc = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss 'UTC'");
            TargetOS = RuntimeInformation.OSDescription;
            DotNetVersion = RuntimeInformation.FrameworkDescription;
        }
    }
}
