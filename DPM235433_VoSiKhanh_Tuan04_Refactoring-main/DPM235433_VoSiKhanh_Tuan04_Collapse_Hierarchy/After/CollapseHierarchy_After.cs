using System;
namespace DPM235433_VoSiKhanh_Tuan04_Collapse_Hierarchy
{
    public class WebPageMerged { public string Title; public WebPageMerged(string t){Title=t;} } // merged
    public class CollapseHierarchy_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Collapse Hierarchy - ArticlePage merged into WebPageMerged");
            var page = new WebPageMerged("Hello World");
            Console.WriteLine("  Page title: " + page.Title);
        }
    }
}
