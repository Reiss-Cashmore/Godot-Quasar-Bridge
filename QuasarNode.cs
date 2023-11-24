using Godot;
using System;
using System.Threading.Tasks;

public class QuasarNode : Node
{
  public override void _Ready()
  {
    var js = Engine.GetSingleton("JavaScript");
    string jsCode = $@"
    window.QuasarGodotBridge = 'No data received from Quasar';
    window.addEventListener(""message"", (event) => {{
      window.QuasarGodotBridge = event.data
    }});";
    js.Call("eval", jsCode, true);
  }

  public override void _Process(float delta)
  {
    var value = JavaScript.Eval("QuasarGodotBridge");
    this.Text = (string)value;
  }
}
