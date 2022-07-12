using DeviceId;

var key = new DeviceIdBuilder().AddMachineName()
                               .AddOsVersion()
                               .OnWindows(windows => windows.AddProcessorId()
                                                            .AddMotherboardSerialNumber()
                                                            .AddSystemDriveSerialNumber()

                               )
                               .ToString(); 
Console.WriteLine("Unique key: {0}: ",key);
Console.ReadLine();