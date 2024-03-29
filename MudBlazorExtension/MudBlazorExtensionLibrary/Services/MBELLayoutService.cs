﻿using MudBlazor;

namespace MudBlazorExtensionLibrary.Services
{
    /// <summary>
    /// Determines the layout of the application.
    /// </summary>
    public class MBELLayoutService
    {
        /// <summary>
        /// Current theme of the application.
        /// </summary>
        public MudTheme Theme { get; protected set; }

        /// <summary>
        /// Determines whether to use the default scrollbar.
        /// </summary>
        public bool DefaultScrollbar { get; protected set; }

        /// <summary>
        /// Determines whether to use the dark palette.
        /// </summary>
        public bool IsDarkMode { get; protected set; }

        /// <summary>
        /// Determines whether to use the right-to-left layout.
        /// </summary>
        public bool RightToLeft { get; protected set; }

        /// <summary>
        /// Invoked when layout changes occur. Use this for
        /// notifying ComponentBase.StateHasChanged() when necessary.
        /// </summary>
        public event EventHandler? LayoutChanged;

        public MBELLayoutService()
        {
            Theme = new MudTheme();
            DefaultScrollbar = false;
            IsDarkMode = false;
            RightToLeft = false;

            LayoutChanged = null;
        }

        public void SetTheme(MudTheme theme)
        {
            Theme = theme;
            LayoutChanged?.Invoke(this, EventArgs.Empty);
        }

        public void SetDefaultScrollbar(bool defaultScrollbar)
        {
            DefaultScrollbar = defaultScrollbar;
            LayoutChanged?.Invoke(this, EventArgs.Empty);
        }
        public void ToggleDefaultScrollbar()
        {
            SetDefaultScrollbar(!DefaultScrollbar);
        }

        public void SetIsDarkMode(bool isDarkMode)
        {
            IsDarkMode = isDarkMode;
            LayoutChanged?.Invoke(this, EventArgs.Empty);
        }
        public void ToggleIsDarkMode()
        {
            SetIsDarkMode(!IsDarkMode);
        }

        public void SetRightToLeft(bool rightToLeft)
        {
            RightToLeft = rightToLeft;
            LayoutChanged?.Invoke(this, EventArgs.Empty);
        }
        public void ToggleRightToLeft()
        {
            SetRightToLeft(!RightToLeft);
        }
    }
}
