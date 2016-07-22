using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaoApp_WinForm
{
	public partial class Form_Main : Form
	{
		public Form_Main()
		{
			InitializeComponent();
		}

		private void Form_Main_Load(object sender, EventArgs e)
		{
			this.richTextBox_script.Text = @"#demo code:
def add(a,b):
    return int(a)+int(b)";
			this.textBox_function.Text = "add";
			this.textBox_param.Text = "1,1";
		}

		private void button_run_Click(object sender, EventArgs e)
		{
			string script = this.richTextBox_script.Text.Trim();
			string function = this.textBox_function.Text.Trim();
			string param = this.textBox_param.Text.Trim();

			//dynamic result = RunPy2(script, function,param);
			dynamic result = RunPy3(script, function, param);
			this.richTextBox_result.Text = result.ToString();
		}

		private void RunPy1()
		{
			ScriptRuntime pyRuntime = Python.CreateRuntime();
			dynamic py = pyRuntime.UseFile(@"python\hello.py");
			dynamic result = py.welcome("wowo");
		}

		private dynamic RunPy2(string script, string funname, string param)
		{
			var engine = Python.CreateEngine();
			var scope = engine.CreateScope();
			var source = engine.CreateScriptSourceFromString(script);
			source.Execute(scope);
			var wel = scope.GetVariable(funname);
			//var t = wel.GetType();
			//var method = wel as IronPython.Runtime.PythonFunction;
			//var args = wel.ArgNames;
			var args = wel.__code__.co_varnames;
			var acount = args.Count;
			var afirst = args[0];
			dynamic result = wel(" wowo ");
			return result;
		}

		private dynamic RunPy3(string script, string funname, string param)
		{
			var engine = Python.CreateEngine();
			var devent = new DynamicEvent(engine);
			var scope = engine.CreateScope();
			var source = engine.CreateScriptSourceFromString(script);
			source.Execute(scope);
			var wel = scope.GetVariable(funname);
			devent.addHandler(wel);
			object[] ps = param.Split(',');
			devent.invoke(ps);
			return devent.result;
		}

		private void button_clear_Click(object sender, EventArgs e)
		{
			this.textBox_function.Text = string.Empty;
			this.textBox_param.Text = string.Empty;
			this.richTextBox_result.Text = string.Empty;
			this.richTextBox_script.Text = "#type script here:\n";
		}
	}


	public class DynamicEvent
	{
		private Dictionary<int, Action<object[]>> delegates = new Dictionary<int, Action<object[]>>();
		public ScriptEngine Engine { get; set; }
		public dynamic result;


		public DynamicEvent(ScriptEngine engine)
		{
			Engine = engine;
		}

		public void addHandler(PythonFunction pythonFunction)
		{
			int args = (int)pythonFunction.func_code.co_nlocals;
			//delegates.Add(args, a => Engine.Operations.Invoke(pythonFunction, a));
			delegates.Add(args, delegate (object[] a)
				{
					try
					{
						result = Engine.Operations.Invoke(pythonFunction, a);
					}
					catch (Exception ex)
					{
						result = "error:"+ ex.Message;
					}
				});
		}

		public void addHandler(Delegate d)
		{
			int args = d.Method.GetParameters().Length;
			delegates.Add(args, a => d.DynamicInvoke(a));
		}

		public void invoke(params object[] args)
		{
			Action<object[]> action;
			if (!delegates.TryGetValue(args.Length, out action))
				throw new ArgumentException("There is no handler that takes " + args.Length + " arguments!");

			action(args);
		}
	}
}
