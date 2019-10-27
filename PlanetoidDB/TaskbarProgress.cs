using System;
using System.Runtime.InteropServices;

/// <summary>
/// 
/// </summary>
public static class TaskbarProgress
{
	/// <summary>
	/// 
	/// </summary>
	public enum TaskbarStates
	{
		/// <summary>
		/// 
		/// </summary>
		NoProgress = 0,
		/// <summary>
		/// 
		/// </summary>
		Indeterminate = 0x1,
		/// <summary>
		/// 
		/// </summary>
		Normal = 0x2,
		/// <summary>
		/// 
		/// </summary>
		Error = 0x4,
		/// <summary>
		/// 
		/// </summary>
		Paused = 0x8
	}

	/// <summary>
	/// 
	/// </summary>
	[ComImport()]
	[Guid("ea1afb91-9e28-4b86-90e9-9e9f8a5eefaf")]
	[InterfaceType(interfaceType: ComInterfaceType.InterfaceIsIUnknown)]
	private interface ITaskbarList3
	{
		// ITaskbarList
		[PreserveSig]
		void HrInit();
		[PreserveSig]
		void AddTab(IntPtr hwnd);
		[PreserveSig]
		void DeleteTab(IntPtr hwnd);
		[PreserveSig]
		void ActivateTab(IntPtr hwnd);
		[PreserveSig]
		void SetActiveAlt(IntPtr hwnd);

		// ITaskbarList2
		[PreserveSig]
		void MarkFullscreenWindow(IntPtr hwnd, [MarshalAs(UnmanagedType.Bool)] bool fFullscreen);

		// ITaskbarList3
		[PreserveSig]
		void SetProgressValue(IntPtr hwnd, ulong ullCompleted, ulong ullTotal);
		[PreserveSig]
		void SetProgressState(IntPtr hwnd, TaskbarStates state);
	}

	/// <summary>
	/// 
	/// </summary>
	[Guid("56FDF344-FD6D-11d0-958A-006097C9A090")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComImport()]
	private class TaskbarInstance
	{
	}

	private static ITaskbarList3 taskbarInstance = (ITaskbarList3)new TaskbarInstance();

	private static readonly bool taskbarSupported = Environment.OSVersion.Version >= new Version(major: 6, minor: 1);

	/// <summary>
	/// 
	/// </summary>
	/// <param name="windowHandle"></param>
	/// <param name="taskbarState"></param>
	public static void SetState(IntPtr windowHandle, TaskbarStates taskbarState)
	{
		if (taskbarSupported)
		{
			taskbarInstance.SetProgressState(hwnd: windowHandle, state: taskbarState);
		}
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="windowHandle"></param>
	/// <param name="progressValue"></param>
	/// <param name="progressMax"></param>
	public static void SetValue(IntPtr windowHandle, double progressValue, double progressMax)
	{
		if (taskbarSupported)
		{
			taskbarInstance.SetProgressValue(hwnd: windowHandle, ullCompleted: (ulong)progressValue, ullTotal: (ulong)progressMax);
		}
	}
}