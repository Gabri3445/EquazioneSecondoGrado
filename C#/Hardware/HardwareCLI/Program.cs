using System;
using OpenHardwareMonitor.Hardware;

namespace PPSU_hwmonitor_c
{
    class Program
    {
        /**
         *  Define vars to hold stats
         **/

        // CPU Temp
        static float cpuTemp;

        // CPU Usage
        static float cpuUsage;

        // CPU Power Draw (Package)
        static float cpuPowerDrawPackage;

        // CPU Frequency
        static float cpuFrequency;

        // GPU Temperature
        static float gpuTemp;

        // GPU Usage
        static float gpuUsage;

        // GPU Core Frequency
        static float gpuCoreFrequency;

        // GPU Memory Frequency
        static float gpuMemoryFrequency;

        /**
         * Init OpenHardwareMonitor.dll Computer Object
         **/

        static Computer c = new Computer()
        {
            GPUEnabled = true,
            CPUEnabled = true,
            RAMEnabled = true, // uncomment for RAM reports
            MainboardEnabled = true, // uncomment for Motherboard reports
            FanControllerEnabled = true, // uncomment for FAN Reports
            HDDEnabled = true, // uncomment for HDD Report
        };

        /**
         * Pulls data from OHM
         **/

        static void ReportSystemInfo()
        {
            foreach (var hardware in c.Hardware)
            {
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    // only fire the update when found
                    hardware.Update();

                    // loop through the data
                    foreach (var sensor in hardware.Sensors)
                        if (
                            sensor.SensorType == SensorType.Temperature
                            && sensor.Name.Contains("CPU Package")
                        )
                        {
                            // store
                            cpuTemp = sensor.Value.GetValueOrDefault();
                            // print to console
                            Console.WriteLine("cpuTemp: " + sensor.Value.GetValueOrDefault());
                        }
                        else if (
                            sensor.SensorType == SensorType.Load
                            && sensor.Name.Contains("CPU Total")
                        )
                        {
                            // store
                            cpuUsage = sensor.Value.GetValueOrDefault();
                            // print to console
                            Console.WriteLine("cpuUsage: " + sensor.Value.GetValueOrDefault());
                        }
                        else if (
                            sensor.SensorType == SensorType.Power
                            && sensor.Name.Contains("CPU Package")
                        )
                        {
                            // store
                            cpuPowerDrawPackage = sensor.Value.GetValueOrDefault();
                            // print to console
                            Console.WriteLine(
                                "CPU Power Draw - Package: " + sensor.Value.GetValueOrDefault()
                            );
                        }
                        else if (
                            sensor.SensorType == SensorType.Clock
                            && sensor.Name.Contains("CPU Core #1")
                        )
                        {
                            // store
                            cpuFrequency = sensor.Value.GetValueOrDefault();
                            // print to console
                            Console.WriteLine("cpuFrequency: " + sensor.Value.GetValueOrDefault());
                        }
                }

                // Targets AMD & Nvidia GPUS
                if (
                    hardware.HardwareType == HardwareType.GpuAti
                    || hardware.HardwareType == HardwareType.GpuNvidia
                )
                {
                    // only fire the update when found
                    hardware.Update();

                    // loop through the data
                    foreach (var sensor in hardware.Sensors)
                        if (
                            sensor.SensorType == SensorType.Temperature
                            && sensor.Name.Contains("GPU Core")
                        )
                        {
                            // store
                            gpuTemp = sensor.Value.GetValueOrDefault();
                            // print to console
                            Console.WriteLine("gpuTemp: " + sensor.Value.GetValueOrDefault());
                        }
                        else if (
                            sensor.SensorType == SensorType.Load && sensor.Name.Contains("GPU Core")
                        )
                        {
                            // store
                            gpuUsage = sensor.Value.GetValueOrDefault();
                            // print to console
                            Console.WriteLine("gpuUsage: " + sensor.Value.GetValueOrDefault());
                        }
                        else if (
                            sensor.SensorType == SensorType.Clock
                            && sensor.Name.Contains("GPU Core")
                        )
                        {
                            // store
                            gpuCoreFrequency = sensor.Value.GetValueOrDefault();
                            // print to console
                            Console.WriteLine(
                                "gpuCoreFrequency: " + sensor.Value.GetValueOrDefault()
                            );
                        }
                        else if (
                            sensor.SensorType == SensorType.Clock
                            && sensor.Name.Contains("GPU Memory")
                        )
                        {
                            // store
                            gpuMemoryFrequency = sensor.Value.GetValueOrDefault();
                            // print to console
                            Console.WriteLine(
                                "gpuMemoryFrequency: " + sensor.Value.GetValueOrDefault()
                            );
                        }
                }

                // ... you can access any other system information you want here

                //ram
                if (hardware.HardwareType == HardwareType.RAM)
                {
                    hardware.Update();

                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Level) { }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            /*c.Open();

            // loop
            while (true)
            {
                Thread.Sleep(500);
                ReportSystemInfo();
                Console.WriteLine("\n");
            }*/

            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.RAMEnabled = true;

            Console.WriteLine("==========================");
            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();
                foreach (ISensor sensor in hardware.Sensors)
                {
                    if (sensor.Hardware.HardwareType == HardwareType.RAM && sensor.Name == "Memory")
                    {
                        Console.WriteLine("RAM: " + sensor.Value.GetValueOrDefault());
                    }
                }
            }
        }
    }
}
