
namespace CustomHttpHeaders
{


    public class CustomHttpHeaderModule : System.Web.IHttpModule
    {


        public void Dispose()
        {
            // CustomHttpHeaders.CustomHttpHeaderModule mod = new CustomHttpHeaderModule();
        }


        public void Init(System.Web.HttpApplication context)
        {
            // context.BeginRequest += new System.EventHandler(context_BeginRequest);
            context.EndRequest += new System.EventHandler(context_EndRequest);
        }


        void context_BeginRequest(object sender, System.EventArgs e)
        {
            if (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Request != null)
            {
                System.Web.HttpRequest request = System.Web.HttpContext.Current.Request;
                // request.Headers.Add("name", "value");
            } // End if (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Response != null)
        }


        void context_EndRequest(object sender, System.EventArgs e)
        {
            if (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Response != null)
            {
                System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;

                try
                {

                    // response.Headers["P3P"] = "CP=\\\"IDC DSP COR ADM DEVi TAIi PSA PSD IVAi IVDi CONi HIS OUR IND CNT\\\"":
                    // response.Headers.Set("P3P", "CP=\\\"IDC DSP COR ADM DEVi TAIi PSA PSD IVAi IVDi CONi HIS OUR IND CNT\\\"");
                    // response.AddHeader("P3P", "CP=\\\"IDC DSP COR ADM DEVi TAIi PSA PSD IVAi IVDi CONi HIS OUR IND CNT\\\"");
                    response.AppendHeader("P3P", "CP=\\\"IDC DSP COR ADM DEVi TAIi PSA PSD IVAi IVDi CONi HIS OUR IND CNT\\\"");
                    response.AppendHeader("IE-SUCKS", "AND SSRS TOO");
                }
                catch(System.Exception ex)
                {
                    // WTF ? 
                    System.Console.WriteLine(ex.Message); // Suppress warning
                }
                
            } // End if (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Response != null)

        } // End Using context_EndRequest


    } // End Class myHTTPHeaderModule


} // End Namespace CustomHttpHeaders
