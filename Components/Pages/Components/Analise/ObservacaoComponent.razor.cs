﻿using Microsoft.AspNetCore.Components;
using Radzen;

namespace Front.Components.Pages.Components.Analise;

public partial class ObservacaoComponent : ComponentBase
{
    string htmlValue =
        @"<h2 style=""text-align:center"">Accelerated, smarter, and cost-effective Blazor development</h2>
    <h3 style=""text-align:center"">Radzen Blazor Studio provides tons of productivity gains for Blazor developers</h3>
    <div style=""text-align:center"">
        <img alt=""Radzen Blazor Studio"" src=""images/radzen-blazor-studio-dark.png"" width=""300"">
    </div>
    <h4 style=""text-align:center"">Get started today. Radzen Blazor Studio is free to use.</h4>
    <div style=""text-align:center"">
        <a href=""https://www.radzen.com/blazor-studio/download/"" target=""_blank"" title=""Get Radzen Blazor Studio for Windows, Mac or Linux"">Download Now</a>
    </div>";

    //EventConsole console;

    void OnPaste(HtmlEditorPasteEventArgs args)
    {
        //console.Log($"Paste: {args.Html}");
    }

    void OnChange(string html)
    {
        //console.Log($"Change: {html}");
    }

    void OnInput(string html)
    {
        //console.Log($"Input: {html}");
    }

    void OnExecute(HtmlEditorExecuteEventArgs args)
    {
        //console.Log($"Execute: {args.CommandName}");
    }

    void OnUploadComplete(UploadCompleteEventArgs args)
    {
        //console.Log($"Upload complete: {args.RawResponse}");
    }
}