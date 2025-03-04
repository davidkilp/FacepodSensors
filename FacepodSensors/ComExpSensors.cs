using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FacepodSensors
{
    class ComExpSensors
    {
        #region dllImports
        private const string dllPath = @"FpBoardInfo.dll";

        // External C++ Functions
        [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr FpBoardInfo_Instantiate();

        [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void FpBoardInfo_Destroy(IntPtr p);

        [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double FpBoardInfo_getCPU_Temp(IntPtr p);

        [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double FpBoardInfo_getChipset_Temp(IntPtr p);

        [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double FpBoardInfo_getSystem_Temp(IntPtr p);

        [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double FpBoardInfo_getVBat(IntPtr p);

        [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double FpBoardInfo_getSys5VSB(IntPtr p);

        [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern double FpBoardInfo_getSys12V(IntPtr p);

        [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 FpBoardInfo_getSysFanRpm(IntPtr p);

        #endregion
    }
}
