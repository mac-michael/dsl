# dsl
Project demonstrating Domain Specific Language for credibility calculation, case study project (strategy and rule design patterns) and simple math language.

# DSL Samples
Project demonstrating Domain Specific Language for credibility calculation.

You can find 2 more sample projects in the solution:
- CredibilityCalculator - case study project demonstrating strategy and rule design patterns
- SimpleDSL - dsl for simple math calculations
For more details you can find my blog here: http://blog.macmichal.pl
There's an article on the subject I'm making in progess. I'll post info when it's available.

```csharp
var form = new ClientQuenstionForm()
    {
        MonthlyIncome = 5000,
        MonthlyCarCosts = 500,
        MonthlyLivingCosts = 1500,
        PeopleSupported = 2,

        IsMan = true,
        ShareValue = 50000,
        IsITStuff = true,
    };

//form.GetInputData();

// Create policy and initialize it with rules
ICredibilityPolicy policy = new DSLCredibilityPolicy(
    "+ dochod * maxOkresKredytowania", // income * max credit length
    "- kosztSamochodu * maxOkresKredytowania", // car cost per month * max credit length
    "Jesli mezczyzna to * 0.75", // if man 
    "Jesli informatyk to * 1.1", // if IT stuff
    "Jesli polityk to * 0.8", // If politician
    "+ akcje * 0.4" // shares
);

Money money = policy.Calculate(form);
Console.WriteLine("Your credibility is: " + money);
```