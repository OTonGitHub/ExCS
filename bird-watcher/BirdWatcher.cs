namespace BirdWatcher;

class BirdCount(int[] birdsPerDay)
{
    private readonly int[] birdsPerDay = birdsPerDay;

    public static int[] LastWeek()
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

        if (numberOfDays <= 0)
            return count;

        if (numberOfDays > birdsPerDay.Length)
            numberOfDays = birdsPerDay.Length;

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