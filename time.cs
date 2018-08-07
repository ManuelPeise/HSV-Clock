using System;

public class Class1
{
    int years = 0;
    int firstYear = 1887;
    DateTime firstday = new DateTime(2017, 9, 29);
    int days =0 ;

	public Class1()
	{
	}

    public int Year()
    {
        years = DateTime.Now.Year - firstYear;

        return years;

    }

    public int days()
    {
        TimeSpan sp = DateTime.Now - firstday;

        days = sp;

        return days;
    }


}
