// ecample of COnstructor and object

using System;
					
public class Program
{
	public class RohitGf
	{
	public string name ="";
	public string hometown ="";
	public int age;
		
		static string HeroName = "Rohit Maharjan";
		
		/*public RohitGf (string gfname, string gfhometown, int gfage)   // Constructor
		{
			name = gfname;
			hometown = gfhometown;
			age = gfage;
		}*/
		
		/* public int addRohitImaginaryGf()							// method not needed at all
		{
			
		}*/
	}
	
	
	
	public static void Main()
	{
		//RohitGf sonam = new RohitGf("Sonam Kunwar","Nepaljung",22);   // constuctor
		
		RohitGf kali = new RohitGf();									// normal object
		kali.name = "kali kunwar";
		kali.hometown = "ktm";
		kali.age = 20;
		
		Console.WriteLine(kali.name + " " + kali.hometown + " " + kali.age);
		
		//Console.WriteLine(sonam.name+ " "+ sonam.hometown+" "+ sonam.age);
		
		
	}
}

//  ------------- Using Method --------------
using System;	
					
public class Program
{
	public class RohitGf
	{
	public string name ="";	
	public string hometown ="";
	public int age;
		
		static string HeroName = "Rohit Maharjan";
		
		/*public RohitGf (string gfname, string gfhometown, int gfage)
		{
			name = gfname;
			hometown = gfhometown;
			age = gfage;
		}*/
		
		 public void addRohitImaginaryGf(string gfname, string gfhometown, int gfage)
		{
			name = gfname;
			hometown = gfhometown;
			age = gfage;
		}
	}
	
	
	
	public static void Main()
	{
		//RohitGf sonam = new RohitGf("Sonam Kunwar","Nepaljung",22);
		
		RohitGf nanu = new RohitGf();
		nanu.addRohitImaginaryGf("nanu kunwar","mumbai",18);
		
		/*
		RohitGf kali = new RohitGf();
		kali.name = "kali kunwar";
		kali.hometown = "ktm";
		kali.age = 20;
		*/
		
		//Console.WriteLine(kali.name + " " + kali.hometown + " " + kali.age);
		
		//Console.WriteLine(sonam.name+ " "+ sonam.hometown+" "+ sonam.age);
		
		Console.WriteLine(nanu.name + " " + nanu.hometown + " " + nanu.age);
	}
}



//         ------------ menthod Functiom overloading ----------
using System;
					
public class Program
{
	public class RohitGf
	{
	public string name ="";
	public string hometown ="";
	public int age;
		
		static string HeroName = "Rohit Maharjan";
		
		/*public RohitGf (string gfname, string gfhometown, int gfage)
		{
			name = gfname;
			hometown = gfhometown;
			age = gfage;
		}*/
		
		 public void addRohitImaginaryGf(string gfname, string gfhometown, int gfage)
		{
			name = gfname;
			hometown = gfhometown;
			age = gfage;
		}
		
		public void addRohitImaginaryGf(string gfname, int gfage)
		{
			name = gfname;
			age = gfage;
		}
		
	}
	
	
	
	public static void Main()
	{
		//RohitGf sonam = new RohitGf("Sonam Kunwar","Nepaljung",22);
		
		/*RohitGf nanu = new RohitGf();
		nanu.addRohitImaginaryGf("nanu kunwar","mumbai",18);*/
		
		RohitGf funOverloading = new RohitGf();
		funOverloading.addRohitImaginaryGf("function overloading kunwar",30);
		
		/*
		RohitGf kali = new RohitGf();
		kali.name = "kali kunwar";
		kali.hometown = "ktm";
		kali.age = 20;
		*/
		
		//Console.WriteLine(kali.name + " " + kali.hometown + " " + kali.age);
		
		//Console.WriteLine(sonam.name+ " "+ sonam.hometown+" "+ sonam.age);
		
		//Console.WriteLine(nanu.name + " " + nanu.hometown + " " + nanu.age);
		
		Console.WriteLine(funOverloading.name + " " + funOverloading.age);
	}
}