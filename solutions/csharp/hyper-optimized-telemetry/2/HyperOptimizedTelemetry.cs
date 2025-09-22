using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] allBytes = new byte[9];

        byte[] bytes;
        if (reading > UInt32.MaxValue || reading < Int32.MinValue)
        {
            allBytes[0] = 0xf8;
            bytes = BitConverter.GetBytes(reading);
            bytes.CopyTo(allBytes, 1);
        }
        else if (reading > Int32.MaxValue)
        {
            allBytes[0] = 0x4;
            bytes = BitConverter.GetBytes((uint)reading);
            bytes.CopyTo(allBytes, 1);
        }
        else if (reading > UInt16.MaxValue || reading < Int16.MinValue)
        {
            allBytes[0] = 0xfc;
            bytes = BitConverter.GetBytes((int)reading);
            bytes.CopyTo(allBytes, 1);
        }
        else if (reading >= 0)
        {
            allBytes[0] = 0x2;
            bytes = BitConverter.GetBytes((ushort)reading);
            bytes.CopyTo(allBytes, 1);
        }
        else
        {
            allBytes[0] = 0xfe;
            bytes = BitConverter.GetBytes((short)reading);
            bytes.CopyTo(allBytes, 1);
        }

        return allBytes;
    }

    public static long FromBuffer(byte[] buffer) => buffer[0] switch
    {
        256 - 8 => BitConverter.ToInt64(buffer[1..]),
        256 - 4 => BitConverter.ToInt32(buffer[1..]),
        256 - 2 => BitConverter.ToInt16(buffer[1..]),
        2 => BitConverter.ToUInt16(buffer[1..]),
        4 => BitConverter.ToUInt32(buffer[1..]),
        _ => 0
    };
}


