using OpenHardwareMonitor.Hardware;

namespace OpenHardware
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.RAMEnabled = true;

            /*while (true)
            {
                Console.WriteLine("==========================");
                foreach (IHardware hardware in computer.Hardware)
                {
                    hardware.Update();

                    if (hardware.HardwareType == HardwareType.RAM)
                    {
                        foreach (ISensor sensor in hardware.Sensors)
                        {
                            if (sensor.Name == "Memory")
                            {
                                Console.WriteLine("RAM: " + sensor.Value.GetValueOrDefault() + "%");
                            }
                        }
                    }
                    else if (hardware.HardwareType == HardwareType.CPU)
                    {
                        foreach (ISensor sensor in hardware.Sensors)
                        {
                            if (sensor.Name == "CPU Total")
                            {
                                Console.WriteLine(
                                    "CPU Load : " + sensor.Value.GetValueOrDefault() + "%"
                                );
                            }
                            else if (
                                sensor.SensorType == SensorType.Clock
                                && sensor.Name == "CPU Core #1"
                            )
                            {
                                Console.WriteLine(
                                    "CPU Core #1 : " + sensor.Value.GetValueOrDefault() + "MHz"
                                );
                            }
                            else if (
                                sensor.SensorType == SensorType.Temperature
                                && sensor.Name == "CPU Package"
                            )
                            {
                                Console.WriteLine(
                                    "CPU Package : " + sensor.Value.GetValueOrDefault() + "°C"
                                );
                            }
                        }
                    }
                    else if (
                        hardware.HardwareType == HardwareType.GpuAti
                        || hardware.HardwareType == HardwareType.GpuNvidia
                    )
                    {
                        foreach (ISensor sensor in hardware.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Load)
                            {
                                Console.WriteLine(
                                    "GPU Load: " + sensor.Value.GetValueOrDefault() + "%"
                                );
                            }
                            else if (sensor.SensorType == SensorType.Clock)
                            {
                                Console.WriteLine(
                                    sensor.Name
                                        + " Clock: "
                                        + sensor.Value.GetValueOrDefault()
                                        + "MHz"
                                );
                            }
                            else if (sensor.SensorType == SensorType.Temperature)
                            {
                                Console.WriteLine(
                                    "GPU Temp: " + sensor.Value.GetValueOrDefault() + "°C"
                                );
                            }
                        }
                    }
                }
                Thread.Sleep(500);
            }*/
            Console.WriteLine("CPU Load: " + GetCPULoad());
            Console.WriteLine("CPU Clock: " + GetCPUClock());
            Console.WriteLine("CPU Temp: " + GetCPUTemp());
            Console.WriteLine("RAM Percentage: " + GetRAMPercentage());
            Console.WriteLine("GPU Usage: " + GetGPULoad());
            Console.WriteLine("GPU Core Clock: " + GetGPUCoreClock());
            Console.WriteLine("GPU Mem Clock: " + GetGPUMemClock());
            Console.WriteLine("GPU Temp: " + GetGPUTemp());
            Console.Read();
        }

        public static float? GetRAMPercentage()
        {
            float perc = 0;
            Computer computer = new Computer();
            computer.Open();
            computer.RAMEnabled = true;

            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                if (hardware.HardwareType == HardwareType.RAM)
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.Name == "Memory")
                        {
                            perc = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }

            return perc;
        }

        public static float? GetCPULoad()
        {
            float perc = 0;
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;

            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                if (hardware.HardwareType == HardwareType.CPU)
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.Name == "CPU Total")
                        {
                            perc = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
            return perc;
        }

        public static float? GetCPUClock()
        {
            float clock = 0;
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;

            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                if (hardware.HardwareType == HardwareType.CPU)
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Clock && sensor.Name == "CPU Core #1")
                        {
                            clock = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
            return clock;
        }

        public static float? GetCPUTemp()
        {
            float temp = 0;
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;

            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                if (hardware.HardwareType == HardwareType.CPU)
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (
                            sensor.SensorType == SensorType.Temperature
                            && sensor.Name == "CPU Package"
                        )
                        {
                            temp = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
            return temp;
        }

        public static float? GetGPULoad()
        {
            float load = 0;
            Computer computer = new Computer();
            computer.Open();
            computer.GPUEnabled = true;

            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                if (
                    hardware.HardwareType == HardwareType.GpuAti
                    || hardware.HardwareType == HardwareType.GpuNvidia
                )
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            load = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
            return load;
        }

        public static float? GetGPUCoreClock()
        {
            float clock = 0;
            Computer computer = new Computer();
            computer.Open();
            computer.GPUEnabled = true;

            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                if (
                    hardware.HardwareType == HardwareType.GpuAti
                    || hardware.HardwareType == HardwareType.GpuNvidia
                )
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Clock && sensor.Name == "GPU Core")
                        {
                            clock = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
            return clock;
        }

        public static float? GetGPUMemClock()
        {
            float clock = 0;
            Computer computer = new Computer();
            computer.Open();
            computer.GPUEnabled = true;

            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                if (
                    hardware.HardwareType == HardwareType.GpuAti
                    || hardware.HardwareType == HardwareType.GpuNvidia
                )
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Clock && sensor.Name == "GPU Memory")
                        {
                            clock = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
            return clock;
        }

        public static float? GetGPUTemp()
        {
            float temp = 0;
            Computer computer = new Computer();
            computer.Open();
            computer.GPUEnabled = true;

            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                if (
                    hardware.HardwareType == HardwareType.GpuAti
                    || hardware.HardwareType == HardwareType.GpuNvidia
                )
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            temp = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
            return temp;
        }
    }
}
