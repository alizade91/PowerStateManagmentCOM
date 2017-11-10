using System;
using System.Runtime.InteropServices;

namespace PowerStateManagmentCOM
{
	[Guid("5962624B-F280-45BC-8C0D-9884BD5780C0")]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	interface IWin32SleepAwakeTime
	{
		[DispId(1)]
		DateTime GetLastSleepTime();
		[DispId(2)]
		DateTime GetLastAwakeTime();
	}
}
