using System;

[Serializable]
public class Settings
{
    public bool ShowDebug = false;
    public bool SaveDebug = false;

    public override string ToString()
    {
        return $"ShowDebug:{ShowDebug} | SaveDebug:{SaveDebug}";
    }
}
