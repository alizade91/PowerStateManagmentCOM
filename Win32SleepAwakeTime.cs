using System;
using System.Runtime.InteropServices;

namespace PowerStateManagmentCOM
{
	[Guid("061AF1B4-8F35-482F-8E84-3B7284ADBD38")]
	[ClassInterface(ClassInterfaceType.None)]
	class Win32SleepAwakeTime
	{
		public DateTime GetLastSleepTime()
		{
			IntPtr status = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(long)));
			Win32FunctionInvokeWrapper.CallNtPowerInformation(INFORMATION_LEVEL.LastSleepTime, (IntPtr)null, 0, status, (UInt32)Marshal.SizeOf(typeof(long)));
			long lastSleepTime = (long)Marshal.PtrToStructure(status, typeof(long));
			return DateTime.FromFileTime(lastSleepTime);
		}

		public DateTime GetLastAwakeTime()
		{
			IntPtr status = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(long)));
			Win32FunctionInvokeWrapper.CallNtPowerInformation(INFORMATION_LEVEL.LastWakeTime, (IntPtr)null, 0, status, (UInt32)Marshal.SizeOf(typeof(long)));
			long lastWakeTime = (long)Marshal.PtrToStructure(status, typeof(long));
			return DateTime.FromFileTime(lastWakeTime);
		}
	}
}
