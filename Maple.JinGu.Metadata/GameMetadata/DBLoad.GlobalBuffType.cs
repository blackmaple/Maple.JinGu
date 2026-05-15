namespace Maple.JinGu.Metadata
{
    /// <summary>
    /// ["Assembly-CSharp"."DBLoad"."GlobalBuffType"]
    /// </summary>
    public enum GlobalBuffType : System.Int32
    {
        Passive = 0x00000001,
        LvChange = 0x00000007,
        Change = 0x00000008,
        AddEffect = 0x00000009,
        AddItem = 0x0000000A,
        Alone = 0x0000000B,
        Dot = 0x0000000D
    }
}