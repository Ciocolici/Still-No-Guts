using System.Runtime.InteropServices;

namespace Still_No_Guts;

internal class Program
{
    [DllImport("kernel32.dll")]
    public static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    const int SW_MAXIMIZE = 3;
    static void Main(string[] args)
    {
        IntPtr handle = GetConsoleWindow();
        if (handle != IntPtr.Zero)
        {
            ShowWindow(handle, SW_MAXIMIZE);
        }

        Story.Start();
    }
}