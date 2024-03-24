# Temperature DLL

An open source dynamic link library written in C#, providing methods for temperature conversions.


## Supported Scales

- Celsius
- Fahrenheit
- Kelvin
- Newton
- Rankine
- Réaumur
- Rømer


## Installation

To add the library to your project, follow these steps:

1. Download the latest release from the [Releases](https://github.com/guydeyoyo/temperature/releases) page.
2. Extract the downloaded ZIP file.
3. Copy the `temperature.dll` file to your project's directory, for example in a folder called `Libraries`.
4. Add the following code to your `.csproj` file, after `</PropertyGroup>`:

  ```xml
  <ItemGroup>
    <Reference Include="Temperature">
      <SpecificVersion>false</SpecificVersion>
      <HintPath>Libraries\Temperature.dll</HintPath>
    </Reference>
  </ItemGroup>
  ```

## Usage

To use the library in your code, follow these steps:

1. Import the DLL in your code:
  ```csharp
  using Temperature;
  ```

2. Call the appropriate method to convert the temperature:
  ```csharp
  double celsius = 25;
  double fahrenheit = Temperature.Celsius.ToFahrenheit(celsius);
  ```

  or

  ```csharp
  double fahrenheit = 54;
  double kelvin = Temperature.Convert(fahrenheit, "fahrenheit", "kelvin");
  ```

  or

  ```csharp
  double kelvin = 77;
  Dictionary<string, double> output = Temperature.ConvertAll(kelvin, "kelvin");
  ```


## License

Licensed under [MIT](https://choosealicense.com/licenses/mit/)