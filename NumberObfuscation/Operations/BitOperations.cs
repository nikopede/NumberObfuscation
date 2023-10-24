﻿namespace NumberObfuscation.Operations;

public static class BitOperations
{
    public static uint ReverseBits(uint x)
    {
        x = ((x & 0x55555555) << 1) | ((x & 0xAAAAAAAA) >> 1);
        x = ((x & 0x33333333) << 2) | ((x & 0xCCCCCCCC) >> 2);
        x = ((x & 0x0F0F0F0F) << 4) | ((x & 0xF0F0F0F0) >> 4);
        x = ((x & 0x00FF00FF) << 8) | ((x & 0xFF00FF00) >> 8);
        x = (x << 16) | (x >> 16);

        return x;
    }
    
    public static uint Xor(uint a, uint b)
    {
        return a ^ b;
    }
}