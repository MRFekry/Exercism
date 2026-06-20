class Lasagna
{
    // define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
    
    // define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actualMinutes) => ExpectedMinutesInOven() - actualMinutes;

    // define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers) => 2 * numberOfLayers;

    // define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int cookingMinutes) => PreparationTimeInMinutes(numberOfLayers) + cookingMinutes;
}
