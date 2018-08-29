using System;

namespace work
{
	class Program
	{
		public static void Main(string[] args)
		{
			Program p = new Program();
			p.start();
		}
		public void start(){
			Console.WriteLine("Done by TodyTodz \n This program can help you to check homework \n Choose number of the task: \n 1 2 3 4 5 6 \n");
			string bufstring = Console.ReadLine();
			int task;
			if(Int32.TryParse(bufstring, out task))
			switch(task){
					case 1 : first(); break;
					case 2 : second(); break;
					case 3 : third(); break;
					case 4 : fourth(); break;
					case 5 : fifth(); break;
					case 6 : sixth(); break;
					default : break;
			}
			else Environment.Exit(0);
		} 
		public void first(){
			Console.Clear();
			string bot="Bot";
			char s = 's';
			double i = 15.6;
			bool b = true;
			int z=6;
			Console.WriteLine("My name is {0} \n I am i{1} an a program \n My age is {2} \n There is 6 tasks \n 6+{2} = {4} \n I am too lazy ({3})", bot, s, i, b, i+z);
			Console.ReadKey();
			Console.Clear();
			start();
		}
		public void second(){
			Console.Clear();
			Console.WriteLine("Task 2. Input your number:");
			int num, i=0, k;
			string buf=Console.ReadLine();
			if(Int32.TryParse(buf, out num)){
				Console.WriteLine(num + "   "+ Convert.ToString(num, 2));
				k=num;
				for(i=0;i<3;i++)Console.WriteLine((k=k<<1) + "   "+ Convert.ToString(k<<1, 2) +"\t Сдвиг влево на 1");
				k=2;
				Console.WriteLine((num&k) + "   "+ Convert.ToString(num&k, 2) +"\t  Логическое умножение с двойкой, где 2 = " + Convert.ToString(k, 2));
				k=8;
				Console.WriteLine((num|k) + "   "+ Convert.ToString(num|k, 2) +"\t  Логическое сложение с восьмеркой, где 8 = " + Convert.ToString(k, 2));
				k=1;
				while(num!=0){
					Console.WriteLine((num=num>>k) + "   "+ Convert.ToString(num, 2) +"\t Сдвиг вправо на 1");
				}
			}
			else Environment.Exit(0);
			Console.ReadKey();
			Console.Clear();
			start();
		}
		public void third(){
			Console.WriteLine("Введите число - кол-во ступеней в башне:");
			string buf=Console.ReadLine();
			int num, i;
			if(Int32.TryParse(buf, out num)){
				buf="";
				int[] mass = new int[num];
				 for(i=0; i<num; i++){
					Console.WriteLine(buf=buf+"* ");
					mass[i]=i;
				}
				buf="";
				Console.WriteLine();
				 foreach(int localper in mass)
					Console.WriteLine(buf=buf+"* ");
				
				buf="";
				i=0;
				Console.WriteLine();
				 while (i<num){
					Console.WriteLine(buf=buf+"* ");
					++i;
				}
				buf="";
				i=0;
				Console.WriteLine();
				 do {
					Console.WriteLine(buf=buf+"* ");
					++i;
				} while (i<num);
			}
			else Environment.Exit(0);
			Console.ReadKey();
			}
		public void fourth(){
			Console.WriteLine("Введите число - кол-во ступеней в башне:");
			string buf=Console.ReadLine();
			Console.WriteLine("Введите число - номер символа, из которого будет состоять башня: \n 1 - + \n 2 - # \n 3 - * \n 4 - @");
			string buf2=Console.ReadLine();
			int num, i;
			if(Int32.TryParse(buf, out num) && Int32.TryParse(buf2, out i)){
				char o=' ';
				switch(i){
					case 1 : o='+'; break;
					case 2 : o='#'; break;
					case 3 : o='*'; break;
					case 4 : o='@'; break;
					default: Environment.Exit(0); break;
				}
				
				buf="";
				int[] mass = new int[num];
				 for(i=0; i<num; i++){
					Console.WriteLine(buf=buf+o+" ");
					mass[i]=i;
				}
				buf="";
				Console.WriteLine();
				 foreach(int localper in mass)
					Console.WriteLine(buf=buf+o+" ");
				
				buf="";
				i=0;
				Console.WriteLine();
				 while (i<num){
					Console.WriteLine(buf=buf+o+" ");
					++i;
				}
				buf="";
				i=0;
				Console.WriteLine();
				 do {
					Console.WriteLine(buf=buf+o+" ");
					++i;
				} while (i<num);
			}
			else Environment.Exit(0);
			Console.ReadKey();
		}
		public void fifth(){
			Console.WriteLine("Введите число - кол-во ступеней в башне:");
			string buf=Console.ReadLine();
			Console.WriteLine("Введите симол, из которого будут состоять пирамиды:");
			char o = Console.ReadKey().KeyChar;
			Console.WriteLine("\n");
			int num, i;
			if(Int32.TryParse(buf, out num)){
				buf="";
				int[] mass = new int[num];
				 for(i=0; i<num; i++){
					Console.WriteLine(buf=buf+o+" ");
					mass[i]=i;
				}
				buf="";
				Console.WriteLine();
				 foreach(int localper in mass)
					Console.WriteLine(buf=buf+o+" ");
				
				buf="";
				i=0;
				Console.WriteLine();
				 while (i<num){
					Console.WriteLine(buf=buf+o+" ");
					++i;
				}
				buf="";
				i=0;
				Console.WriteLine();
				 do {
					Console.WriteLine(buf=buf+o+" ");
					++i;
				} while (i<num);
			}
			else Environment.Exit(0);
			Console.ReadKey();
		}
		public void sixth(){
			int i;
			Console.WriteLine("Введите число - кол-во ступеней в башне:");
			string buf=Console.ReadLine();
			if(Int32.TryParse(buf, out i)){
				switch(i){
					case 0 : Console.WriteLine(0); break;
					case 1 : Console.WriteLine(1); break;
					case 2 : Console.WriteLine(2); break;
					case 3 : Console.WriteLine(6); break;
					case 4 : Console.WriteLine(24); break;
					case 5 : Console.WriteLine(120); break;
					case 6 : Console.WriteLine(720); break;
					case 7 : Console.WriteLine(5040); break;
					case 8 : Console.WriteLine(40320); break;
					case 9 : Console.WriteLine(362880); break;
					case 10 : Console.WriteLine(3628800); break;
					default: Environment.Exit(0);
				}
			}
			else Environment.Exit(0);
			Console.ReadKey();
		}
	}
}