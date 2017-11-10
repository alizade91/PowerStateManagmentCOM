using System;
using System.Runtime.InteropServices;

namespace PowerStateManagmentCOM
{
	public enum INFORMATION_LEVEL
	{
		AdministratorPowerPolicy = 9,
		LastSleepTime = 15,
		LastWakeTime = 14,
		ProcessorInformation = 11,
		ProcessorPowerPolicyAc = 18,
		ProcessorPowerPolicyCurrent = 22,
		ProcessorPowerPolicyDc = 19,
		SystemBatteryState = 5,
		SystemExecutionState = 16,
		SystemPowerCapabilities = 4,
		SystemPowerInformation = 12,
		SystemPowerPolicyAc = 0,
		SystemPowerPolicyCurrent = 8,
		SystemPowerPolicyDc = 1,
		SystemReserveHiberFile = 10,
		VerifyProcessorPowerPolicyAc = 20,
		VerifyProcessorPowerPolicyDc = 21,
		VerifySystemPolicyAc = 2,
		VerifySystemPolicyDc = 3
	}

	public struct SystemBatteryState
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool AcOnLine;
		[MarshalAs(UnmanagedType.I1)]
		public bool BatteryPresent;
		[MarshalAs(UnmanagedType.I1)]
		public bool Charging;
		[MarshalAs(UnmanagedType.I1)]
		public bool Discharging;
		public byte Spare0;
		public byte Spare1;
		public byte Spare2;
		public byte Spare3;
		public uint MaxCapacity;
		public uint RemainingCapacity;
		public int Rate;
		public uint EstimatedTime;
		public uint DefaultAlert1;
		public uint DefaultAlert2;
	}

	public struct SystemPowerInformation
	{
		public uint MaxIdlenessAllowed;
		public uint Idleness;
		public uint TimeRemaining;
		public byte CoolingMode;
	}

	public class Win32FunctionInvokeWrapper
	{
		[DllImport("PowrProf.dll", SetLastError = true)]
		public static extern UInt32 CallNtPowerInformation(INFORMATION_LEVEL InformationLevel, IntPtr lpInputBuffer, UInt32 nInputBufferSize, IntPtr lpOutputBuffer, UInt32 nOutputBufferSize);
	}

}
