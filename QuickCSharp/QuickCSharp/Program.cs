using System;

namespace QuickCSharp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			QClass q = new QClass ();
			q.OnNameChanged += new NameChangedDelegate (OnNameChanged);
			q.Name = "123";

		}

		public static void OnNameChanged(string name) 
		{
			Console.WriteLine ("Name Changed:{0}", name);
		}
	}
}
