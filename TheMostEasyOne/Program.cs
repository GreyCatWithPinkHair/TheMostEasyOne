using TheMostEasyOne;

var obj = new DiatonicIntervals();

while (true) {
    var pitch = Scale.CreatePitch();
    var interval = DiatonicIntervals.CreateInterval();
    var octave = new[] {'C', 'D', 'E', 'F', 'G', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'A', 'B'};
    
    
    byte pitchName = 0;
    for (byte i = 0; i < 7; i++) {
        if (pitch.GetName() == octave[i]) {
            pitchName = i;
            break;
        }
    }
    
    
    var secondPitchName = pitchName;
    short halfsteps = 0;
    var octaveSign = false;
    bool sharp = false, flat = false;
    
    if (interval.GetHalfsteps() != 0 && interval.GetHalfsteps() != 12) {
        for (byte i = 1; i < interval.GetPitches(); i++) {
            if (octave[secondPitchName] == 'E' || octave[secondPitchName] == 'B') {
                halfsteps++;
                secondPitchName++;
            }
            else {
                halfsteps += 2;
                secondPitchName++;
            }
        }
        
        
        var dh = interval.GetHalfsteps() - halfsteps;
        if (!pitch.GetAug() && !pitch.GetDim()) {
            if (dh == -1) flat = true;
            else if (dh == 1) sharp = true;
        }
        else if (pitch.GetAug()) {
            if (dh == 0) sharp = true;
            else if (dh == 1) {
                pitch.SetAug(false);
                pitch.SetDim(true);
            }
        }
        else {
            if (dh == -1) {
                pitch.SetDim(false);
                pitch.SetAug(true);
            }
            else if (dh == 0) flat = true;
        
        }
    }
    
    else if (interval.GetHalfsteps() == 12) {
        octaveSign = true;
        if (pitch.GetAug()) sharp = true;
        else if (pitch.GetDim()) flat = true;
    }
    
    else {
        if (pitch.GetAug()) sharp = true;
        else if (pitch.GetDim()) flat = true;
    }
    
    
    Console.WriteLine("Name the interval:");
    pitch.Print();
    Console.Write($" - {octave[secondPitchName]}");
    if (sharp) Console.Write("#");
    else if (flat) Console.Write("b");
    if (octaveSign) Console.WriteLine("1");
    else Console.WriteLine();
    
    var answer = Console.ReadLine();
    while (!string.Equals(answer, interval.GetTitle())) {
        Console.WriteLine("Wrong, try again");
        answer = Console.ReadLine();
    }
    
    Console.Write("Right! This is ");
    interval.Print();
    Console.WriteLine("Type \"NEW\" for a new exercise");
    var wish = Console.ReadLine();
    if (wish != "NEW") break;
}
