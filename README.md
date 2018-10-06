# ArgValidation
[![Build status](https://travis-ci.org/mnkvsoft/ArgValidation.svg?branch=master)](https://travis-ci.org/mnkvsoft/ArgValidation)

A simply arguments validation library

# Code example

```cs
// constructor
public Car(CarModel model, string color, int releaseYear, DateTime dateOfPurchase)
{
    Arg.NotNull(() => model);
    Arg.NotDefault(() => dateOfPurchase);
    Arg.Positive(() => releaseYear);
                
    Arg.Validate(() => color)
         .NotNullOrWhitespace()
         .LengthLessOrEqualThan(20);
    ...
```
