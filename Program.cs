//Miles Per Gallon Calculator
//Name: Webster B
//Date: 1/28/25

        // Declare variables to store miles driven and gallons used.
        double milesDriven, gallonsUsed, mpg;

        // Prompt user to enter the number of miles driven.
        Console.WriteLine("Please enter the number of miles driven:");
        milesDriven = Convert.ToDouble(Console.ReadLine());

        // Prompt user to enter the amount of gasoline used in gallons.
        Console.WriteLine("Please enter the amount of gasoline used (in gallons):");
        gallonsUsed = Convert.ToDouble(Console.ReadLine());

        // Calculate the MPG using the provided formula.
        mpg = milesDriven / gallonsUsed;

        // Display the calculated MPG.
        Console.WriteLine("You achieved {0} miles per gallon.", mpg);