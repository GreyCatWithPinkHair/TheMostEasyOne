namespace TheMostEasyOne; 

public static class Scale {
    private static readonly char[] OctavePitches = new char[] {'C', 'D', 'E', 'F', 'G', 'A', 'B'};
    
    public static PitchClass CreatePitch() {
        var rnd = new Random();
        var name = OctavePitches[rnd.Next(7)];
        bool sharp = false, flat = false;
        var temp = rnd.Next();
        switch (temp % 3) {
            case 0:
                sharp = true; break;
            case 1:
                flat = true; break;
        }

        var pitch = new PitchClass(name, sharp, flat);
        return pitch;
    }
}
