using System;
using System.Collections.Generic;

namespace QuickCSharp
{
	public delegate void NameChangedDelegate(string name);

	public class QClass : QInterface, ICloneable
	{

		private string _name;
		private float _height;
		public event NameChangedDelegate OnNameChanged;
		private Dictionary<string, object> _aDict = new Dictionary<string, object>();
		private List<object> _aList = new List<object> ();

		public string Name {
			get {
				return _name;
			}

			set {
				_name = value;
				if (OnNameChanged!=null) {
					OnNameChanged (_name);
				}
			}
		}

		public float Height {
			get {
				return _height;
			}
		}

		public QClass ()
		{

		}

		public int doSomeThing(float f) 
		{
			Console.WriteLine("doSomeThing");
			return 0;
		}

		public void TestDictionary() {
			_aDict.Add ("key", "");
			if (_aDict.ContainsKey ("key")) {
				Console.WriteLine ("Contains key!");
			}
		}

		[Obsolete ("This function is obsolete")]
		public void TestObsolete() {
			Console.WriteLine ("This is an obsolete");
		}

		public object Clone() {
			return this.MemberwiseClone ();
		}
	}
}

