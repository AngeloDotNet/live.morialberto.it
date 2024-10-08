﻿using System.ComponentModel;

namespace MoriAlberto.Live.WebSite.Model;

public class StreamingsSearchParameters
{
    public string Query { get; set; } = string.Empty;

    public SortDirection Sort { get; set; } = SortDirection.Descending;

    public int Page { get; set; } = 0;

    public enum SortDirection
    {
        [Description("Meno recenti")]
        Ascending,

        [Description("Più recenti")]
        Descending,
    }
}
