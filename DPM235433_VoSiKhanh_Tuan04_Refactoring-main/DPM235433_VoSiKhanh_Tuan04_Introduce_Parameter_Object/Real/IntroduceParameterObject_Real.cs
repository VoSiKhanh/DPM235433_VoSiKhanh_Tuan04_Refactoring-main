using System;
namespace DPM235433_VoSiKhanh_Tuan04_Introduce_Parameter_Object
{
    public class SearchCriteria { public string Keyword; public string Category; public double MaxPrice; }
    public class IntroduceParameterObject_Real
    {
        public string Search(SearchCriteria criteria)
            => $"Searching '{criteria.Keyword}' in '{criteria.Category}' under ${criteria.MaxPrice}";
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Introduce Parameter Object - Product search");
            var criteria = new SearchCriteria { Keyword = "laptop", Category = "Electronics", MaxPrice = 1500 };
            Console.WriteLine("  " + Search(criteria));
        }
    }
}
