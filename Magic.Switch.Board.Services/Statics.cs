﻿using System.Globalization;
using System.Reflection;

namespace Magic.Switch.Board.Services;

/// <summary>
/// The static <see cref="Statics"/> class.
/// </summary>
internal static class Statics
{
	private static readonly Assembly assembly;

	/// <summary>
	/// The <see cref="AssemblyDirectory"/> property.
	/// </summary>
	public static string AssemblyDirectory { get; private set; }
	/// <summary>
	/// The <see cref="AssemblyName"/> property.
	/// </summary>
	public static string AssemblyName { get; private set; }
	/// <summary>
	/// The <see cref="CurrentCulture"/> property.
	/// </summary>
	public static CultureInfo CurrentCulture { get; private set; }
	/// <summary>
	/// The <see cref="DeviceConfigFileName"/> property.
	/// </summary>
	public static string DeviceConfigFileName { get; private set; }
	/// <summary>
	/// The <see cref="LogFileName"/> property.
	/// </summary>
	public static string LogFileName { get; private set; }

	/// <summary>
	/// The static <see cref="Statics"/> class constructor.
	/// </summary>
	static Statics()
	{
		assembly = Assembly.GetExecutingAssembly();
		AssemblyDirectory = Path.GetDirectoryName(assembly.Location)!;
		AssemblyName = assembly.GetName().Name!;
		CurrentCulture = CultureInfo.CurrentCulture;
		DeviceConfigFileName = $"{AssemblyDirectory}\\Device.Configuration.xml";
		LogFileName = $"{AssemblyDirectory}\\{AssemblyName}.log";
	}
}