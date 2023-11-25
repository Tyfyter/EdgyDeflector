using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Input;

namespace EdgyDeflector {
	class Program {
		static void Main(string[] args) {
			string str = args[1].Replace("microsoft-edge:?url=", "");
			if (str != args[1]) Process.Start(Uri.UnescapeDataString(str));
		}
	}
}
