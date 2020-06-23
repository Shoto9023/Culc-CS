using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culculator
{
	class Program
	{
		static void Main(string[] args)
		{
			//起動処理
			Console.WriteLine("単純四則計算器");
			Console.Write("起動処理中です");
			System.Threading.Thread.Sleep(500);
			Console.Write(" .");
			System.Threading.Thread.Sleep(500);
			Console.Write(" .");
			System.Threading.Thread.Sleep(500);
			Console.Write(" .");
			System.Threading.Thread.Sleep(500);
			Console.Clear();
			
			//Hello
			Console.WriteLine("こちらは単純四則計算機です");
			Console.WriteLine("計算式は(x)(s)(y)です");
			HELLO: //計算開始ジャンプ

			//変数xを定義
			Console.WriteLine(" ");
			Console.WriteLine("変数xを受け付けます");
			Console.WriteLine("整数を入力してください…");

			int x, y;
			inputx:
			try
			{
				x = int.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("正しく指定してください");
				goto inputx;
			}
			Console.WriteLine("変数xを" + x + "に定義しました");
			Console.WriteLine(" ");

			//計算記号を定義
			JUMP: //算術エラージャンプ
			Console.WriteLine("演算時に使う算術記号sを定義します");
			Console.WriteLine("使える算術記号は次のとおりです");
			Console.WriteLine("加:A(Addition) | 減:S(Subtraction) | 乗:M(Multiplicative) | 除:D(Division)");
			string s = Console.ReadLine();
			
			if ( s == "A" ){
				Console.WriteLine("計算方法を加法に定義しました");
				Console.WriteLine(" ");
			}
			else if ( s == "S" ){
				Console.WriteLine("計算方法を減法に定義しました");
				Console.WriteLine(" ");
			}
			else if ( s == "M" ){
				Console.WriteLine("計算方法を乗法に定義しました");
				Console.WriteLine(" ");
			}
			else if ( s == "D" ){
				Console.WriteLine("計算方法を除法に定義しました");
				Console.WriteLine(" ");
			}
			else{
				Console.WriteLine("計算方法を定義できません");
				goto JUMP;
			}

			//変数yを定義
			Console.WriteLine("変数yを受け付けます");
			Console.WriteLine("整数を入力してください…");

			inputy:
			try
			{
				y = int.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("正しく指定してください");
				goto inputy;
			}
			Console.WriteLine("変数yを" + y + "に定義しました");
			Console.WriteLine("");

			//計算
			if ( s == "A" ){
				Console.WriteLine("指定された変数に基づく計算式は(" + x + ")+(" + y + ")となりました");
				int z;
				 z = x + y ;
				 Console.WriteLine("");
				Console.WriteLine("計算結果は" + z + "です");
				 Console.WriteLine("");
			}
			else if ( s == "S" ){
				Console.WriteLine("指定された変数に基づく計算式は(" + x + ")-(" + y + ")となりました");
				int z;
				z = x - y ;
				Console.WriteLine("");
				Console.WriteLine("計算結果は" + z + "です");
				Console.WriteLine("");
			}
			else if ( s == "M" ){
				Console.WriteLine("指定された変数に基づく計算式は(" + x + ")*(" + y + ")となりました");
				int z;
				z = x * y ;
				Console.WriteLine("");
				Console.WriteLine("計算結果は" + z + "です");
				Console.WriteLine("");
			}
			else if ( s == "D" ){
				Console.WriteLine("指定された変数に基づく計算式は(" + x + ")/(" + y + ")となりました");
				double z = 1.0 * x / y ;
				Console.WriteLine("");
				Console.WriteLine("計算結果は" + z + "です");
				Console.WriteLine("");
			}

			//再計算の確認
			YORN: //確認ジャンプ
			Console.WriteLine("再度計算を行いますか？　[Y/N]");
			string h = Console.ReadLine();
			if ( h == "Y" )
			{
				Console.Write("再計算に移行します");
				System.Threading.Thread.Sleep(500);
				Console.Write(" .");
				System.Threading.Thread.Sleep(500);
				Console.Write(" .");
				System.Threading.Thread.Sleep(500);
				Console.Write(" .");
				System.Threading.Thread.Sleep(500);
				Console.Clear();
				goto HELLO;
			}
			else if ( h == "N" )
				Console.WriteLine("機能を終了します");
			else{
				Console.WriteLine("受け付けられません");
				goto YORN;
			}
		}
	}
}