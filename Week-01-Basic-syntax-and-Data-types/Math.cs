public record class Person
{
    public string name;
    public int age;

    public Person(string n, int a)
    {
        name = n;
        age = a;
    }

    public void CelebrateBirthday()
    {
        age++;
    }
}