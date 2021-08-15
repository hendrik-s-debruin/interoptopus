// Automatically generated by Interoptopus.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using My.Company;
using My.Company.Common;

namespace My.Company.Common
{

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec
    {
        public double x;
        public double z;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate Tupled InteropDelegate_fn_Tupled_rval_Tupled(Tupled x0);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate bool InteropDelegate_fn_pmut_i64_rval_bool(out long x0);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte InteropDelegate_fn_u8_rval_u8(byte x0);

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SliceBool
    {
        IntPtr data;
        ulong len;
    }

    public partial struct SliceBool : IEnumerable<Bool>
    {
        public SliceBool(GCHandle handle, ulong count)
        {
            this.data = handle.AddrOfPinnedObject();
            this.len = count;
        }
        public SliceBool(IntPtr handle, ulong count)
        {
            this.data = handle;
            this.len = count;
        }
        public Bool this[int i]
        {
            get
            {
                if (i >= Count) throw new IndexOutOfRangeException();
                unsafe
                {
                    var d = (Bool*) data.ToPointer();
                    return d[i];
                }
            }
        }
        public Bool[] Copied
        {
            get
            {
                var rval = new Bool[len];
                unsafe
                {
                    fixed (void* dst = rval)
                    {
                        Unsafe.CopyBlock(dst, data.ToPointer(), (uint)len);
                    }
                }
                return rval;
            }
        }
        public int Count => (int) len;
        public IEnumerator<Bool> GetEnumerator()
        {
            for (var i = 0; i < (int)len; ++i)
            {
                yield return this[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }


    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Sliceu32
    {
        IntPtr data;
        ulong len;
    }

    public partial struct Sliceu32 : IEnumerable<uint>
    {
        public Sliceu32(GCHandle handle, ulong count)
        {
            this.data = handle.AddrOfPinnedObject();
            this.len = count;
        }
        public Sliceu32(IntPtr handle, ulong count)
        {
            this.data = handle;
            this.len = count;
        }
        public uint this[int i]
        {
            get
            {
                if (i >= Count) throw new IndexOutOfRangeException();
                unsafe
                {
                    var d = (uint*) data.ToPointer();
                    return d[i];
                }
            }
        }
        public uint[] Copied
        {
            get
            {
                var rval = new uint[len];
                unsafe
                {
                    fixed (void* dst = rval)
                    {
                        Unsafe.CopyBlock(dst, data.ToPointer(), (uint)len);
                    }
                }
                return rval;
            }
        }
        public int Count => (int) len;
        public IEnumerator<uint> GetEnumerator()
        {
            for (var i = 0; i < (int)len; ++i)
            {
                yield return this[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }


    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Sliceu8
    {
        IntPtr data;
        ulong len;
    }

    public partial struct Sliceu8 : IEnumerable<byte>
    {
        public Sliceu8(GCHandle handle, ulong count)
        {
            this.data = handle.AddrOfPinnedObject();
            this.len = count;
        }
        public Sliceu8(IntPtr handle, ulong count)
        {
            this.data = handle;
            this.len = count;
        }
        public byte this[int i]
        {
            get
            {
                if (i >= Count) throw new IndexOutOfRangeException();
                unsafe
                {
                    var d = (byte*) data.ToPointer();
                    return d[i];
                }
            }
        }
        public byte[] Copied
        {
            get
            {
                var rval = new byte[len];
                unsafe
                {
                    fixed (void* dst = rval)
                    {
                        Unsafe.CopyBlock(dst, data.ToPointer(), (uint)len);
                    }
                }
                return rval;
            }
        }
        public int Count => (int) len;
        public IEnumerator<byte> GetEnumerator()
        {
            for (var i = 0; i < (int)len; ++i)
            {
                yield return this[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }


    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SliceMutu8
    {
        IntPtr data;
        ulong len;
    }

    public partial struct SliceMutu8 : IEnumerable<byte>
    {
        public SliceMutu8(GCHandle handle, ulong count)
        {
            this.data = handle.AddrOfPinnedObject();
            this.len = count;
        }
        public SliceMutu8(IntPtr handle, ulong count)
        {
            this.data = handle;
            this.len = count;
        }
        public byte this[int i]
        {
            get
            {
                if (i >= Count) throw new IndexOutOfRangeException();
                unsafe
                {
                    var d = (byte*) data.ToPointer();
                    return d[i];
                }
            }
            set
            {
                if (i >= Count) throw new IndexOutOfRangeException();
                unsafe
                {
                    var d = (byte*) data.ToPointer();
                    d[i] = value;
                }
            }
        }
        public byte[] Copied
        {
            get
            {
                var rval = new byte[len];
                unsafe
                {
                    fixed (void* dst = rval)
                    {
                        Unsafe.CopyBlock(dst, data.ToPointer(), (uint)len);
                    }
                }
                return rval;
            }
        }
        public int Count => (int) len;
        public IEnumerator<byte> GetEnumerator()
        {
            for (var i = 0; i < (int)len; ++i)
            {
                yield return this[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }


    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Bool
    {
        byte value;
    }

    public partial struct Bool
    {
        public static readonly Bool True = new Bool { value =  1 };
        public static readonly Bool False = new Bool { value =  0 };
        public Bool(bool b)
        {
            value = (byte) (b ? 1 : 0);
        }
        public bool Is => value == 1;
    }


    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte CallbackFFISlice(Sliceu8 x0);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate Vec3f32 CallbackHugeVecSlice(SliceVec3f32 x0);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CallbackSliceMut(SliceMutu8 x0);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint MyCallback(uint x0);


}
