# ArgValidation
[![Build status](https://travis-ci.org/mnkvsoft/ArgValidation.svg?branch=master)](https://travis-ci.org/mnkvsoft/ArgValidation)
[![codecov](https://codecov.io/gh/mnkvsoft/ArgValidation/branch/master/graph/badge.svg)](https://codecov.io/gh/mnkvsoft/ArgValidation)
[![NuGet](https://img.shields.io/nuget/v/ArgValidation.svg?style=flat)](https://www.nuget.org/packages/ArgValidation)

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
           .MaxLength(20);
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
            .MaxLength(20);
     //...       
  }   
     
```
## Get started

All checks begin with a reference to the static class Arg.
Then there are 2 ways:

- Call the Validate method, which provides all the possible methods for validation the argument using a fluent API.

```cs
// example

Arg.Validate (personName, nameof (personName))
     .NotNull ()
     .LengthInRange (1, 30);
```

- If you want to perform only 1 validation, without passing any additional parameters to the check method (*Simple validation method*), then you can immediately call this method directly. This path does not support a fluent API.

```cs
// example

Arg.NotNull (personRepositoty, nameof (personRepositoty));
Arg.NotDefault (birthDate, nameof (birthDate));
Arg.PositiveOrZero (passengersCount, nameof (passengersCount));
```


In the case of a failed validation, exception `ArgumentException` family is thrown.
If for some reason the verification fails, for example, a LengthInRange is checked on an argument that is null, then `InvalidOperationException` is thrown in such cases.

*Important*. The library throws exceptions to the `ArgumentException` family, only in the case of a failed validaton, in all other cases, an `InvalidOperationException` is thrown.

## Complete list of validation methods for types

Where -s is labeled *simple validation methods.*
*Simple validation method* is a validation method that does not require additional parameters for validation, except for the validated argument itself.
Methods are available directly by calling the class `Arg.`


For `Object`:

- `Default` -s
- `NotDefault` -s
- `Null` -s
- `Notnull` -s
- `Equal`
- `NotEqual`
- `OnlyValues`

For `IComparable <T>`:

- `MoreThan`
- `LessThan`
- `Max`
- `Min`
- `Inrange`

For `string`:

- `NullOrEmpty`  -s
- `NotNullOrEmpty`  -s
- `NullOrWhitespace`  -s
- `NotNullOrWhitespace`  -s
- `LengthEqual`
- `LengthMoreThan`
- `LengthLessThan`
- `MaxLength`
- `MinLength`
- `LengthInRange`
- `Contains`
- `NotContains`
- `Match`
- `Notmatch`

For `IEnumerable`:

- `CountEqual`
- `CountNotEqual`
- `CountMoreThan`
- `CountLessThan`
- `Mincount`
- `MaxCount`
- `Contains`
- `NotContains`
- `Empty` -s
- `NotEmpty` -s
- `NullOrEmpty` -s
- `NotNullOrEmpty` -s

For `int, decimal, double, float`:

- `Positive` -s
- `PositiveOrZero` -s
- `Negative` -s
- `NegativeOrZero` -s
- `Zero` -s
- `NotZero` -s


## Used technologies

- Language: C# 7.0
- Target framefork: .NET Standard 2.0, .NET Standard 1.4, .NET Standard 1.0, .NET Framework 4.0
