using System;

public interface IName 
{
	public string GetName();
	public string GetNamber();
}
public class Person:IName
{
	public string GetName()
	{
		return "Person";
	}
    public string GetNamber()
    {
        return "0555555555";
    }
}
public class Student : Person,IName
{
	public string  GetNamber()
	{
		return  "0555555555";
	}
}
