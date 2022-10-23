namespace TheMostEasyOne; 

public class PitchClass {
    private char Name { get; }

    private bool Augmented { get; set; }

    private bool Diminished { get; set; }

    public PitchClass(char name, bool augmented, bool diminished) {
        Name = name;
        Augmented = augmented;
        Diminished = diminished;
    }

    public char GetName() {
        return Name;
    }

    public bool GetAug() {
        return Augmented;
    }

    public bool GetDim() {
        return Diminished;
    }

    public void SetAug(bool change) {
        Augmented = change;
    }

    public void SetDim(bool change) {
        Diminished = change;
    }
    
    public void Print() {
        if (Augmented) Console.Write(Name + "#");
        else if (Diminished) Console.Write(Name + "b");
        else Console.Write(Name);
    }
}
