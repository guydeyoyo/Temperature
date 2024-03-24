namespace Temperature;


/// <summary>Convert Fahrenheit temperatures to other scales.</summary>
public class Fahrenheit
{
  #region Fahrenheit To
  /// <summary>Converts Fahrenheit to Celsius</summary>
  /// <param name="fahrenheit">Temperature in Fahrenheit, as a double.</param>
  /// <returns>Temperature in Celsius, as a double.</returns>
  public static double ToCelsius(double fahrenheit)
  {
    return ((fahrenheit - 32) * 5) / 9;
  }


  /// <summary>Converts Fahrenheit to Kelvin</summary>
  /// <param name="fahrenheit">Temperature in Fahrenheit, as a double.</param>
  /// <returns>Temperature in Kelvin, as a double.</returns>
  public static double ToKelvin(double fahrenheit)
  {
    return (((fahrenheit - 32) * 5) / 9) + 273.15;
  }


  /// <summary>Converts Fahrenheit to Rankine</summary>
  /// <param name="fahrenheit">Temperature in Fahrenheit, as a double.</param>
  /// <returns>Temperature in Rankine, as a double.</returns>
  public static double ToRankine(double fahrenheit)
  {
    return fahrenheit + 459.67;
  }


  /// <summary>Converts Fahrenheit to Delisle</summary>
  /// <param name="fahrenheit">Temperature in Fahrenheit, as a double.</param>
  /// <returns>Temperature in Delisle, as a double.</returns>
  public static double ToDelisle(double fahrenheit)
  {
    return (212 - fahrenheit) * (5 / 6);
  }


  /// <summary>Converts Fahrenheit to Newton</summary>
  /// <param name="fahrenheit">Temperature in Fahrenheit, as a double.</param>
  /// <returns>Temperature in Newton, as a double.</returns>
  public static double ToNewton(double fahrenheit)
  {
    return (fahrenheit - 32) * (11 / 60);
  }


  /// <summary>Converts Fahrenheit to Réaumur</summary>
  /// <param name="fahrenheit">Temperature in Fahrenheit, as a double.</param>
  /// <returns>Temperature in Réaumur, as a double.</returns>
  public static double ToReaumur(double fahrenheit)
  {
    return (fahrenheit - 32) * (4 / 9);
  }


  /// <summary>Converts Fahrenheit to Rømer</summary>
  /// <param name="fahrenheit">Temperature in Fahrenheit, as a double.</param>
  /// <returns>Temperature in Rømer, as a double.</returns>
  public static double ToRomer(double fahrenheit)
  {
    return ((fahrenheit - 32) * (7 / 24)) + 7.5;
  }
  #endregion Fahrenheit To
}