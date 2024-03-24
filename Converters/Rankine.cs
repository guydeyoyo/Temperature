namespace Temperature;


/// <summary>Convert Rankine temperatures to other scales.</summary>
public static class Rankine
{
  #region Rankine To
  /// <summary>Converts Rankine to Celsius</summary>
  /// <param name="rankine">Temperature in Rankine, as a double.</param>
  /// <returns>Temperature in Celsius, as a double.</returns>
  public static double ToCelsius(double rankine)
  {
    return (rankine / 1.8) - 273.15;
  }


  /// <summary>Converts Rankine to Fahrenheit</summary>
  /// <param name="rankine">Temperature in Rankine, as a double.</param>
  /// <returns>Temperature in Fahrenheit, as a double.</returns>
  public static double ToFahrenheit(double rankine)
  {
    return rankine - 459.67;
  }


  /// <summary>Converts Rankine to Kelvin</summary>
  /// <param name="rankine">Temperature in Rankine, as a double.</param>
  /// <returns>Temperature in Kelvin, as a double.</returns>
  public static double ToKelvin(double rankine)
  {
    return rankine / 1.8;
  }


  /// <summary>Converts Rankine to Delisle</summary>
  /// <param name="rankine">Temperature in Rankine, as a double.</param>
  /// <returns>Temperature in Delisle, as a double.</returns>
  public static double ToDelisle(double rankine)
  {
    return (671.67 - rankine) * (5 / 6);
  }


  /// <summary>Converts Rankine to Newton</summary>
  /// <param name="rankine">Temperature in Rankine, as a double.</param>
  /// <returns>Temperature in Newton, as a double.</returns>
  public static double ToNewton(double rankine)
  {
    return (rankine - 491.67) * (11 / 60);
  }


  /// <summary>Converts Rankine to Réaumur</summary>
  /// <param name="rankine">Temperature in Rankine, as a double.</param>
  /// <returns>Temperature in Réaumur, as a double.</returns>
  public static double ToReaumur(double rankine)
  {
    return (rankine - 491.67) * (4 / 9);
  }


  /// <summary>Converts Rankine to Rømer</summary>
  /// <param name="rankine">Temperature in Rankine, as a double.</param>
  /// <returns>Temperature in Rømer, as a double.</returns>
  public static double ToRomer(double rankine)
  {
    return ((rankine - 491.67) * (7 / 24)) + 7.5;
  }
  #endregion Rankine To
}