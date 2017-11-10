using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PowerStateManagmentCOM
{
	[Guid("770E3554-100A-4C3A-9DFB-8466D947AD68")]
	[ClassInterface(ClassInterfaceType.None)]
	class Win32SystemPowerInformation : IWin32SystemPowerInformation
	{
		public SystemPowerInformation GetSystemPowerInformation()
		{
			IntPtr status = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(SystemPowerInformation)));
			Win32FunctionInvokeWrapper.CallNtPowerInformation(INFORMATION_LEVEL.SystemPowerInformation, IntPtr.Zero, 0, status, (UInt32)Marshal.SizeOf(typeof(SystemPowerInformation)));
			return (SystemPowerInformation)Marshal.PtrToStructure(status, typeof(SystemPowerInformation));
		}
	}
}
