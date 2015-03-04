// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that converts the @this to a nullable date time off set.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DateTimeOffset?</returns>
    public static DateTimeOffset? ToNullableDateTimeOffSet(this object @this)
    {
        if (@this == null || @this == DBNull.Value)
        {
            return null;
        }

        return new DateTimeOffset(Convert.ToDateTime(@this), TimeSpan.Zero);
    }
}