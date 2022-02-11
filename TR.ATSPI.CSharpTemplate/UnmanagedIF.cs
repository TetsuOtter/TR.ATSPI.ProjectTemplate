using System;
using System.Runtime.InteropServices;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;

namespace $safeprojectname$
{
	public static class UnmanagedIF
	{
		const CallingConvention callingConvention = CallingConvention.StdCall;
		static HandlePos handlePos;

		[DllExport(CallingConvention = callingConvention)]
		public static void Dispose()
		{

		}

		[DllExport(CallingConvention = callingConvention)]
		public static void DoorClose()
		{

		}

		[DllExport(CallingConvention = callingConvention)]
		public static void DoorOpen()
		{

		}

		[DllExport(CallingConvention = callingConvention)]
		public static HandlePos Elapse(State s, IntPtr Pa, IntPtr So)
		{
			return handlePos;
		}

		[DllExport(CallingConvention = callingConvention)]
		public static uint GetPluginVersion()
		{
			return ATSConstantValues.VERSION;
		}

		[DllExport(CallingConvention = callingConvention)]
		public static void HornBlow(int k)
		{

		}

		[DllExport(CallingConvention = callingConvention)]
		public static void Initialize(int s)
		{

		}

		[DllExport(CallingConvention = callingConvention)]
		public static void KeyDown(int k)
		{

		}

		[DllExport(CallingConvention = callingConvention)]
		public static void KeyUp(int k)
		{

		}

		[DllExport(CallingConvention = callingConvention)]
		public static void Load()
		{

		}

		[DllExport(CallingConvention = callingConvention)]
		public static void SetBeaconData(Beacon b)
		{

		}

		[DllExport(CallingConvention = callingConvention)]
		public static void SetBrake(int b)
		{
			handlePos.Brake = b;
		}

		[DllExport(CallingConvention = callingConvention)]
		public static void SetPower(int p)
		{
			handlePos.Power = p;
		}

		[DllExport(CallingConvention = callingConvention)]
		public static void SetReverser(int r)
		{
			handlePos.Reverser = r;
		}

		[DllExport(CallingConvention = callingConvention)]
		public static void SetSignal(int s)
		{

		}

		[DllExport(CallingConvention = callingConvention)]
		public static void SetVehicleSpec(Spec s)
		{

		}
	}
}
