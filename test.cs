	public void Kombinace(string text,char[] zbylapismena)
	{
		for(int i = 0;i< zbylapismena.lenght;i++)
		{
			if(JeTenhleStringSlovo(text+zbylapismena[i])) Console.Write(text+zbylapismena[i]); //vyzkou�en� jestli tenhle string je nejaky slovo
			Kombinace(text+zbylapismena[i],VratPoleBezIndexu(zbylapismena,i)); //rekurzivn� vol�n�
		}
	}
    
	//zkou�� jestli je to nejak� slovo<br>
	public boolean JeTehleStringSlovo(string text)<br>
	{
	}

	//vr�t� pole bez dan�ho indexu<br>
	public char[] VratPoleBezIndexu(char[] pole,int index)<br>
	{
		return pole;
	}