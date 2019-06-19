using System;

namespace EnlighmentTest
{
    public class Example
    {
#if WIN32
    [STAThreadAttribute()]
#endif
        public static void Main()
        {
            // Initialize EFL and all UI components
            Efl.All.Init(Efl.Components.Ui);

            // Create a window and initialize it
            Efl.Ui.Win win = new Efl.Ui.Win(Efl.App.AppMain);
            // Set the window's title
            win.SetText("Hello World");
            // Request that the window is automatically hidden when the "close"
            // button is pressed
            win.SetAutohide(true);
            // Window size must be explicitly set, otherwise it will be invisible
            // due to its lack of content.
            win.SetSize(new Eina.Size2D(360, 240));

            // Start the EFL main loop
            Efl.Ui.Config.Run();

            // Shutdown EFL
            Efl.All.Shutdown();
        }
    }
}
