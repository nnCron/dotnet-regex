using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGiesecke.DllExport;
using System.Runtime.InteropServices;

namespace re
{
    public static partial class re
    {
        /// <summary>
        /// Wraper for objects
        /// </summary>
        public struct wrap
        {
            /// <summary>
            /// Object for wrapping
            /// </summary>
            public object o;
        }

        /// <summary>
        /// Line unmanaged Array, [ count, item1, ..., itemN ]
        /// </summary>
        public struct Arr1
        {
            /// <summary>
            /// Address of array
            /// </summary>
            public IntPtr addr;
            private int count;
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public int len()
            {
                return Marshal.ReadInt32(this.addr);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public int bytes()
            {
                return Marshal.ReadInt32(this.addr) * CELL + CELL;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="l"></param>
            public Arr1(int l)
            {
                addr = Marshal.AllocCoTaskMem(l * CELL + CELL);
                Marshal.WriteInt32(addr, l);
                count = 0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="val"></param>
            public void push(Int32 val){
                Marshal.WriteInt32(addr, count * CELL + CELL, val);
                count++;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="val"></param>
            public void push(IntPtr val)
            {
                Marshal.WriteInt32(addr, count * CELL + CELL, val.ToInt32());
                count++;
            }
            /// <summary>
            /// 
            /// </summary>
            public void free()
            {
                Marshal.FreeCoTaskMem(addr);
                addr = (IntPtr)0;
                count = 0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="addr"></param>
            public static void free(IntPtr addr)
            {
                Marshal.FreeCoTaskMem(addr);
            }
        }


        /// <summary>
        /// 2 dim unmanaged Array, [ count, Arr1, ..., ArrN ]
        /// 3 dim unmanaged Array, [ count, Arr1[count, str1, ..., strN], ..., ArrN ]
        /// </summary>
        public struct Arr2
        {
            /// <summary>
            /// 
            /// </summary>
            public IntPtr addr;
            private int count;
            private int itemCount;
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public int len()
            {
                return Marshal.ReadInt32(this.addr);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public int bytes()
            {
                return Marshal.ReadInt32(this.addr) * CELL + CELL;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="l"></param>
            public Arr2(int l)
            {
                addr = Marshal.AllocCoTaskMem(l * CELL + CELL);
                Marshal.WriteInt32(addr, l);
                count = 0;
                itemCount = 0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="l"></param>
            public void add(int l)
            {
                IntPtr item = Marshal.AllocCoTaskMem(l * CELL + CELL);
                Marshal.WriteInt32(item, l);
                Marshal.WriteInt32(addr, count * CELL + CELL, item.ToInt32());
                itemCount = 0;
            }
            /// <summary>
            /// 
            /// </summary>
            public void next(){ count++; }
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public IntPtr item()
            {
                return (IntPtr)Marshal.ReadInt32(addr, count * CELL + CELL);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public int itemLen()
            {
                return Marshal.ReadInt32( (IntPtr)Marshal.ReadInt32(addr, count * CELL + CELL) );
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="val"></param>
            public void push(IntPtr val)
            {
                Marshal.WriteInt32( item(), itemCount * CELL + CELL, val.ToInt32() );
                itemCount++;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="val"></param>
            public void push(Int32 val)
            {
                Marshal.WriteInt32(item(), itemCount * CELL + CELL, val);
                itemCount++;
            }
            /// <summary>
            /// 
            /// </summary>
            public void free()
            {
                for (int i = 0; i < count; i++)
                {
                    Marshal.FreeCoTaskMem((IntPtr)Marshal.ReadInt32(addr, i * CELL + CELL));
                }
                Marshal.FreeCoTaskMem(addr);
                addr = (IntPtr)0;
                count = 0;
                itemCount = 0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="addr"></param>
            public static void free(IntPtr addr)
            {
                int count = Marshal.ReadInt32(addr);
                for (int i = 0; i < count; i++)
                {
                    Marshal.FreeCoTaskMem(
                        (IntPtr)Marshal.ReadInt32(addr, i * CELL + CELL)
                    );
                }
                Marshal.FreeCoTaskMem(addr);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="addr"></param>
            public static void itemsFree(IntPtr addr)
            {
                int count = Marshal.ReadInt32(addr);
                int itemCount;
                int j;
                IntPtr item;
                for (int i = 0; i < count; i++)
                {
                    item = (IntPtr)Marshal.ReadInt32(addr, i * CELL + CELL);
                    itemCount = Marshal.ReadInt32(item);
                    for (j = 0; j < itemCount; j++)
                    {
                        Marshal.FreeCoTaskMem((IntPtr)Marshal.ReadInt32(item, i * CELL + CELL));
                    }
                    Marshal.FreeCoTaskMem(item);
                }
                Marshal.FreeCoTaskMem(addr);
            }

            //static public implicit operator IntPtr(Arr2 a)
            //{
            //    return a.addr;
            //}
        }

    }
}
