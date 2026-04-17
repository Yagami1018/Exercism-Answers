public class Lasagna {
private static final int Expected_Time_In_Minutes = 40;
private static final int Preparation_Time_For_Layers = 2;
    
public int expectedMinutesInOven() {
    return Expected_Time_In_Minutes;
}
    
public int remainingMinutesInOven(int actualMinutes) {
    return expectedMinutesInOven()-actualMinutes;
}
    
public int preparationTimeInMinutes(int layers) {
    return layers*Preparation_Time_For_Layers;
}
    
public int totalTimeInMinutes(int layers, int actualMinutes) {
    return preparationTimeInMinutes(layers)+actualMinutes;
}
}
    