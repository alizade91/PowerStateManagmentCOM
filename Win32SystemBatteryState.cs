using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PowerStateManagmentCOM
{
	[Guid("BE608EB6-4219-4E4E-9EC4-F037926747E0")]
	[ClassInterface(ClassInterfaceType.None)]
	class Win32SystemBatteryState : IWin32SystemBatteryState
	{
		public SystemBatteryState GetSystemBatteryState()
		{
			IntPtr status = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(SystemBatteryState)));
			Win32FunctionInvokeWrapper.CallNtPowerInformation(INFORMATION_LEVEL.SystemBatteryState, IntPtr.Zero, 0, status, (UInt32)Marshal.SizeOf(typeof(SystemBatteryState)));
			return (SystemBatteryState)Marshal.PtrToStructure(status, typeof(SystemBatteryState));
		}
	}
}
