using System;
namespace DPM235433_VoSiKhanh_Tuan04_Pull_Up_Constructor_Body
{
    public abstract class Widget { public string Id; public string Color;
        public Widget(string id, string color) { Id=id; Color=color; } }
    public class Button : Widget { public Button(string id, string color):base(id,color){} public void Render() => Console.WriteLine("  Button["+Id+"] color:"+Color); }
    public class TextBox: Widget { public TextBox(string id, string color):base(id,color){} public void Render() => Console.WriteLine("  TextBox["+Id+"] color:"+Color); }
    public class PullUpConstructorBody_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Pull Up Constructor Body - UI Widgets");
            new Button("btn1","blue").Render(); new TextBox("txt1","white").Render();
        }
    }
}
