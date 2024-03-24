namespace Temperature;


/// <summary>Convert Rømer temperatures to other scales.</summary>
public static class Romer
{
  #region Rømer To
  /// <summary>Converts Rømer to Celsius</summary>
  /// <param name="romer">Temperature in Rømer, as a double.</param>
  /// <returns>Temperature in Celsius, as a double.</returns>
  public static double ToCelsius(double romer)
  {
    return (romer - 7.5) * (40 / 21);
  }


  /// <summary>Converts Rømer to Fahrenheit</summary>
  /// <param name="romer">Temperature in Rømer, as a double.</param>
  /// <returns>Temperature in Fahrenheit, as a double.</returns>
  public static double ToFahrenheit(double romer)
  {
    return (romer - 7.5) * (24 / 7) + 32;
  }


  /// <summary>Converts Rømer to Kelvin</summary>
  /// <param name="romer">Temperature in Rømer, as a double.</param>
  /// <returns>Temperature in Kelvin, as a double.</returns>
  public static double ToKelvin(double romer)
  {
    return (romer - 7.5) * (40 / 21) + 273.15;
  }


  /// <summary>Converts Rømer to Rankine</summary>
  /// <param name="romer">Temperature in Rømer, as a double.</param>
  /// <returns>Temperature in Rankine, as a double.</returns>
  public static double ToRankine(double romer)
  {
    return (romer - 7.5) * (24 / 7) + 491.67;
  }


  /// <summary>Converts Rømer to Delisle</summary>
  /// <param name="romer">Temperature in Rømer, as a double.</param>
  /// <returns>Temperature in Delisle, as a double.</returns>
  public static double ToDelisle(double romer)
  {
    return (60 - romer) * (20 / 7);
  }


  /// <summary>Converts Rømer to Newton</summary>
  /// <param name="romer">Temperature in Rømer, as a double.</param>
  /// <returns>Temperature in Newton, as a double.</returns>
  public static double ToNewton(double romer)
  {
    return (romer - 7.5) * (22 / 35);
  }


  /// <summary>Converts Rømer to Réaumur</summary>
  /// <param name="romer">Temperature in Rømer, as a double.</param>
  /// <returns>Temperature in Réaumur, as a double.</returns>
  public static double ToReaumur(double romer)
  {
    return (romer - 7.5) * (32 / 21);
  }
  #endregion Rømer To
}