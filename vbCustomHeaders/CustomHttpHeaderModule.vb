
Namespace CustomHttpHeaders


    Public Class CustomHttpHeaderModule
        Implements System.Web.IHttpModule


        Public Sub Dispose() Implements System.Web.IHttpModule.Dispose
            ' Dim modul As CustomHttpHeaders.CustomHttpHeaderModule = New CustomHttpHeaderModule()
        End Sub


        Public Sub Init(context As System.Web.HttpApplication) Implements System.Web.IHttpModule.Init
            ' AddHandler context.BeginRequest, New System.EventHandler(AddressOf context_BeginRequest)
            AddHandler context.EndRequest, New System.EventHandler(AddressOf context_EndRequest)
        End Sub


        Private Sub context_BeginRequest(sender As Object, e As System.EventArgs)
            If System.Web.HttpContext.Current IsNot Nothing AndAlso System.Web.HttpContext.Current.Request IsNot Nothing Then
                Dim request As System.Web.HttpRequest = System.Web.HttpContext.Current.Request
                'request.Headers.Add("name", "value")
            End If ' (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Response != null)
        End Sub ' context_BeginRequest


        Private Sub context_EndRequest(sender As Object, e As System.EventArgs)

            If System.Web.HttpContext.Current IsNot Nothing AndAlso System.Web.HttpContext.Current.Response IsNot Nothing Then
                Dim response As System.Web.HttpResponse = System.Web.HttpContext.Current.Response
                ' response.AddHeader("Content-Language", "*");
                'response.AppendHeader("P3P", "CP=\\\"IDC DSP COR ADM DEVi TAIi PSA PSD IVAi IVDi CONi HIS OUR IND CNT\\\"");
                response.AddHeader("P3P", "CP=\""IDC DSP COR ADM DEVi TAIi PSA PSD IVAi IVDi CONi HIS OUR IND CNT\""")
            End If ' (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Response != null)
        End Sub ' context_EndRequest


    End Class ' myHTTPHeaderModule


End Namespace ' CustomHttpHeaders
