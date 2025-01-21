# Facepod Sensors - HID Gate Facepod on-board Power and Temperature Sensors

## Summary
Provides access to the on-board HID Facepod Temperature and Digital Power Monitor Sensors.
Also provides a menu selection to log the data with a specified interval in seconds. 

Solution uses the separate project .DLLS for 

 * FpPwrSensorDll.dll from FpPowerSensor project 
 * FpTempSensorDll.dll from FpTempSensor project

 * A .NET Forms GUI demo application using the DLL's through interop services: FpPowerDisplay.exe
 

## Requirements
* Visual Studio 2022
* .NET 8 Runtime must be installed on hosted system. See: [.NET 8 Runtime Installer:](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-8.0.2-windows-x64-installer)
* MSCI2C64.dll from Avnet Embedded. This provides an PICMG Embedded Application Programming Interface (EAPI) to the I2C interface on 
	the underlying COM-Express module via A copy is included here but the original can be obtained from [[Avnet MSC EAPI NG Win10 Win11 x64](https://embedded.avnet.com/software-tools/#msc_eapi_ng])


## Usage

Find the .NET GUI application, FpPowerDisplay.exe, and launch it. 

![screenshot](https://github.com/davidkilp/FacepodSensors/blob/master/Facepod-SensorScreenshot.jpg)

Click the Start button to intitiate updates from the sensor every X-seconds (adjustable from default of 5 seconds.

NOTE: If the Sensor is not detected, the data will be all N/A and a message at the bottom will 
be displayed as shown.

If you wish to log the sensor data, select the File menu | Save Log as... and pick a directory and filename where 
the data will be saved. The logged data will be written in CSV format and suitable for import into Excel, etc. in the following
format

```
----------------------- CSV File ------------------
sep=,
Date,Top Temperature(°C),CPU Temperature(°C),Bus Voltage(V),Current(A),Power(W)
1/21/2025 3:52:38 PM,25.50,30.69,N/A,N/A,N/A
----------------------- CSV File ------------------
```

If the sensor is not present N/A will be displayed and output to the log.

