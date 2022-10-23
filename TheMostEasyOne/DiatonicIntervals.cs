namespace TheMostEasyOne; 

public class DiatonicIntervals {
    private static readonly List<Interval> Table = new List<Interval>(14);

    public DiatonicIntervals() {
        Table.Insert(0, new Interval("Perfect Prime", 1, 0));
        Table.Insert(1, new Interval("Minor Second", 2, 1));
        Table.Insert(2, new Interval("Major Second", 2, 2));
        Table.Insert(3, new Interval("Minor Third", 3, 3));
        Table.Insert(4, new Interval("Major Third", 3, 4));
        Table.Insert(5, new Interval("Perfect Fourth", 4, 5));
        Table.Insert(6, new Interval("Augmented Fourth", 4, 6));
        Table.Insert(7, new Interval("Diminished Fifth", 5, 6));
        Table.Insert(8, new Interval("Perfect Fifth", 5, 7));
        Table.Insert(9, new Interval("Minor Sixth", 6, 8));
        Table.Insert(10, new Interval("Major Sixth", 6, 9));
        Table.Insert(11, new Interval("Minor Seventh", 7, 10));
        Table.Insert(12, new Interval("Major Seventh", 7, 11));
        Table.Insert(13, new Interval("Perfect Octave", 8, 12));
    }

    public static Interval CreateInterval() {
        var rnd = new Random();
        return Table[rnd.Next(14)];
    }
}
