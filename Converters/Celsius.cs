namespace Temperature;


/// <summary>Convert Celsius temperatures to other scales.</summary>
public static class Celsius
{
  #region Celsius To
  /// <summary>Converts Celsius to Fahrenheit</summary>
  /// <param name="celsius">Temperature in Celsius, as a double.</param>
  /// <returns>Temperature in Fahrenheit, as a double.</returns>
  public static double ToFahrenheit(double celsius)
  {
    return ((celsius / 5) * 9) + 32;
  }


  /// <summary>Converts Celsius to Kelvin</summary>
  /// <param name="celsius">Temperature in Celsius, as a double.</param>
  /// <returns>Temperature in Kelvin, as a double.</returns>
  public static double ToKelvin(double celsius)
  {
    return celsius + 273.15;
  }


  /// <summary>Converts Celsius to Rankine</summary>
  /// <param name="celsius">Temperature in Celsius, as a double.</param>
  /// <returns>Temperature in Rankine, as a double.</returns>
  public static double ToRankine(double celsius)
  {
    return (celsius + 273.15) * 1.8;
  }


  /// <summary>Converts Celsius to Delisle</summary>
  /// <param name="celsius">Temperature in Celsius, as a double.</param>
  /// <returns>Temperature in Delisle, as a double.</returns>
  public static double ToDelisle(double celsius)
  {
    return (100 - celsius) * (3 / 2);
  }


  /// <summary>Converts Celsius to Newton</summary>
  /// <param name="celsius">Temperature in Celsius, as a double.</param>
  /// <returns>Temperature in Newton, as a double.</returns>
  public static double ToNewton(double celsius)
  {
    return celsius * (33 / 100);
  }


  /// <summary>Converts Celsius to Réaumur</summary>
  /// <param name="celsius">Temperature in Celsius, as a double.</param>
  /// <returns>Temperature in Réaumur, as a double.</returns>
  public static double ToReaumur(double celsius)
  {
    return celsius * (4 / 5);
  }


  /// <summary>Converts Celsius to Rømer</summary>
  /// <param name="celsius">Temperature in Celsius, as a double.</param>
  /// <returns>Temperature in Rømer, as a double.</returns>
  public static double ToRomer(double celsius)
  {
    return (celsius * (21 / 40)) + 7.5;
  }
  #endregion Celsius To
}