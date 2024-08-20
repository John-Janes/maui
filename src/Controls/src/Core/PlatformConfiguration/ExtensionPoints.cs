namespace Microsoft.Maui.Controls.PlatformConfiguration
{
	/// <summary>
	/// Marker class that identifies the Android platform.
	/// </summary>
	/// <remarks>
	/// Developers specifiy the type name of this marker class to the <see cref="M:Microsoft.Maui.Controls.IElementConfiguration`1.On``1" /> method to specify the underlying Android control on which to run a platform-specific effect.
	/// </remarks>
	public sealed class Android : IConfigPlatform { }

	/// <summary>
	/// Marker class that identifies the iOS platform.
	/// </summary>
	/// <remarks>
	/// Developers specify the type name of this marker class to the <see cref = "M:Microsoft.Maui.Controls.IElementConfiguration`1.On``1" /> method to specify the underlying iOS control on which to run a platform-specific effect.
	/// </remarks>
	public sealed class iOS : IConfigPlatform { }

	/// <summary>
	/// Marker class that identifies the Windows platform.
	/// </summary>
	/// <remarks>
	/// Developers specify the type name of this marker class to the <see cref = "M:Microsoft.Maui.Controls.IElementConfiguration`1.On``1" /> method to specify the underlying Windows control on which to run a platform-specific effect.
	/// </remarks>
	public sealed class Windows : IConfigPlatform { }

	/// <summary>
	/// Marker class that identifies the Tizen platform.
	/// </summary>
	/// <remarks>
	/// Developers specify the type name of this marker class to the <see cref = "M:Microsoft.Maui.Controls.IElementConfiguration`1.On``1" /> method to specify the underlying Tizen control on which to run a platform-specific effect.
	/// </remarks>
	public sealed class Tizen : IConfigPlatform { }
	/// <summary>Marker class that identifies the macOS platform.</summary>
	/// <remarks>
	/// Developers specify the type name of this marker class to the <see cref = "M:Microsoft.Maui.Controls.IElementConfiguration`1.On``1" /> method to specify the underlying iOS control on which to run a platform-specific effect.
	/// </remarks>
	public sealed class macOS : IConfigPlatform { }

	/// <include file="../../../docs/Microsoft.Maui.Controls.PlatformConfiguration/GTK.xml" path="Type[@FullName='Microsoft.Maui.Controls.PlatformConfiguration.GTK']/Docs/*" />
	public sealed class GTK : IConfigPlatform { }
}
