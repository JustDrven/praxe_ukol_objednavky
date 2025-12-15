/*******************************************
 * 
 * Copyright (c) High School Blek, 2025
 * 
 * File:        UtilWindow.cs
 * Author:      JustDrven
 * 
 *******************************************/

namespace praxe_desktop_client.Utilities
{
    internal class UtilWindow
    {

        public static bool IsWindowValid(Form f)
        {
            return (f != null) && (!f.IsDisposed);
        }
    
        public static void DisableResizeable(Form f)
        {
            if (!IsWindowValid(f)) return;


            f.MinimumSize = new Size(f.Width, f.Height);
            f.MaximumSize = f.MinimumSize;

        }

        public static void SetTitle(Form f, string title)
        {
            if (!IsWindowValid(f)) return;


            if (string.IsNullOrEmpty(title)) return;

            f.Text = "Praxe - " + title;

        }
    
    }
}
