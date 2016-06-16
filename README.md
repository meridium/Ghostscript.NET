# Ghostscript.NET (for Azure fork)
This fork of [Ghostscript.NET](https://github.com/jhabjan/Ghostscript.NET) is based on v1.2.1
and is customized to offer a command line exe that works like gswin64c.exe on Azure Web sites. 
The ordinary gswin64c.exe that is distributed with the Ghostscript windows distribution does not
work on Azure Web sites for some reason but this distribution of Ghostscript.NET includes the
**Ghostscript.NET.CommandLine.64.exe** that works like gswin64c.exe but uses GhostscriptProcessor
under the hood.

It requires gsdll64.dll from the Ghostscript distribution in the same folder as the 
Ghostscript.NET.CommandLine.64.exe application.

The Azure fork is created and maintained by Meriworks (<mailto:dan@meriworks.se>)

[Version history](VERSION-HISTORY.md)

# Ghostscript.NET
**Ghostscript.NET** - (written in C#) is the most completed managed wrapper library around the Ghostscript library (32-bit & 64-bit), an interpreter for the PostScript language, PDF, related software and documentation.

[**NuGet: PM> Install-Package Ghostscript.NET**](http://nuget.org/packages/Ghostscript.NET/)

## Contains
 * GhostscriptViewer - View PDF, EPS or multi-page PostScript files on the screen
 * GhostscriptRasterizer - Rasterize PDF, EPS or multi-page PostScript files to any common image format.
 * GhostscriptProcessor - An easy way to call a Ghostscript library with a custom arguments / switches.
 * GhostscriptInterpreter - The PostScript interpreter.

## Other features
 * allows you to rasterize files in memory without storing the output to disk.
 * supports zoom-in and zoom-out.
 * supports progressive update.
 * allows you to run multiple Ghostscript instances simultaneously within a single process.
 * compatible with 32-bit and 64-bit Ghostscript native library.
 
[If you have found **Ghostscript.NET** useful and has contributed to your project **consider donating**. Donating helps support **Ghostscript.NET**.](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=GS6S7RCAB7KAQ)

[<img src="https://www.paypalobjects.com/en_US/GB/i/btn/btn_donateCC_LG.gif" alt="Click here to lend your support to: Ghostscript.NET and make a donation at pledgie.com !" />](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=GS6S7RCAB7KAQ)


Used in the [**Ghostscript Studio** (Ghostscript IDE)
<span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><img src="https://download-codeplex.sec.s-msft.com/Download?ProjectName=ghostscriptstudio&amp;DownloadId=731788&amp;Build=20779" alt="" width="200" height="50" />](https://ghostscriptstudio.codeplex.com)  

## LICENSE

 Ghostscript.NET is distributed under the GNU Affero General Public License (see [COPYING](COPYING) file).

Josip Habjan (habjan@gmail.com)


## Samples built on the top of the Ghostscript.NET library

Ghostscript.NET.Viewer (supports viewing of the PDF, EPS and multi-page PS files):

![Ghostscript.NET.Viewer](http://a.fsdn.com/con/app/proj/ghostscriptnet/screenshots/gs-net-render.png)

Direct postscript interpretation via Ghostscript.NET:

![Ghostscript.NET.Display](http://imageshack.us/a/img706/6463/es84.png)
