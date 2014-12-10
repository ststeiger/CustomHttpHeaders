<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HeaderTest._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <a href="http://www.w3.org/TR/P3P/" target="_blank">
                    P3P - Test
                </a>
            </h1>


            <h4>Add the <a href="http://stackoverflow.com/questions/389456/cookie-blocked-not-saved-in-iframe-in-internet-explorer" target="_blank">P3P-HTTP-Header</a>
                to Reporting-Services 
            </h4>

            <br /><br />
            See <a href="http://stackoverflow.com/questions/27383156/ie-silently-dropping-cookies-on-iframe-page-ssl/27404818#27404818" target="_blank">SO 27383156</a>
            <br /><br />

            Use the 
            <a href="https://chrome.google.com/webstore/detail/http-headers/mhbpoeinkhpajikalhfpjjafpfgjnmgk" target="_blank">Google-Chrome HTTP-Headers-Extension</a>
            to see the headers
        </div>

         <br /><br />
        <a href="http://blogs.msdn.com/b/ieinternals/archive/2013/10/16/strict-p3p-validation-option-rejects-invalid-p3p-policies.aspx" target="_blank">
            And more EVIL things
        </a>
         <br /><br />
        <a href="http://www.microsoft.com/w3c/p3p.xml" target="_blank">P3P-Sample-File</a>
        

        <br /><br />
        <br /><br />
        <code title="PHP">
            header("P3P: policyref=\"http://www.example.com/w3c/p3p.xml\", CP=\"CURa ADMa DEVa CONo HISa OUR IND DSP ALL COR\"");
        </code><br /><br />

        <code title="Perl">
            print "P3P: policyref=\"http://www.example.com/w3c/p3p.xml\", CP=\"CURa ADMa DEVa CONo HISa OUR IND DSP ALL COR\"\n\n";
        </code><br /><br />

        <code title="Java">
            Response.setHeader("P3P","CP=&#39;CURa ADMa DEVa CONo HISa OUR IND DSP ALL COR&#39;")
        </code><br /><br />

            
        <code title="ColdFusion">
            &lt;cfheader name="P3P" value="CP=&#39;CURa ADMa DEVa CONo HISa OUR IND DSP ALL COR&#39;" /&gt;
        </code><br /><br />

        <code title="HTaccess">
            Header append P3P 'CP="CURa ADMa DEVa CONo HISa OUR IND DSP ALL COR", policyref="/w3c/p3p.xml"'
        </code><br /><br />

    </form>
</body>
</html>
