using System;

/// <summary>
/// Class for exception operations
/// </summary>
class Except
{
    /// <summary>
    /// Throws an Exception with a custom message
    /// </summary>
    /// <param name="msg">The message for the exception</param>
    public static void ThrowMsg(string msg)
    {
        throw new Exception(msg);
    }
}
