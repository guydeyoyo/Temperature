namespace Temperature;


/// <summary>Convert Delisle temperatures to other scales.</summary>
public static class Delisle
{
  #region Delisle To
  /// <summary>Converts Delisle to Celsius</summary>
  /// <param name="delisle">Temperature in Delisle, as a double.</param>
  /// <returns>Temperature in Celsius, as a double.</returns>
  public static double ToCelsius(double delisle)
  {
    return 100 - (delisle * (2 / 3));
  }


  /// <summary>Converts Delisle to Fahrenheit</summary>
  /// <param name="delisle">Temperature in Delisle, as a double.</param>
  /// <returns>Temperature in Fahrenheit, as a double.</returns>
  public static double ToFahrenheit(double delisle)
  {
    return 212 - (delisle * (6 / 5));
  }


  /// <summary>Converts Delisle to Kelvin</summary>
  /// <param name="delisle">Temperature in Delisle, as a double.</param>
  /// <returns>Temperature in Kelvin, as a double.</returns>
  public static double ToKelvin(double delisle)
  {
    return 373.15 - (delisle * (2 / 3));
  }


  /// <summary>Converts Delisle to Rankine</summary>
  /// <param name="delisle">Temperature in Delisle, as a double.</param>
  /// <returns>Temperature in Rankine, as a double.</returns>
  public static double ToRankine(double delisle)
  {
    return 671.67 - (delisle * (6 / 5));
  }


  /// <summary>Converts Delisle to Newton</summary>
  /// <param name="delisle">Temperature in Delisle, as a double.</param>
  /// <returns>Temperature in Newton, as a double.</returns>
  public static double ToNewton(double delisle)
  {
    return 33 - (delisle * (11 / 50));
  }


  /// <summary>Converts Delisle to Réaumur</summary>
  /// <param name="delisle">Temperature in Delisle, as a double.</param>
  /// <returns>Temperature in Réaumur, as a double.</returns>
  public static double ToReaumur(double delisle)
  {
    return 80 - (delisle * (8 / 15));
  }


  /// <summary>Converts Delisle to Rømer</summary>
  /// <param name="delisle">Temperature in Delisle, as a double.</param>
  /// <returns>Temperature in Rømer, as a double.</returns>
  public static double ToRomer(double delisle)
  {
    return 60 - (delisle * (7 / 20));
  }
  #endregion Delisle To
}