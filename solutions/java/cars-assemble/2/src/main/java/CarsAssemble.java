public class CarsAssemble {

    public double productionRatePerHour(int speed) {
        double successRate = switch(speed){
            case int n when n >=1 && n <= 4 -> 1.0;
            case int n when n >=5 && n <= 8 -> 0.9;
            case 9 -> 0.8;
            case 10 -> 0,77;
            case _ -> 0.0;
        };
        return successRate*221;
    }
    public int workingItemsPerMinute(int speed) {
        return productionRatePerHour(speed) / 60;
    }
}
