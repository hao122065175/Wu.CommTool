﻿namespace Wu.CommTool.Modules.ModbusRtu.Enums;

/// <summary>
/// Modbus停止位
/// </summary>
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum StopBits
{
    [Description("1")]
    One = 1,
    [Description("2")]
    Two,
    [Description("1.5")]
    OnePointFive
}
