
public class Person
{
	public string Name { get; }
	public int Phone { get; set; }

	public Person(string name, int phone)
	{
		Name = name;
		Phone = phone;
	}

	public override string ToString()
	{
		return $"{Name} ({Phone})";
	}
}
