namespace Temperature;


/// <summary>Convert Newton temperatures to other scales.</summary>
public static class Newton
{
  #region Newton To
  /// <summary>Converts Newton to Celsius</summary>
  /// <param name="newton">Temperature in Newton, as a double.</param>
  /// <returns>Temperature in Celsius, as a double.</returns>
  public static double ToCelsius(double newton)
  {
    return newton * (100 / 33);
  }


  /// <summary>Converts Newton to Fahrenheit</summary>
  /// <param name="newton">Temperature in Newton, as a double.</param>
  /// <returns>Temperature in Fahrenheit, as a double.</returns>
  public static double ToFahrenheit(double newton)
  {
    return (newton * (60 / 11)) + 32;
  }


  /// <summary>Converts Newton to Kelvin</summary>
  /// <param name="newton">Temperature in Newton, as a double.</param>
  /// <returns>Temperature in Kelvin, as a double.</returns>
  public static double ToKelvin(double newton)
  {
    return (newton * (100 / 33)) + 273.15;
  }


  /// <summary>Converts Newton to Rankine</summary>
  /// <param name="newton">Temperature in Newton, as a double.</param>
  /// <returns>Temperature in Rankine, as a double.</returns>
  public static double ToRankine(double newton)
  {
    return (newton * (60 / 11)) + 491.67;
  }


  /// <summary>Converts Newton to Delisle</summary>
  /// <param name="newton">Temperature in Newton, as a double.</param>
  /// <returns>Temperature in Delisle, as a double.</returns>
  public static double ToDelisle(double newton)
  {
    return (33 - newton) * (50 / 11);
  }


  /// <summary>Converts Newton to Réaumur</summary>
  /// <param name="newton">Temperature in Newton, as a double.</param>
  /// <returns>Temperature in Réaumur, as a double.</returns>
  public static double ToReaumur(double newton)
  {
    return newton * (80 / 33);
  }


  /// <summary>Converts Newton to Rømer</summary>
  /// <param name="newton">Temperature in Newton, as a double.</param>
  /// <returns>Temperature in Rømer, as a double.</returns>
  public static double ToRomer(double newton)
  {
    return (newton * (35 / 22)) + 7.5;
  }
  #endregion Newton To
}