﻿using CourseApp.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CourseApp.Mvc.TagBuilders
{


    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkBuilder : TagHelper
    {
        public string PageAction { get; set; }
        public PagingInfo PageModel { get; set; }

        IUrlHelperFactory urlHelperFactory;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public PageLinkBuilder(IUrlHelperFactory factory)
        {
            urlHelperFactory = factory;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {


            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder div = new TagBuilder("div");
            TagBuilder ul = new TagBuilder("ul");
            ul.AddCssClass("pagination pagination-lg");
            for (int i = 1; i <= PageModel.TotalPage; i++)
            {
                TagBuilder li = new TagBuilder("li");
                li.AddCssClass("page-item");
                if (i == PageModel.ActivePage)
                {
                    li.AddCssClass("active");
                }
                TagBuilder a = new TagBuilder("a");
                a.AddCssClass("page-link");
                a.Attributes["href"] = urlHelper.Action(PageAction, new { pageNo = i });
                a.InnerHtml.Append(i.ToString());
                li.InnerHtml.AppendHtml(a);
                ul.InnerHtml.AppendHtml(li);

            }
            div.InnerHtml.AppendHtml(ul);

            output.Content.AppendHtml(div);
        }



    }
}