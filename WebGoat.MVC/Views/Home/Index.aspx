<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    WebGoat.MVC Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%:ViewBag.Message%></h2>
    <p>
        <div style="background-color: #558EDF; color: #FFFFFF; font-size: 180%; padding: 6px; padding-top: 8px; font-weight: bold; border: 3px solid #204A7F; border-right: none; border-left: none; margin: 0;">OWASP Top 10 Application Security Risks - 2010</div>
<p><br />
</p>
<table cellspacing="1" cellpadding="1" border="1" width="100%;">
<tr>
<td><center><a href="home/injection" title="Top 10 2010-A1" class="mw-redirect">A1-Injection</a></center>
</td><td>Injection flaws, such as SQL, OS, and LDAP injection, occur when untrusted data is sent to an interpreter as part of a command or query. The attacker’s hostile data can trick the interpreter into executing unintended commands or accessing unauthorized data.
</td></tr>
<tr>
<td><center><a href="home/xss" title="Top 10 2010-A2" class="mw-redirect">A2-Cross Site Scripting (XSS)</a></center>
</td><td>XSS flaws occur whenever an application takes untrusted data and sends it to a web browser without proper validation and escaping. XSS allows attackers to execute scripts in the victim’s browser which can hijack user sessions, deface web sites, or redirect the user to malicious sites.
</td></tr>
<tr>
<td><center><a href="home/broken-auth" title="Top 10 2010-A3" class="mw-redirect">A3-Broken Authentication and Session Management</a></center>
</td><td>Application functions related to authentication and session management are often not implemented correctly, allowing attackers to compromise passwords, keys, session tokens, or exploit other implementation flaws to assume other users’ identities.
</td></tr>
<tr>
<td><center><a href="home/insecure-reference" title="Top 10 2010-A4" class="mw-redirect">A4-Insecure Direct Object References</a></center>
</td><td>A direct object reference occurs when a developer exposes a reference to an internal implementation object, such as a file, directory, or database key. Without an access control check or other protection, attackers can manipulate these references to access unauthorized data.
</td></tr>
<tr>
<td><center><a href="home/csrf" title="Top 10 2010-A5" class="mw-redirect">A5-Cross Site Request Forgery (CSRF)</a></center>
</td><td>A CSRF attack forces a logged-on victim’s browser to send a forged HTTP request, including the victim’s session cookie and any other automatically included authentication information, to a vulnerable web application. This allows the attacker to force the victim’s browser to generate requests the vulnerable application thinks are legitimate requests from the victim.
</td></tr>
<tr>
<td><center><a href="home/security-misconfig" title="Top 10 2010-A6" class="mw-redirect">A6-Security Misconfiguration</a></center>
</td><td>Good security requires having a secure configuration defined and deployed for the application, frameworks, application server, web server, database server, and platform. All these settings should be defined, implemented, and maintained as many are not shipped with secure defaults. This includes keeping all software up to date, including all code libraries used by the application.
</td></tr>
<tr>
<td><center><a href="home/insecure-crypto-storage" title="Top 10 2010-A7" class="mw-redirect">A7-Insecure Cryptographic Storage</a></center>
</td><td>Many web applications do not properly protect sensitive data, such as credit cards, SSNs, and authentication credentials, with appropriate encryption or hashing. Attackers may steal or modify such weakly protected data to conduct identity theft, credit card fraud, or other crimes.
</td></tr>
<tr>
<td><center><a href="home/access-failure" title="Top 10 2010-A8" class="mw-redirect">A8-Failure to Restrict URL Access</a></center>
</td><td>Many web applications check URL access rights before rendering protected links and buttons. However, applications need to perform similar access control checks each time these pages are accessed, or attackers will be able to forge URLs to access these hidden pages anyway.
</td></tr>
<tr>
<td><center><a href="home/transport-layer" title="Top 10 2010-A9" class="mw-redirect">A9-Insufficient Transport Layer Protection</a></center>
</td><td>Applications frequently fail to authenticate, encrypt, and protect the confidentiality and integrity of sensitive network traffic. When they do, they sometimes support weak algorithms, use expired or invalid certificates, or do not use them correctly.
</td></tr>
<tr>
<td><center><a href="home/invalid-forwards" title="Top 10 2010-A10" class="mw-redirect">A10-Unvalidated Redirects and Forwards</a></center>
</td><td>Web applications frequently redirect and forward users to other pages and websites, and use untrusted data to determine the destination pages. Without proper validation, attackers can redirect victims to phishing or malware sites, or use forwards to access unauthorized pages.
</td></tr></table>
<h2> <span class="mw-headline" id="References">References</span></h2>
<p><b>OWASP</b>
</p>
<ul><li> <a href="/index.php/OWASP_Risk_Rating_Methodology" title="OWASP Risk Rating Methodology"> OWASP Risk Rating Methodology</a>
</li><li> <a href="/index.php/Threat_Risk_Modeling" title="Threat Risk Modeling"> Article on Threat/Risk Modeling</a>
</li></ul>
<p><b>External</b>
</p>
<ul><li><a href="http://fairwiki.riskmanagementinsight.com/" class="external text" rel="nofollow">FAIR Information Risk Framework</a>
</li><li><a href="http://msdn.microsoft.com/en-us/library/aa302419.aspx" class="external text" rel="nofollow">Microsoft Threat Modeling (STRIDE and DREAD)</a>
</li></ul>
<p><br />
</p>
<div align="center">
    </p>
</div>
</asp:Content>
