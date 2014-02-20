	
	public void Main()
	{
		char[] pismenka = new char[] { A,B,C,G,Ø};
		Kombinace("",pismenka);
	}
	
	public void Kombinace(string text,char[] zbylapismena)
	{
		for(int i = 0;i< zbylapismena.lenght;i++)
		{
			if(JeTenhleStringSlovo(text+zbylapismena[i])) Console.Write(text+zbylapismena[i]); //vyzkoušení jestli tenhle string je nejaky slovo
			Kombinace(text+zbylapismena[i],VratPoleBezIndexu(zbylapismena,i)); //rekurzivní volání
		}
	}
    
	
	String[] ceskaSlova; //pole s èeskými slovy
	
	//zkouší jestli je to nejaké slovo
	public boolean JeTehleStringSlovo(string text)
	{
		for(int i = 0;i< ceskaSlova.Lenght;i++)
		{
			if(ceskaSlova[i] == text) return true; //když se schoduje s nìjakým slovem vrací true
		}
		return false; //pokud se s žádným neschoduje vrací false
	}

	//vrátí pole bez daného indexu
	public char[] VratPoleBezIndexu(char[] pole,int index)
	{
		char[] vysledek = new char[pole.lenght-1]; //vytvoøí pole o 1 menší nez predchozí
		int j = 0;
		for(int i = 0;i< pole.lenght;i++)
		{
			if(i != index) {
				vysledek[j] = pole[i];
				j++;
			}			
		}
		return vysledek;
	}