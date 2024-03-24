namespace Temperature;


/// <summary>Convert Réaumur temperatures to other scales.</summary>
public static class Reaumur
{
  #region Réaumur To
  /// <summary>Converts Réaumur to Celsius</summary>
  /// <param name="reaumur">Temperature in Réaumur, as a double.</param>
  /// <returns>Temperature in Celsius, as a double.</returns>
  public static double ToCelsius(double reaumur)
  {
    return reaumur * (5 / 4);
  }


  /// <summary>Converts Réaumur to Fahrenheit</summary>
  /// <param name="reaumur">Temperature in Réaumur, as a double.</param>
  /// <returns>Temperature in Fahrenheit, as a double.</returns>
  public static double ToFahrenheit(double reaumur)
  {
    return (reaumur * (9 / 4)) + 32;
  }


  /// <summary>Converts Réaumur to Kelvin</summary>
  /// <param name="reaumur">Temperature in Réaumur, as a double.</param>
  /// <returns>Temperature in Kelvin, as a double.</returns>
  public static double ToKelvin(double reaumur)
  {
    return (reaumur * (5 / 4)) + 273.15;
  }


  /// <summary>Converts Réaumur to Rankine</summary>
  /// <param name="reaumur">Temperature in Réaumur, as a double.</param>
  /// <returns>Temperature in Rankine, as a double.</returns>
  public static double ToRankine(double reaumur)
  {
    return (reaumur * (9 / 4)) + 491.67;
  }


  /// <summary>Converts Réaumur to Delisle</summary>
  /// <param name="reaumur">Temperature in Réaumur, as a double.</param>
  /// <returns>Temperature in Delisle, as a double.</returns>
  public static double ToDelisle(double reaumur)
  {
    return (80 - reaumur) * (8 / 15);
  }


  /// <summary>Converts Réaumur to Newton</summary>
  /// <param name="reaumur">Temperature in Réaumur, as a double.</param>
  /// <returns>Temperature in Newton, as a double.</returns>
  public static double ToNewton(double reaumur)
  {
    return reaumur * (33 / 80);
  }


  /// <summary>Converts Réaumur to Rømer</summary>
  /// <param name="reaumur">Temperature in Réaumur, as a double.</param>
  /// <returns>Temperature in Rømer, as a double.</returns>
  public static double ToRomer(double reaumur)
  {
    return (reaumur * (21 / 32)) + 7.5;
  }
  #endregion Réaumur To
}