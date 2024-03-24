namespace Temperature;

public class Temperature
{
  #region Convert
  /// <summary>Converts a temperature from one unit to another</summary>
  /// <param name="temperature">Temperature to convert, as a double.</param>
  /// <param name="from">Unit to convert from, as a string.</param>
  /// <param name="to">Unit to convert to, as a string.</param>
  /// <returns>Temperature in the new unit, as a double.</returns>
  public double Convert(double temperature, string from, string to)
  {
    if(string.IsNullOrWhiteSpace(from)) throw new ArgumentNullException("from", "from cannot be null or empty.");
    if(string.IsNullOrWhiteSpace(to)) throw new ArgumentNullException("to", "to cannot be null or empty.");

    if(from.Length < 4 || from.Length > 10) throw new ArgumentOutOfRangeException("from", "from must be between 4 and 10 characters.");
    if(to.Length < 4 || to.Length > 10) throw new ArgumentOutOfRangeException("to", "to must be between 4 and 10 characters.");

    string[] valid = { "celsius", "fahrenheit", "kelvin", "rankine", "delisle", "newton", "réaumur", "reaumur", "rømer", "romer" };
    if(!valid.Contains(from.ToLower())) throw new ArgumentOutOfRangeException("from", "from must be a valid temperature unit.");
    if(!valid.Contains(to.ToLower())) throw new ArgumentOutOfRangeException("to", "to must be a valid temperature unit.");

    switch (from.ToLower())
    {
      case "celsius": {
        switch (to.ToLower())
        {
          case "fahrenheit": { return Celsius.ToFahrenheit(temperature); }
          case "kelvin": { return Celsius.ToKelvin(temperature); }
          case "rankine": { return Celsius.ToRankine(temperature); }
          case "delisle": { return Celsius.ToDelisle(temperature); }
          case "newton": { return Celsius.ToNewton(temperature); }
          case "réaumur": { return Celsius.ToReaumur(temperature); }
          case "reaumur": { return Celsius.ToReaumur(temperature); }
          case "rømer": { return Celsius.ToRomer(temperature); }
          case "romer": { return Celsius.ToRomer(temperature); }
          default: { return temperature; }
        }
      }

      case "fahrenheit": {
        switch (to.ToLower())
        {
          case "celsius": { return Fahrenheit.ToCelsius(temperature); }
          case "kelvin": { return Fahrenheit.ToKelvin(temperature); }
          case "rankine": { return Fahrenheit.ToRankine(temperature); }
          case "delisle": { return Fahrenheit.ToDelisle(temperature); }
          case "newton": { return Fahrenheit.ToNewton(temperature); }
          case "réaumur": { return Fahrenheit.ToReaumur(temperature); }
          case "reaumur": { return Fahrenheit.ToReaumur(temperature); }
          case "rømer": { return Fahrenheit.ToRomer(temperature); }
          case "romer": { return Fahrenheit.ToRomer(temperature); }
          default: { return temperature; }
        }
      }

      case "kelvin": {
        switch (to.ToLower())
        {
          case "celsius": { return Kelvin.ToCelsius(temperature); }
          case "fahrenheit": { return Kelvin.ToFahrenheit(temperature); }
          case "rankine": { return Kelvin.ToRankine(temperature); }
          case "delisle": { return Kelvin.ToDelisle(temperature); }
          case "newton": { return Kelvin.ToNewton(temperature); }
          case "réaumur": { return Kelvin.ToReaumur(temperature); }
          case "reaumur": { return Kelvin.ToReaumur(temperature); }
          case "rømer": { return Kelvin.ToRomer(temperature); }
          case "romer": { return Kelvin.ToRomer(temperature); }
          default: { return temperature; }
        }
      }

      case "rankine": {
        switch (to.ToLower())
        {
          case "celsius": { return Rankine.ToCelsius(temperature); }
          case "fahrenheit": { return Rankine.ToFahrenheit(temperature); }
          case "kelvin": { return Rankine.ToKelvin(temperature); }
          case "delisle": { return Rankine.ToDelisle(temperature); }
          case "newton": { return Rankine.ToNewton(temperature); }
          case "réaumur": { return Rankine.ToReaumur(temperature); }
          case "reaumur": { return Rankine.ToReaumur(temperature); }
          case "rømer": { return Rankine.ToRomer(temperature); }
          case "romer": { return Rankine.ToRomer(temperature); }
          default: { return temperature; }
        }
      }
      
      case "delisle": {
        switch (to.ToLower())
        {
          case "celsius": { return Delisle.ToCelsius(temperature); }
          case "fahrenheit": { return Delisle.ToFahrenheit(temperature); }
          case "kelvin": { return Delisle.ToKelvin(temperature); }
          case "rankine": { return Delisle.ToRankine(temperature); }
          case "newton": { return Delisle.ToNewton(temperature); }
          case "réaumur": { return Delisle.ToReaumur(temperature); }
          case "reaumur": { return Delisle.ToReaumur(temperature); }
          case "rømer": { return Delisle.ToRomer(temperature); }
          case "romer": { return Delisle.ToRomer(temperature); }
          default: { return temperature; }
        }
      }

      case "newton": {
        switch (to.ToLower())
        {
          case "celsius": { return Newton.ToCelsius(temperature); }
          case "fahrenheit": { return Newton.ToFahrenheit(temperature); }
          case "kelvin": { return Newton.ToKelvin(temperature); }
          case "rankine": { return Newton.ToRankine(temperature); }
          case "delisle": { return Newton.ToDelisle(temperature); }
          case "réaumur": { return Newton.ToReaumur(temperature); }
          case "reaumur": { return Newton.ToReaumur(temperature); }
          case "rømer": { return Newton.ToRomer(temperature); }
          case "romer": { return Newton.ToRomer(temperature); }
          default: { return temperature; }
        }
      }
      
      case "réaumur": {
        switch (to.ToLower())
        {
          case "celsius": { return Reaumur.ToCelsius(temperature); }
          case "fahrenheit": { return Reaumur.ToFahrenheit(temperature); }
          case "kelvin": { return Reaumur.ToKelvin(temperature); }
          case "rankine": { return Reaumur.ToRankine(temperature); }
          case "delisle": { return Reaumur.ToDelisle(temperature); }
          case "newton": { return Reaumur.ToNewton(temperature); }
          case "rømer": { return Reaumur.ToRomer(temperature); }
          case "romer": { return Reaumur.ToRomer(temperature); }
          default: { return temperature; }
        }
      }

      case "reaumur": {
        switch (to.ToLower())
        {
          case "celsius": { return Reaumur.ToCelsius(temperature); }
          case "fahrenheit": { return Reaumur.ToFahrenheit(temperature); }
          case "kelvin": { return Reaumur.ToKelvin(temperature); }
          case "rankine": { return Reaumur.ToRankine(temperature); }
          case "delisle": { return Reaumur.ToDelisle(temperature); }
          case "newton": { return Reaumur.ToNewton(temperature); }
          case "rømer": { return Reaumur.ToRomer(temperature); }
          case "romer": { return Reaumur.ToRomer(temperature); }
          default: { return temperature; }
        }
      }

      case "rømer": {
        switch (to.ToLower())
        {
          case "celsius": { return Romer.ToCelsius(temperature); }
          case "fahrenheit": { return Romer.ToFahrenheit(temperature); }
          case "kelvin": { return Romer.ToKelvin(temperature); }
          case "rankine": { return Romer.ToRankine(temperature); }
          case "delisle": { return Romer.ToDelisle(temperature); }
          case "newton": { return Romer.ToNewton(temperature); }
          case "réaumur": { return Romer.ToReaumur(temperature); }
          case "reaumur": { return Romer.ToReaumur(temperature); }
          default: { return temperature; }
        }
      }

      case "romer": {
        switch (to.ToLower())
        {
          case "celsius": { return Romer.ToCelsius(temperature); }
          case "fahrenheit": { return Romer.ToFahrenheit(temperature); }
          case "kelvin": { return Romer.ToKelvin(temperature); }
          case "rankine": { return Romer.ToRankine(temperature); }
          case "delisle": { return Romer.ToDelisle(temperature); }
          case "newton": { return Romer.ToNewton(temperature); }
          case "réaumur": { return Romer.ToReaumur(temperature); }
          case "reaumur": { return Romer.ToReaumur(temperature); }
          default: { return temperature; }
        }
      }

      default: { return temperature; }
    }
  }
  #endregion Convert


  #region ConvertAll
  /// <summary>Converts a temperature from one unit to all other units</summary>
  /// <param name="temperature">Temperature to convert, as a double.</param>
  /// <param name="from">Unit to convert from, as a string.</param>
  /// <returns>Dictionary of all temperatures in other units, as a Dictionary.</returns>
  public Dictionary<string, double> ConvertAll(double temperature, string from)
  {
    if(string.IsNullOrWhiteSpace(from)) throw new ArgumentNullException("from", "from cannot be null or empty.");

    if(from.Length < 4 || from.Length > 10) throw new ArgumentOutOfRangeException("from", "from must be between 4 and 10 characters.");

    string[] valid = { "celsius", "fahrenheit", "kelvin", "rankine", "delisle", "newton", "réaumur", "reaumur", "rømer", "romer" };
    if(!valid.Contains(from.ToLower())) throw new ArgumentOutOfRangeException("from", "from must be a valid temperature unit.");

    Dictionary<string, double> result = new Dictionary<string, double>();

    switch (from.ToLower())
    {
      case "celsius": {
        result.Add("fahrenheit", Celsius.ToFahrenheit(temperature));
        result.Add("kelvin", Celsius.ToKelvin(temperature));
        result.Add("rankine", Celsius.ToRankine(temperature));
        result.Add("delisle", Celsius.ToDelisle(temperature));
        result.Add("newton", Celsius.ToNewton(temperature));
        result.Add("réaumur", Celsius.ToReaumur(temperature));
        result.Add("rømer", Celsius.ToRomer(temperature));
        break;
      }

      case "fahrenheit": {
        result.Add("celsius", Fahrenheit.ToCelsius(temperature));
        result.Add("kelvin", Fahrenheit.ToKelvin(temperature));
        result.Add("rankine", Fahrenheit.ToRankine(temperature));
        result.Add("delisle", Fahrenheit.ToDelisle(temperature));
        result.Add("newton", Fahrenheit.ToNewton(temperature));
        result.Add("réaumur", Fahrenheit.ToReaumur(temperature));
        result.Add("rømer", Fahrenheit.ToRomer(temperature));
        break;
      }

      case "kelvin": {
        result.Add("celsius", Kelvin.ToCelsius(temperature));
        result.Add("fahrenheit", Kelvin.ToFahrenheit(temperature));
        result.Add("rankine", Kelvin.ToRankine(temperature));
        result.Add("delisle", Kelvin.ToDelisle(temperature));
        result.Add("newton", Kelvin.ToNewton(temperature));
        result.Add("réaumur", Kelvin.ToReaumur(temperature));
        result.Add("rømer", Kelvin.ToRomer(temperature));
        break;
      }

      case "rankine": {
        result.Add("celsius", Rankine.ToCelsius(temperature));
        result.Add("fahrenheit", Rankine.ToFahrenheit(temperature));
        result.Add("kelvin", Rankine.ToKelvin(temperature));
        result.Add("delisle", Rankine.ToDelisle(temperature));
        result.Add("newton", Rankine.ToNewton(temperature));
        result.Add("réaumur", Rankine.ToReaumur(temperature));
        result.Add("rømer", Rankine.ToRomer(temperature));
        break;
      }

      case "delisle": {
        result.Add("celsius", Delisle.ToCelsius(temperature));
        result.Add("fahrenheit", Delisle.ToFahrenheit(temperature));
        result.Add("kelvin", Delisle.ToKelvin(temperature));
        result.Add("rankine", Delisle.ToRankine(temperature));
        result.Add("newton", Delisle.ToNewton(temperature));
        result.Add("réaumur", Delisle.ToReaumur(temperature));
        result.Add("rømer", Delisle.ToRomer(temperature));
        break;
      }

      case "newton": {
        result.Add("celsius", Newton.ToCelsius(temperature));
        result.Add("fahrenheit", Newton.ToFahrenheit(temperature));
        result.Add("kelvin", Newton.ToKelvin(temperature));
        result.Add("rankine", Newton.ToRankine(temperature));
        result.Add("delisle", Newton.ToDelisle(temperature));
        result.Add("réaumur", Newton.ToReaumur(temperature));
        result.Add("rømer", Newton.ToRomer(temperature));
        break;
      }

      case "réaumur": {
        result.Add("celsius", Reaumur.ToCelsius(temperature));
        result.Add("fahrenheit", Reaumur.ToFahrenheit(temperature));
        result.Add("kelvin", Reaumur.ToKelvin(temperature));
        result.Add("rankine", Reaumur.ToRankine(temperature));
        result.Add("delisle", Reaumur.ToDelisle(temperature));
        result.Add("newton", Reaumur.ToNewton(temperature));
        result.Add("rømer", Reaumur.ToRomer(temperature));
        break;
      }

      case "reaumur": {
        result.Add("celsius", Reaumur.ToCelsius(temperature));
        result.Add("fahrenheit", Reaumur.ToFahrenheit(temperature));
        result.Add("kelvin", Reaumur.ToKelvin(temperature));
        result.Add("rankine", Reaumur.ToRankine(temperature));
        result.Add("delisle", Reaumur.ToDelisle(temperature));
        result.Add("newton", Reaumur.ToNewton(temperature));
        result.Add("rømer", Reaumur.ToRomer(temperature));
        break;
      }

      case "rømer": {
        result.Add("celsius", Romer.ToCelsius(temperature));
        result.Add("fahrenheit", Romer.ToFahrenheit(temperature));
        result.Add("kelvin", Romer.ToKelvin(temperature));
        result.Add("rankine", Romer.ToRankine(temperature));
        result.Add("delisle", Romer.ToDelisle(temperature));
        result.Add("newton", Romer.ToNewton(temperature));
        result.Add("réaumur", Romer.ToReaumur(temperature));
        break;
      }

      case "romer": {
        result.Add("celsius", Romer.ToCelsius(temperature));
        result.Add("fahrenheit", Romer.ToFahrenheit(temperature));
        result.Add("kelvin", Romer.ToKelvin(temperature));
        result.Add("rankine", Romer.ToRankine(temperature));
        result.Add("delisle", Romer.ToDelisle(temperature));
        result.Add("newton", Romer.ToNewton(temperature));
        result.Add("réaumur", Romer.ToReaumur(temperature));
        break;
      }

      default: { break; }
    }

    return result;
  }
  #endregion ConvertAll
}
