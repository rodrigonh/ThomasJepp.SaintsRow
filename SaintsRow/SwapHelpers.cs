﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThomasJepp.SaintsRow
{
    public static class SwapHelpers
    {
        public static Int16 Swap(this Int16 value)
        {
            UInt16 uvalue = (UInt16)value;
            UInt16 swapped = (UInt16)((0x00FF) & (value >> 8) |
                                      (0xFF00) & (value << 8));
            return (Int16)swapped;
        }

        public static UInt16 Swap(this UInt16 value)
        {
            UInt16 swapped = (UInt16)((0x00FF) & (value >> 8) |
                                      (0xFF00) & (value << 8));
            return swapped;
        }

        public static Int32 Swap(this Int32 value)
        {
            UInt32 uvalue = (UInt32)value;
            UInt32 swapped = ((0x000000FF) & (uvalue >> 24) |
                              (0x0000FF00) & (uvalue >> 8) |
                              (0x00FF0000) & (uvalue << 8) |
                              (0xFF000000) & (uvalue << 24));
            return (Int32)swapped;
        }

        public static UInt32 Swap(this UInt32 value)
        {
            UInt32 swapped = ((0x000000FF) & (value >> 24) |
                              (0x0000FF00) & (value >> 8) |
                              (0x00FF0000) & (value << 8) |
                              (0xFF000000) & (value << 24));
            return swapped;
        }

        public static Int64 Swap(this Int64 value)
        {
            UInt64 uvalue = (UInt64)value;
            UInt64 swapped = ((0x00000000000000FF) & (uvalue >> 56) |
                              (0x000000000000FF00) & (uvalue >> 40) |
                              (0x0000000000FF0000) & (uvalue >> 24) |
                              (0x00000000FF000000) & (uvalue >> 8) |
                              (0x000000FF00000000) & (uvalue << 8) |
                              (0x0000FF0000000000) & (uvalue << 24) |
                              (0x00FF000000000000) & (uvalue << 40) |
                              (0xFF00000000000000) & (uvalue << 56));
            return (Int64)swapped;
        }

        public static UInt64 Swap(this UInt64 value)
        {
            UInt64 swapped = ((0x00000000000000FF) & (value >> 56) |
                              (0x000000000000FF00) & (value >> 40) |
                              (0x0000000000FF0000) & (value >> 24) |
                              (0x00000000FF000000) & (value >> 8) |
                              (0x000000FF00000000) & (value << 8) |
                              (0x0000FF0000000000) & (value << 24) |
                              (0x00FF000000000000) & (value << 40) |
                              (0xFF00000000000000) & (value << 56));
            return swapped;
        }

        public static Single Swap(this Single value)
        {
            // lol
            var data = BitConverter.GetBytes(value);
            var rawValue = BitConverter.ToInt32(data, 0).Swap();
            return BitConverter.ToSingle(BitConverter.GetBytes(rawValue), 0);
        }
    }
}
