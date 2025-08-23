class Lasagna
{
    /*
        if minutes per layer change based on the type of lasagna,
        then change from const to a readonly (not static readonly).

        - const → compile-time constant, baked into IL, same for all instances.
        - readonly → runtime constant, can vary per instance (set in constructor).
        - static readonly → runtime constant, one value shared by entire class.
    */
    private const short MinutesPerLayer = 2;

    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(short time)
    {
        return ExpectedMinutesInOven() - time;
    }

    public int PreparationTimeInMinutes(short layers)
    {
        return layers * MinutesPerLayer;
    }

    public int ElapsedTimeInMinutes(short layers, short minutesInOven)
    {
        return minutesInOven + layers * MinutesPerLayer;
    }
}