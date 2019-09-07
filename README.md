# Reproduction code for a bug in html-agility-pack

When server responses with invalid content encoding name, the following exception occurres inside html-agility-pack library.

```
System.ArgumentException: 'identity' is not a supported encoding name. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.
Parameter name: name
   at System.Text.EncodingTable.GetCodePageFromName(String name)
   at HtmlAgilityPack.HtmlWeb.Get(Uri uri, String method, String path, HtmlDocument doc, IWebProxy proxy, ICredentials creds) in C:\Users\Jonathan\source\repos\HtmlAgilityPack\HtmlAgilityPack.Shared\HtmlWeb.cs:line 1549
   at HtmlAgilityPack.HtmlWeb.LoadUrl(Uri uri, String method, WebProxy proxy, NetworkCredential creds) in C:\Users\Jonathan\source\repos\HtmlAgilityPack\HtmlAgilityPack.Shared\HtmlWeb.cs:line 2068
   at HtmlAgilityPack.HtmlWeb.Load(Uri uri, String method) in C:\Users\Jonathan\source\repos\HtmlAgilityPack\HtmlAgilityPack.Shared\HtmlWeb.cs:line 1277
   at repro_bug_in_html_agility_pack.Program.Main(String[] args) in /Users/yas/Projects/repro-bug-in-html-agility-pack/Program.cs:line 16
```

I expected HtmlWeb.OverrideEncoding to be able to help in this case, but it didn't and the same exception was thrown.
