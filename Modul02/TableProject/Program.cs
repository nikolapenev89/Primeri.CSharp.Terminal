﻿using System;

namespace TableProject
{
	class MainClass
	{
		enum ti {ime=0, familia, godini};

		public static void Main (string[] args)
		{



		    //Дефиниране на таблица

			string[,] table = new string[2, 3];

			//Въвеждане на първи ред

			table [0, (int) ti.ime] = "Никола"; table [0, (int) ti.familia] = "Пенев"; table [0, (int) ti.godini] = "26";

			//Въвеждане на втори ред

			table [1, (int) ti.ime] = "Вероника"; table [1, (int) ti.familia] = "Ханджиева"; table [1, (int) ti.godini] = "22";

			//Печат

			Console.Write ("Кой ред искате да видите?");

			int _index = Convert.ToInt32 (Console.ReadLine ())-1;

			Console.WriteLine(
			(table[_index, (int) ti.ime])[0]+". " + 
			table[_index, (int) ti.familia] + ", " + 
			table[_index, (int) ti.godini]+" г."
			);

				
		}
	}
}
/*

		    string[] row = new string[3];
		
	

			row [0] = "Ред 1";
			row [1] = "Ред 2";
			row [2] = "Ред 3";

			Console.WriteLine ("Масив row: " + row[0] + ", "+ row[1] + ", "+ row[1] + "\n");

			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
			Console.WriteLine ("Големината на масива \n " + "1, 2, 3, 4, 5 ,6, 7, 8, 9\n\ne: " + parse.Length);

			string list1 = string.Join (";", parse + "\n\n");
			Console.WriteLine ("Новият стринг е:\n" + list1);

            */