using HassanShop.Front.Models;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HassanShop.Front.Helper
{
    public static class RazorHelper
    {
            public static IHtmlString RenderPagination(this HtmlHelper<ProductViewModel> html,
            int currentPage, 
            int totalPage)
        {
            var tag = new TagBuilder("ul");
            tag.AddCssClass("pagination");
            StringBuilder htmlBuilder = new StringBuilder();
            
            for (int i = 0; i < totalPage; i++)
            {
                if (i < 3 || i >= totalPage - 3 || i == totalPage / 2)
                {
                    // <li> <a href="/Home/Index?page=@i&size=5"> @index</a> </li>
                    var liTag = new TagBuilder("li");
                    htmlBuilder.Append(liTag.ToString(TagRenderMode.StartTag));
                    var aTag = new TagBuilder("a");
                    aTag.InnerHtml = i.ToString();
                    aTag.Attributes.Add("href", $"/Home/Index?page={i}");
                    htmlBuilder.Append(aTag.ToString(TagRenderMode.Normal));
                    htmlBuilder.Append(liTag.ToString(TagRenderMode.EndTag));
                }
                else
                {
                    htmlBuilder.Append("<li><a>.</a></li>");
                }
            }
            tag.InnerHtml = htmlBuilder.ToString();
            return MvcHtmlString.Create(tag.ToString(TagRenderMode.Normal));
        }
    }
}
