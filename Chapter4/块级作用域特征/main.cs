using System;

class Program {
	/*
	static void Main1( string[] args ) {

		// 写代码的地方
		Console.WriteLine( num );  // 变量只有在定义后才可以使用, 而 js 只需要保证有声明
								   // 在预解析的时候, 就声明好了, 代码中处处可用.

		var num = 123; // C# 强类型的, 所以 可以使用 int num = 123;




		Console.ReadKey();
	}
	*/

	static void Main( string[] args ) {

		// 写代码的地方
		{
			var num = 123; // 变量定义在块中
			{


				Console.WriteLine( num );  
			}
			Console.WriteLine( num );  
		}

		// Console.WriteLine( num );  


		Console.ReadKey();
	}
}