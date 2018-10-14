# ArgValidation
[![Build status](https://travis-ci.org/mnkvsoft/ArgValidation.svg?branch=master)](https://travis-ci.org/mnkvsoft/ArgValidation)
[![codecov](https://codecov.io/gh/mnkvsoft/ArgValidation/branch/master/graph/badge.svg)](https://codecov.io/gh/mnkvsoft/ArgValidation)

A simply arguments validation library with fluent API

## Description

When writing business logic classes, it is almost always necessary to check the values of the constructor arguments for correctness and to generate exceptions if the parameters are incorrect. It is necessary to write informative messages. It is tiring. The library is designed to facilitate this routine work.

## Example

### Native validation

```cs
 // constructor
 public Car(CarModel model, string color, int releaseYear, DateTime dateOfPurchase)
 {
     if(model == null)
         throw new ArgumentNullException(nameof(model));
            
     if(dateOfPurchase == default)
         throw new ArgumentException($"Argument '{nameof(dateOfPurchase)}' must be not default value");
            
     if(releaseYear < 1)
         throw new ArgumentException($"Argument '{nameof(releaseYear)}' must be more than 0. Current value: '{releaseYear}'");
                
     if(string.IsNullOrWhiteSpace(color))
         throw new ArgumentException($"Argument '{nameof(color)}' cannot be empty or whitespace. Current value: {color}");
            
     if(color.Length > 20)
         throw new ArgumentException($"Argument '{nameof(color)}' must be length less or equals than 20. Current length: {color.Length}");
     //...       
  }   
     
```

### ArgValidation, first way (recommended)

```cs
 // constructor
 public Car(CarModel model, string color, int releaseYear, DateTime dateOfPurchase)
 {
     Arg.NotNull(model, nameof(model));
     Arg.NotDefault(dateOfPurchase, nameof(dateOfPurchase));
     Arg.Positive(releaseYear, nameof(releaseYear));
            
     Arg.Validate(color, nameof(color))
           .NotNullOrWhitespace()
           .LengthLessOrEqualThan(20);
     //...       
  }   
     
```

### ArgValidation, second way (slow, only for non-speed-critical projects)

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
     //...       
  }   
     
```
## Used technologies

- Language: C# 7.0
- Target framefork: .NET Standard 2.0
