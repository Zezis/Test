	
	public void Main()
	{
		char[] pismenka = new char[] { A,B,C,G,�};
		Kombinace("",pismenka);
	}
	
	public void Kombinace(string text,char[] zbylapismena)
	{
		for(int i = 0;i< zbylapismena.lenght;i++)
		{
			if(JeTenhleStringSlovo(text+zbylapismena[i])) Console.Write(text+zbylapismena[i]); //vyzkou�en� jestli tenhle string je nejaky slovo
			Kombinace(text+zbylapismena[i],VratPoleBezIndexu(zbylapismena,i)); //rekurzivn� vol�n�
		}
	}
    
	
	String[] ceskaSlova; //pole s �esk�mi slovy
	
	//zkou�� jestli je to nejak� slovo
	public boolean JeTehleStringSlovo(string text)
	{
		for(int i = 0;i< ceskaSlova.Lenght;i++)
		{
			if(ceskaSlova[i] == text) return true; //kdy� se schoduje s n�jak�m slovem vrac� true
		}
		return false; //pokud se s ��dn�m neschoduje vrac� false
	}

	//vr�t� pole bez dan�ho indexu
	public char[] VratPoleBezIndexu(char[] pole,int index)
	{
		char[] vysledek = new char[pole.lenght-1]; //vytvo�� pole o 1 men�� nez predchoz�
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