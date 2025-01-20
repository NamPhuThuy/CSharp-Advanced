using System.Collections;

namespace IEnumerable_and_IEnumerator;

public class HeroAcademy : IEnumerable<string>
{
    public string Name { get; set; } = "Olympus";

    private List<string> _olympians = new List<string>()
    {
        "Zeus", "Hera", "Poseidon", "Demeter", "Athena", "Apollo"
    };

    

    /*public IEnumerator GetEnumerator()
    {
        // return olympians.GetEnumerator();
    }*/
    
    
    public IEnumerator<string> GetEnumerator()
    {
        return new AcademyIEnumerator(_olympians);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class AcademyIEnumerator : IEnumerator<string>
{
    private readonly List<string> _names;
    private int _index = -1;
 
    public AcademyIEnumerator(List<string> name)
    {
        _names = name;
    }
    
    public bool MoveNext()
    {
        _index++;
        return _index < _names.Count; //is there any element in the array
    }

    public void Reset()
    {
        _index = -1;
    }
    
    //remove this to archive the disposable (because of the "object?") pattern when using the generic type of IEnumerator
    // public object? Current => _names[_index];

    public string Current => _names[_index];

    object? IEnumerator.Current => Current;

    
    public void Dispose()
    {
        
    }
    
    
}