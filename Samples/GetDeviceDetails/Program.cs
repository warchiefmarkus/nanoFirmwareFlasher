﻿////
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
////

using nanoFramework.Tools.FirmwareFlasher;
using System;

namespace GetDeviceDetails
{
    internal class Program
    {
        // COM port where the nano device is connected
        // replace with the appropriate COM port number for the device you have connected
        private const string ComPort = "COM10";
        private static NanoDeviceOperations _nanoDeviceOperations;

        static void Main(string[] args)
        {
            _nanoDeviceOperations = new NanoDeviceOperations();

            var device = _nanoDeviceOperations.GetDeviceDetails(ComPort);

            Console.Read();
        }
    }
}
