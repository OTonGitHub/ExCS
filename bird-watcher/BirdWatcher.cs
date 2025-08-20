class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var count in birdsPerDay)
        {
            if (count == 0)
                return true;
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var count = 0;

        for (var i = 0; i < numberOfDays; i++)
        {
            count += birdsPerDay[i];
        }

        return count;
    }

    public int BusyDays()
    {
        var countBusyDays = 0;

        foreach (var count in birdsPerDay)
        {
            if (count >= 5)
                countBusyDays++;
        }

        return countBusyDays;
    }
}