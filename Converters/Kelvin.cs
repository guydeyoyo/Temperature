namespace Temperature;


/// <summary>Convert Kelvin temperatures to other scales.</summary>
public static class Kelvin
{
  #region Kelvin To
  /// <summary>Converts Kelvin to Celsius</summary>
  /// <param name="kelvin">Temperature in Kelvin, as a double.</param>
  /// <returns>Temperature in Celsius, as a double.</returns>
  public static double ToCelsius(double kelvin)
  {
    return kelvin - 273.15;
  }


  /// <summary>Converts Kelvin to Fahrenheit</summary>
  /// <param name="kelvin">Temperature in Kelvin, as a double.</param>
  /// <returns>Temperature in Fahrenheit, as a double.</returns>
  public static double ToFahrenheit(double kelvin)
  {
    return (((kelvin - 273.15) * 9) / 5) + 32;
  }


  /// <summary>Converts Kelvin to Rankine</summary>
  /// <param name="kelvin">Temperature in Kelvin, as a double.</param>
  /// <returns>Temperature in Rankine, as a double.</returns>
  public static double ToRankine(double kelvin)
  {
    return kelvin * 1.8;
  }


  /// <summary>Converts Kelvin to Delisle</summary>
  /// <param name="kelvin">Temperature in Kelvin, as a double.</param>
  /// <returns>Temperature in Delisle, as a double.</returns>
  public static double ToDelisle(double kelvin)
  {
    return (373.15 - kelvin) * (3 / 2);
  }


  /// <summary>Converts Kelvin to Newton</summary>
  /// <param name="kelvin">Temperature in Kelvin, as a double.</param>
  /// <returns>Temperature in Newton, as a double.</returns>
  public static double ToNewton(double kelvin)
  {
    return (kelvin - 273.15) * (33 / 100);
  }


  /// <summary>Converts Kelvin to Réaumur</summary>
  /// <param name="kelvin">Temperature in Kelvin, as a double.</param>
  /// <returns>Temperature in Réaumur, as a double.</returns>
  public static double ToReaumur(double kelvin)
  {
    return (kelvin - 273.15) * (4 / 5);
  }


  /// <summary>Converts Kelvin to Rømer</summary>
  /// <param name="kelvin">Temperature in Kelvin, as a double.</param>
  /// <returns>Temperature in Rømer, as a double.</returns>
  public static double ToRomer(double kelvin)
  {
    return ((kelvin - 273.15) * (21 / 40)) + 7.5;
  }
  #endregion Kelvin To
}