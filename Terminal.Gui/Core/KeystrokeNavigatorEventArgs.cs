﻿using System;

namespace Terminal.Gui {
	/// <summary>
	/// Event arguments for the <see cref="CollectionNavigator.SearchStringChanged"/> event.
	/// </summary>
	public class KeystrokeNavigatorEventArgs : EventArgs {
		/// <summary>
		/// he current <see cref="SearchString"/>.
		/// </summary>
		public string SearchString { get; }

		/// <summary>
		/// Initializes a new instance of <see cref="KeystrokeNavigatorEventArgs"/>
		/// </summary>
		/// <param name="searchString">The current <see cref="SearchString"/>.</param>
		public KeystrokeNavigatorEventArgs (string searchString)
		{
			SearchString = searchString;
		}
	}
}
