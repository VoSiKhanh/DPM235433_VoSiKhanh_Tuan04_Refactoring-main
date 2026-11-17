using System;
namespace DPM235433_VoSiKhanh_Tuan04_Collapse_Hierarchy
{
    public class WebPage { public string Title; public WebPage(string t){Title=t;} }
    public class ArticlePage : WebPage { public ArticlePage(string t):base(t){} } // adds nothing
    public class CollapseHierarchy_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Collapse Hierarchy - ArticlePage adds nothing over WebPage");
            var page = new ArticlePage("Hello World");
            Console.WriteLine("  Page title: " + page.Title);
        }
    }
}
