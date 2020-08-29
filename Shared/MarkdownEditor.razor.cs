using System;
using Markdig;
using Microsoft.AspNetCore.Components;

namespace mither.Shared
{
    public class MarkdownEditorBase : ComponentBase
    {
        public string Body { get; set; } = string.Empty;
        public string Preview => Markdig.Markdown.ToHtml(
            markdown: Body,
            pipeline: new MarkdownPipelineBuilder().UseAdvancedExtensions().Build()
);
    }
}