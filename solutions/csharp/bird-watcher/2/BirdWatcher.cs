class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Any(i=>i==0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        return birdsPerDay[0..Math.Min(numberOfDays,birdsPerDay.Length)].Sum();
    }

    public int BusyDays()
    {
        return birdsPerDay.Count(i=>i>=5);
    }
}
