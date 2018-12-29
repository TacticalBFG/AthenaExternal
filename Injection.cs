using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace AthenaExternal
{

    internal class Memory {
    public enum DllInjectionResult
    {
        DllNotFound,
        GameProcessNotFound,
        InjectionFailed,
        Success,
    }
    public sealed class DllInjector
    {
       
        private static readonly IntPtr INTPTR_ZERO = (IntPtr) 0;
      private static Memory.DllInjector _instance;

      [DllImport("kernel32.dll", SetLastError = true)]
      private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

      [DllImport("kernel32.dll", SetLastError = true)]
      private static extern int CloseHandle(IntPtr hObject);

      [DllImport("kernel32.dll", SetLastError = true)]
      private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

      [DllImport("kernel32.dll", SetLastError = true)]
      private static extern IntPtr GetModuleHandle(string lpModuleName);

      [DllImport("kernel32.dll", SetLastError = true)]
      private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

      [DllImport("kernel32.dll", SetLastError = true)]
      private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

      [DllImport("kernel32.dll", SetLastError = true)]
      private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

      public static Memory.DllInjector GetInstance
      {
        get
        {
          if (Memory.DllInjector._instance == null)
            Memory.DllInjector._instance = new Memory.DllInjector();
          return Memory.DllInjector._instance;
        }
      }

      private DllInjector()
      {
      }

      public Memory.DllInjectionResult Inject(string sProcName, string sDllPath)
      {
        if (!File.Exists(sDllPath))
          return Memory.DllInjectionResult.DllNotFound;
        uint pToBeInjected = 0;
        Process[] processes = Process.GetProcesses();
        for (int index = 0; index < processes.Length; ++index)
        {
          if (processes[index].ProcessName == sProcName)
          {
            pToBeInjected = (uint) processes[index].Id;
            break;
          }
        }
        if ((int) pToBeInjected == 0)
          return Memory.DllInjectionResult.GameProcessNotFound;
        return !this.bInject(pToBeInjected, sDllPath) ? Memory.DllInjectionResult.InjectionFailed : Memory.DllInjectionResult.Success;
      }

      private unsafe bool bInject(uint pToBeInjected, string sDllPath)
      {
        IntPtr num1 = Memory.DllInjector.OpenProcess(1082U, 1, pToBeInjected);
        if (num1 == Memory.DllInjector.INTPTR_ZERO)
          return false;
        IntPtr procAddress = Memory.DllInjector.GetProcAddress(Memory.DllInjector.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
        if (procAddress == Memory.DllInjector.INTPTR_ZERO)
          return false;
        IntPtr num2 = Memory.DllInjector.VirtualAllocEx(num1, (IntPtr) ((void*) null), (IntPtr) sDllPath.Length, 12288U, 64U);
        if (num2 == Memory.DllInjector.INTPTR_ZERO)
          return false;
        byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);
        if (Memory.DllInjector.WriteProcessMemory(num1, num2, bytes, (uint) bytes.Length, 0) == 0 || Memory.DllInjector.CreateRemoteThread(num1, (IntPtr) ((void*) null), Memory.DllInjector.INTPTR_ZERO, procAddress, num2, 0U, (IntPtr) ((void*) null)) == Memory.DllInjector.INTPTR_ZERO)
          return false;
        Memory.DllInjector.CloseHandle(num1);
        return true;
      }
    }

    }
}
