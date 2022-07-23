using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcWebUI.TagHelpers
{
    [HtmlTargetElement("product-list-pager")]
    public class PagingTagHelper:TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }

        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }

        [HtmlAttributeName("current-category")]
        public int CurrentCategory { get; set; }

        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }

        [HtmlAttributeName("route-controller")]
        public string Route { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
            output.TagName = "div";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<ul class='pagination'>");

            for (int i = 1; i <= PageCount; i++)
            {
                stringBuilder.AppendFormat("<li  class='page-item {0}'>", i == CurrentPage ? "active" : "");
                stringBuilder.AppendFormat("<a class='page-link' href='/product/index?page={0}&category={1}'> {2} </a>", i, CurrentCategory, i);
                stringBuilder.AppendFormat("</li>");
            }
             output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }
    }
}